using System;
using FacebookCustomAppEngine;

namespace BasicFacebookFeatures
{
    public partial class RandomAlbumDataForm : BaseClassOfAllFeaturesForm
    {
        public RandomAlbumDataForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            getRandomAlbum();
        }

        private void getRandomAlbum()
        {
            Random random = new Random();
            int index = random.Next(0, FacebookAppEngine.Instance.AlbumsCollection.Count);
            albumBindingSource2.DataSource = FacebookAppEngine.Instance.AlbumsCollection[index];
        }

        private void m_AgainButton_Click(object sender, EventArgs e)
        {
            getRandomAlbum();
        }

        private void m_BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
