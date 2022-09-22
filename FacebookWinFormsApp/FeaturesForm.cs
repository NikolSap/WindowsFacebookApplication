using System;
using System.Windows.Forms;
using FacebookCustomAppEngine;

namespace BasicFacebookFeatures
{
    public partial class FeaturesForm : Form
    {
        private readonly ToolTip r_ToolTipPictureBoxGroups = new();
        private readonly ToolTip r_ToolTipPictureBoxEvents = new();
        private readonly ToolTip r_ToolTipPictureBoxLikesPages = new();
        private readonly ToolTip r_ToolTipPictureBoxFavoriteTeams = new();
        private readonly ToolTip r_ToolTipPictureBoxAlbums = new();
        private readonly ToolTip r_ToolTipPictureBoxTicTacToe = new();
        private readonly ToolTip r_ToolTipPictureBoxWhoLikeMeTheMost = new();
        private readonly ToolTip r_ToolTipPictureBoxPosts = new();
        private readonly MainForm r_MainForm;

        public FeaturesForm(MainForm i_MainForm)
        {
            this.r_MainForm = i_MainForm;
            this.InitializeComponent();
            this.r_ToolTipPictureBoxGroups.SetToolTip(this.m_PictureBoxGroups, "My Groups");
            this.r_ToolTipPictureBoxEvents.SetToolTip(this.m_PictureBoxEvents, "My Events");
            this.r_ToolTipPictureBoxFavoriteTeams.SetToolTip(this.m_pictureBoxFavoriteTeams, "Show My Favorite Teams");
            this.r_ToolTipPictureBoxLikesPages.SetToolTip(this.m_PictureBoxLikedPages, "Show My Likes Pages");
            this.r_ToolTipPictureBoxAlbums.SetToolTip(this.m_PictureBoxAlbums, "Show My Albums");
            this.r_ToolTipPictureBoxTicTacToe.SetToolTip(this.m_PictureBoxTicTacToe, "Play Tic-Tac-Toe");
            this.r_ToolTipPictureBoxWhoLikeMeTheMost.SetToolTip(this.m_PictureBoxWhoLikesTheMost, "Find Who Likes You The most");
            this.r_ToolTipPictureBoxWhoLikeMeTheMost.SetToolTip(this.m_PictureBoxPosts, "Show me Posts");
            this.r_ToolTipPictureBoxPosts.SetToolTip(this.m_PictureBoxPosts, "Show my posts");
            this.r_ToolTipPictureBoxPosts.SetToolTip(this.m_RandomAlbumPictureBox, "Show random Album");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }

        protected override void OnShown(EventArgs e)
        {
            this.m_ButtonLogin.Text = $"Logged in as {FacebookAppEngine.Instance.GetUserName()}";
            this.m_ButtonLogout.Width = this.m_ButtonLogin.Width;
            this.m_ButtonLogout.Left = this.m_ButtonLogin.Left;
            this.m_PictureBoxProfile.Image = FacebookAppEngine.Instance.GetUserProfilePicture();
            this.m_PictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void m_PictureBoxGroups_Click(object sender, EventArgs e)
        {
            BaseClassOfAllFeaturesForm groupsForm = FormFeaturesFactory.Create(eFeatureType.GroupsForm);
            this.Hide();
            groupsForm.ShowDialog();
            this.Show();
        }

        private void m_PictureBoxAlbums_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaseClassOfAllFeaturesForm albumsForm = FormFeaturesFactory.Create(eFeatureType.AlbumsForm);
            albumsForm.ShowDialog();
            this.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookAppEngine.Instance.SetUser(null);
            this.r_MainForm.UserLogout();
            this.r_MainForm.ProfilePicture.Image = Properties.Resources.Generic_profile_photo;
            this.Close();
        }

        private void m_PictureBoxEvents_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaseClassOfAllFeaturesForm eventsForm = FormFeaturesFactory.Create(eFeatureType.EventsForm);
            eventsForm.ShowDialog();
            this.Show();
        }

        private void m_PictureBoxTicTacToe_Click(object sender, EventArgs e)
        {
            BaseClassOfAllFeaturesForm starting = FormFeaturesFactory.Create(eFeatureType.StartingGameForm);
            this.Hide();
            starting.ShowDialog();
            this.Show();
        }

        private void m_PictureBoxGetWhoLikeMeTheMost_Click(object sender, EventArgs e)
        {
            BaseClassOfAllFeaturesForm likesCounterConfigurationForm = FormFeaturesFactory.Create(
                eFeatureType.WhoLikesMeTheMostForm);
            this.Hide();
            likesCounterConfigurationForm.ShowDialog();
            this.Show();
        }

