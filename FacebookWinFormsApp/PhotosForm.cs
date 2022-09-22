using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FacebookCustomAppEngine;

namespace BasicFacebookFeatures
{
    public partial class PhotosForm : BaseClassOfAllFeaturesForm
    {
        private readonly string r_IdOfTheCointainAlbum;

        public PhotosForm(string i_AlbumId)
        {
            r_IdOfTheCointainAlbum = i_AlbumId;
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Dictionary<string, Image> photoCollection = FacebookAppEngine.Instance.FetchPhotoAlbum(r_IdOfTheCointainAlbum);
            int width = 20;
            int height = 20;
            int maxHeight = -1;
            foreach (KeyValuePair<string, Image> pair in photoCollection)
            {
                PictureBox photoPictureBox = new PictureBox();
                photoPictureBox.Image = pair.Value;
                photoPictureBox.Location = new Point(width, height);
                photoPictureBox.Text = pair.Key;
                width += photoPictureBox.Width + 10;
                maxHeight = Math.Max(photoPictureBox.Height, maxHeight);
                if (width > this.ClientSize.Width - 100)
                {
                    width = 20;
                    height += maxHeight + 10;
                }
                Controls.Add(photoPictureBox);
            }

            ClientSize = new Size(this.Size.Width, height + height / 4);

            if (photoCollection.Count == 0)
            {
                MessageBox.Show("No Photos to retrieve.");
                Close();
            }
        }
        private void m_ReturnButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void PhotosForm_Load(object sender, EventArgs e)
        {

        }
    }
}