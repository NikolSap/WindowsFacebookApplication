using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FacebookCustomAppEngine;

namespace BasicFacebookFeatures
{
    public partial class EventsForm : BaseClassOfAllFeaturesForm
    {
        public EventsForm()
        {
            this.InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Dictionary<string, object> events = FacebookAppEngine.Instance.FetchEventsImagesDictionary();
            int width = 10;
            int height = 10;
            int maxHeight = -1;
            foreach (KeyValuePair<string, object> keyValuePair in events)
            {
                PictureBox coverEventsPictureBox = new PictureBox();
                coverEventsPictureBox.Location = new Point(width, height);
                coverEventsPictureBox.Image = (keyValuePair.Value as ImageAndString)?.image;
                coverEventsPictureBox.AutoSize = true;
                coverEventsPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                coverEventsPictureBox.Size = new Size(250, 200);
                width += coverEventsPictureBox.Width + 10;
                maxHeight = Math.Max(coverEventsPictureBox.Height, maxHeight);
                if (width > this.ClientSize.Width - 100)
                {
                    width = 5;
                    height += maxHeight + 5;
                }

                Controls.Add(coverEventsPictureBox);
            }

            this.ClientSize = new Size(this.Size.Width, Math.Max((height + height) / 2, this.ClientSize.Height));

            if (events.Count == 0)
            {
                MessageBox.Show("No Events to retrieve.");
                this.Close();
            }
        }

        private void m_ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
