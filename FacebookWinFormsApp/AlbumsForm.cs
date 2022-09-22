using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FacebookCustomAppEngine;

namespace BasicFacebookFeatures
{
    public partial class AlbumsForm : BaseClassOfAllFeaturesForm
    {
        public AlbumsForm()
        {
            this.InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Dictionary<string, object> albumsCollection = FacebookAppEngine.Instance.FetchAlbumsImageDictionary();
            int width = 20;
            int height = 20;
            int maxHeight = -1;
            if(albumsCollection.Count != 0)
            {
                foreach(KeyValuePair<string, object> pair in albumsCollection)
                {
                    PictureBox coverAlbumPictureBox = new();

                    Thread thread = new Thread(() => createPictureBox(coverAlbumPictureBox, (pair.Value as ImageAndString)?.image, pair.Key, new Point(width, height)));
                    thread.Start();
                    width += coverAlbumPictureBox.Width + 10;
                    maxHeight = Math.Max(coverAlbumPictureBox.Height, maxHeight);
                  
                    if(width > ClientSize.Width - 100)
                    {
                        width = 20;
                        height += maxHeight + 10;
                    }

                    this.Size = new Size(this.Size.Width, (height + height) / 4);
                }

                if(albumsCollection.Count == 0)
                {
                    MessageBox.Show("No Albums to retrieve.");
                    this.Close();
                }
            }
        }

        private void AlbumCoverPicture_Click(object sender, EventArgs e)
        {
            string idOfClickedAlbum = (sender as PictureBox)?.Text;
            BaseClassOfAllFeaturesForm photosForm = FormFeaturesFactory.Create(eFeatureType.PhotosForm,idOfClickedAlbum);
            this.Hide();
            photosForm.ShowDialog();
            this.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
        }

        private void m_ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createPictureBox(PictureBox i_AlbumPictureBox, Image i_ImageOfAlbumCover, string i_AlbumName, Point i_location)
        {

            i_AlbumPictureBox.BackgroundImage = i_ImageOfAlbumCover;
            i_AlbumPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            i_AlbumPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            i_AlbumPictureBox.Location = i_location;
            i_AlbumPictureBox.Text = i_AlbumName;


            i_AlbumPictureBox.Click += this.AlbumCoverPicture_Click;
            this.Invoke(new Action(()=>Controls.Add(i_AlbumPictureBox)));
        }
    }
}
