using System.Diagnostics.Contracts;
using Microsoft.Extensions.Configuration;
using System.Net.Sockets;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;

namespace AzureAiLabb2;

public class ImageAi
{
    private string _cogSvcEndpoint;
    private string _cogSvcKey;
    private ApiKeyServiceClientCredentials _credentials;
    private ComputerVisionClient _cvClient;

    public ImageAi()
    {
        var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
        var configuration = builder.Build();
        _cogSvcEndpoint = configuration["CognitiveServiceEndpoint"];
        _cogSvcKey = configuration["CognitiveServiceKey"];
        _credentials = new ApiKeyServiceClientCredentials(_cogSvcKey);
    }

    public async Task AuthorizeAsync()
    {
        await Task.Run(() =>
        {
            _cvClient = new ComputerVisionClient(_credentials)
            {
                Endpoint = _cogSvcEndpoint
            };
        });
    }

    public async Task<Image> GenerateThumbnail(string imagePath)
    {
        await AuthorizeAsync();

        // Generate a thumbnail
        await using var imageData = File.OpenRead(imagePath);
        // Get thumbnail data
        var thumbnailImage = Image.FromStream(await _cvClient.GenerateThumbnailInStreamAsync(200,
            150, imageData, true));

        return thumbnailImage;
    }

    public async Task<ICollection<string>> GetImageContent(string imagePath)
    {
        await AuthorizeAsync();
        
        List<VisualFeatureTypes?> features = new List<VisualFeatureTypes?>()
        {
            VisualFeatureTypes.Description,
            VisualFeatureTypes.Tags,
            VisualFeatureTypes.Categories,
            VisualFeatureTypes.Brands,
            VisualFeatureTypes.Objects,
            VisualFeatureTypes.Adult
        };
        var captions = new List<string>();
        try
        {
            await using Stream imageStream = File.OpenRead(imagePath);
            // Analyze the local image.
            ImageAnalysis results = await _cvClient.AnalyzeImageInStreamAsync(imageStream, features);

            if (results.Description?.Captions != null)
                foreach (var caption in results.Description.Captions)
                {
                    captions.Add($"Description: {caption.Text} (confidence:{caption.Confidence.ToString("P")})");
                }
            // Get image tags
            if (results.Tags.Count > 0)
            {
                Console.WriteLine("Tags:");
                foreach (var tag in results.Tags)
                {
                    captions.Add($" -{tag.Name} (confidence:{tag.Confidence.ToString("P")})");
                }
            }
        }
        catch
        {
            captions.Add("Bad response");
            return captions;
        }
       
        

        return captions;
    }

    
}