using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FacebookCustomAppEngine;

namespace BasicFacebookFeatures
{
    public partial class PostsForm : BaseClassOfAllFeaturesForm
    {
        public PostsForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            int width = 40;
            int height = 20;
            int maxHeight = -1;
            Dictionary<string, string> posts = FacebookAppEngine.Instance.FetchPostsText();

            foreach (KeyValuePair<string, string> keyValuePair in posts)
            {

                Button postButton = new Button();
                postButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 177);
                postButton.Location = new Point(width, height);
                postButton.Name = keyValuePair.Key;
                postButton.Text = keyValuePair.Value;
                postButton.Width = 400;
                width += postButton.Width + 40;
                maxHeight = Math.Max(postButton.Height, maxHeight);
                if (width > this.ClientSize.Width - 100)
                {
                    width = 40;
                    height += maxHeight + 10;
                }

                postButton.Click += post_Click;
                Controls.Add(postButton);
            }

            if (posts.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve.");
                this.Close();
            }
        }

        private void post_Click(object sender, EventArgs e)
        {
            string selectedPostName = (sender as Button)?.Name;
            Hide();
            BaseClassOfAllFeaturesForm commentsForm = FormFeaturesFactory.Create(
                eFeatureType.CommentsForm,
                selectedPostName);
            commentsForm.ShowDialog();
            Show();
        }

        private void m_ReturnButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
