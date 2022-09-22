using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FacebookCustomAppEngine;

namespace BasicFacebookFeatures
{
    public partial class GroupsForm : BaseClassOfAllFeaturesForm
    {
        public GroupsForm()
        {
            this.InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            Dictionary<string, object> groups = FacebookAppEngine.Instance.FetchGroupsCoverImageDictionary();
            int width = 10;
            int height = 10;
            int maxHeight = -1;

            foreach (KeyValuePair<string, object> keyValuePair in groups)
            {
                PictureBox coverGroupPictureBox = new PictureBox();
                coverGroupPictureBox.Image = (keyValuePair.Value as ImageAndString)?.image;
                coverGroupPictureBox.AutoSize = true;
                coverGroupPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                coverGroupPictureBox.Size = new Size(250, 200);
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

            if (groups.Count == 0)
            {
                MessageBox.Show("No Groups to retrieve.");
                this.Close();
            }
        }

        private void m_ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
