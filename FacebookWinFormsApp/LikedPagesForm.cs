using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FacebookCustomAppEngine;

namespace BasicFacebookFeatures
{
    public partial class LikedPagesForm : BaseClassOfAllFeaturesForm
    {
        public LikedPagesForm()
        {
            this.InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            Dictionary<string, object> likedPages = FacebookAppEngine.Instance.FetchLikedPagesImagesDictionary();
            int width = 10;
            int height = 10;
            int maxHeight = -1;
            foreach (KeyValuePair<string, object> keyValuePair in likedPages)
            {
                PictureBox coverLikedPagePictureBox = new PictureBox();
                coverLikedPagePictureBox.Image = (keyValuePair.Value as ImageAndString)?.image;
                coverLikedPagePictureBox.AutoSize = true;
                coverLikedPagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                coverLikedPagePictureBox.Size = new Size(200, 150);
                coverLikedPagePictureBox.Location = new Point(width, height);
                width += coverLikedPagePictureBox.Width + 10;
                maxHeight = Math.Max(coverLikedPagePictureBox.Height, maxHeight);

                if (width > this.Size.Width - 100)
                {
                    width = 10;
                    height += maxHeight + 10;
                }

                this.Controls.Add(coverLikedPagePictureBox);
            }
            this.ClientSize = new Size(this.Size.Width, Math.Max((height + height) / 4, Size.Height));

            if (likedPages.Count == 0)
            {
                MessageBox.Show("No Liked pages to retrieve.");
                this.Close();
            }
        }

        private void m_ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
