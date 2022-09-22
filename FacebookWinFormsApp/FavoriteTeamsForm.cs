using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FacebookCustomAppEngine;

namespace BasicFacebookFeatures
{
    public partial class FavoriteTeamsFrom : BaseClassOfAllFeaturesForm
    {

        public FavoriteTeamsFrom()
        {
            this.InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            Dictionary<string, object> favoriteTeams = FacebookAppEngine.Instance.FetchAllFavoritesTeamsImageDictionary();
            int width = 10;
            int height = 10;
            int maxHeight = -1;

            if (favoriteTeams.Count == 0)
            {
                MessageBox.Show("No Favorite teams to retrieve.");
                this.Close();
            }
            else
            {
                foreach (KeyValuePair<string, object> keyValuePair in favoriteTeams)
                {
                    PictureBox coverGroupPictureBox = new PictureBox();
                    coverGroupPictureBox.Image = (keyValuePair.Value as ImageAndString)?.image;
                    coverGroupPictureBox.AutoSize = true;
                    coverGroupPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    coverGroupPictureBox.Size = new Size(200, 150);
                    coverGroupPictureBox.Location = new Point(width, height);
                    width += coverGroupPictureBox.Width + 10;
                    maxHeight = Math.Max(coverGroupPictureBox.Height, maxHeight);

                    if (width > this.ClientSize.Width - 100)
                    {
                        width = 10;
                        height += maxHeight + 10;
                    }

                    this.Controls.Add(coverGroupPictureBox);
                }

                this.ClientSize = new Size(this.Size.Width, Math.Max((height + height) / 4, Size.Height));
            }
        }
        private void m_ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
