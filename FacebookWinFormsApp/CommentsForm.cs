using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FacebookCustomAppEngine;

namespace BasicFacebookFeatures
{
    public partial class CommentsForm : BaseClassOfAllFeaturesForm
    {
        private readonly string r_PostId;

        public CommentsForm(string i_PostId)
        {
            this.r_PostId = i_PostId;
            this.InitializeComponent();
        }

        private void m_ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CommentsForm_Load(object sender, EventArgs e)
        {
            int width = 20;
            int height = 20;
            int maxHeight = -1;
            Dictionary<string, string> comments = FacebookAppEngine.Instance.FetchCommentOfPost(this.r_PostId);

            foreach (KeyValuePair<string, string> pair in comments)
            {
                Label commentLabel = new();
                commentLabel.BorderStyle = BorderStyle.FixedSingle;
                commentLabel.BackColor = Color.Silver;
                commentLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 177);
                commentLabel.Location = new Point(width, height);
                commentLabel.Text = pair.Value;
                width += commentLabel.Width + 30;
                maxHeight = Math.Max(commentLabel.Height, maxHeight);
                if (width > this.ClientSize.Width - 100)
                {
                    width = 20;
                    height += maxHeight + 10;
                }

                this.Controls.Add(commentLabel);
            }

            this.ClientSize = new Size(this.Size.Width, Math.Max((height + height) / 4, this.Size.Height));
            
            if (comments.Count == 0)
            {
                MessageBox.Show("No Comments to retrieve.");
                this.Close();
            }
        }
    }
}
