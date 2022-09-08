namespace AzureAiLabb2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void loadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePicturebox.Image = new Bitmap(ofd.FileName);

                ImageAi imageAi = new ImageAi();

                descriptionTextbox.Text = string.Join("\n*", await imageAi.GetImageContent(ofd.FileName));

                thumbnailPicturebox.Image = await imageAi.GenerateThumbnail(ofd.FileName);
            }

        }
    }
}