        private void m_PictureBoxLikedPages_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaseClassOfAllFeaturesForm likedPages = FormFeaturesFactory.Create(eFeatureType.LikedPagesForm);
            likedPages.ShowDialog();
            this.Show();
        }

        private void m_PictureBoxPosts_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaseClassOfAllFeaturesForm postsForm = FormFeaturesFactory.Create(eFeatureType.PostsForm);
            postsForm.ShowDialog();
            this.Show();
        }

        private void m_pictureBoxFavoriteTeams_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaseClassOfAllFeaturesForm favoriteTeamsForm = FormFeaturesFactory.Create(eFeatureType.FavoriteTeamsForm);
            favoriteTeamsForm.ShowDialog();
            this.Show();
        }

        private void randomAlbumPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaseClassOfAllFeaturesForm randomAlbum = FormFeaturesFactory.Create(eFeatureType.RandomAlbumDataForm);
            randomAlbum.ShowDialog();
            this.Show();
        }

        private void m_PictureBoxGetWhoLikeMeTheMost_MouseHover(object sender, EventArgs e)
        {
            this.mouseHoverChangeBorder(sender as PictureBox);
        }

        private void m_PictureBoxGetWhoLikeMeTheMost_MouseLeave(object sender, EventArgs e)
        {
            this.mouseLeaveChangeBorder(sender as PictureBox);
        }

        private void m_PictureBoxRandomAlbum_MouseHover(object sender, EventArgs e)
        {
            this.mouseHoverChangeBorder(sender as PictureBox);
        }

        private void m_PictureBoxAlbums_MouseHover(object sender, EventArgs e)
        {
            this.mouseHoverChangeBorder(sender as PictureBox);
        }

        private void m_PictureBoxAlbums_MouseLeave(object sender, EventArgs e)
        {
            this.mouseLeaveChangeBorder(sender as PictureBox);
        }

        private void m_PictureBoxEvents_MouseHover(object sender, EventArgs e)
        {
            this.mouseHoverChangeBorder(sender as PictureBox);
        }

        private void m_PictureBoxEvents_MouseLeave(object sender, EventArgs e)
        {
            this.mouseLeaveChangeBorder(sender as PictureBox);
        }

        private void m_PictureBoxLikedPages_MouseHover(object sender, EventArgs e)
        {
            this.mouseHoverChangeBorder(sender as PictureBox);
        }

        private void m_PictureBoxLikedPages_MouseLeave(object sender, EventArgs e)
        {
            this.mouseLeaveChangeBorder(sender as PictureBox);
        }

        private void m_PictureBoxGroups_MouseHover(object sender, EventArgs e)
        {
            this.mouseHoverChangeBorder(sender as PictureBox);
        }

        private void m_PictureBoxGroups_MouseLeave(object sender, EventArgs e)
        {
            this.mouseLeaveChangeBorder(sender as PictureBox);
        }

        private void m_pictureBoxFavoriteTeams_MouseHover(object sender, EventArgs e)
        {
            this.mouseHoverChangeBorder(sender as PictureBox);
        }

        private void m_PictureBoxTicTacToe_MouseHover(object sender, EventArgs e)
        {
            this.mouseHoverChangeBorder(sender as PictureBox);
        }

        private void m_PictureBoxRandomAlbum_MouseLeave(object sender, EventArgs e)
        {
            this.mouseLeaveChangeBorder(sender as PictureBox);
        }

        private void m_PictureBoxTicTacToe_MouseLeave(object sender, EventArgs e)
        {
            this.mouseLeaveChangeBorder(sender as PictureBox);
        }

        private void m_PictureBoxPosts_MouseHover(object sender, EventArgs e)
        {
            this.mouseHoverChangeBorder(sender as PictureBox);
        }

        private void m_PictureBoxPosts_MouseLeave(object sender, EventArgs e)
        {
            this.mouseLeaveChangeBorder(sender as PictureBox);
        }

        private void m_pictureBoxFavoriteTeams_MouseLeave(object sender, EventArgs e)
        {
            this.mouseLeaveChangeBorder(sender as PictureBox);
        }

        private void mouseHoverChangeBorder(PictureBox i_PictureBox)
        {
            if (i_PictureBox.BorderStyle == BorderStyle.None)
            {
                i_PictureBox.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void mouseLeaveChangeBorder(PictureBox i_PictureBox)
        {
            if (i_PictureBox.BorderStyle == BorderStyle.Fixed3D)
            {
                i_PictureBox.BorderStyle = BorderStyle.None;
            }
        }
    }
}