namespace AzureAiLabb2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imagePicturebox = new System.Windows.Forms.PictureBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.thumbnailPicturebox = new System.Windows.Forms.PictureBox();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagePicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePicturebox
            // 
            this.imagePicturebox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePicturebox.Location = new System.Drawing.Point(-1, 12);
            this.imagePicturebox.Name = "imagePicturebox";
            this.imagePicturebox.Size = new System.Drawing.Size(515, 328);
            this.imagePicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePicturebox.TabIndex = 0;
            this.imagePicturebox.TabStop = false;
            // 
            // loadBtn
            // 
            this.loadBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadBtn.Location = new System.Drawing.Point(12, 441);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(99, 37);
            this.loadBtn.TabIndex = 1;
            this.loadBtn.Text = "Load Image";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // thumbnailPicturebox
            // 
            this.thumbnailPicturebox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.thumbnailPicturebox.Location = new System.Drawing.Point(520, 12);
            this.thumbnailPicturebox.Name = "thumbnailPicturebox";
            this.thumbnailPicturebox.Size = new System.Drawing.Size(200, 150);
            this.thumbnailPicturebox.TabIndex = 2;
            this.thumbnailPicturebox.TabStop = false;
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextbox.Location = new System.Drawing.Point(520, 168);
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.ReadOnly = true;
            this.descriptionTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextbox.Size = new System.Drawing.Size(268, 310);
            this.descriptionTextbox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.descriptionTextbox);
            this.Controls.Add(this.thumbnailPicturebox);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.imagePicturebox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imagePicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox imagePicturebox;
        private Button loadBtn;
        private PictureBox thumbnailPicturebox;
        private TextBox descriptionTextbox;
    }
}