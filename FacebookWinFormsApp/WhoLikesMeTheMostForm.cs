using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BasicFacebookFeatures;
using FacebookCustomAppEngine;

namespace LikesCounter
{
    public partial class LikesCounterConfigurationForm : BaseClassOfAllFeaturesForm
    {
        private readonly WhoLikeMeTheMostEngine r_LikeMostEngine;
        private RadioButtonsMenu m_StrategyMenu;
        private List<Panel> m_PanelsList;
        public LikesCounterConfigurationForm()
        {
            r_LikeMostEngine = new WhoLikeMeTheMostEngine();
            InitializeComponent();
            initializeRadioButtonsMenuAndPanelsList();
            m_PictureBoxProfile.Image = r_LikeMostEngine.getUserProfilePicture();
            m_PictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void initializeRadioButtonsMenuAndPanelsList()
        {
            m_StrategyMenu = new RadioButtonsMenu()
                                 {
                                     new RadioButtonItem { StrategyMethod = new InitializeByStartDateStrategyMethod(),RadioButtonName=m_DateRadioButton1.Text},
                                     new RadioButtonItem { StrategyMethod = new InitializeByNumberOfLikesStrategyMethod(),RadioButtonName=m_NumberOfLikesRadioButton2.Text},
                                     new RadioButtonItem { StrategyMethod = new InitializeByNumberOfCommentsStrategyMethod(),RadioButtonName=m_NumberOfTagesRadioButton3.Text},
                                 };
            m_PanelsList = new List<Panel>() { m_ByDatePanel1, m_ByNumberOfLikesPanel2, m_ByNumberOfTagesPanel3 };

        }

        private void ButtonFindOutClicked()
        {
            m_LabelWorkingOnIt.Text = "Working on it, please wait...";
            try
            {
                Dictionary<string, Dictionary<string, ImageAndString>> result = r_LikeMostEngine.GetTheFriendsWitheTheMostLikes();
                LikesResultsForm likesResultsForm = new LikesResultsForm(result);
                m_LabelWorkingOnIt.Text = string.Empty;
                Hide();
                likesResultsForm.ShowDialog();
                Show();
            }
            catch (Exception exception)
            {
                m_LabelWorkingOnIt.Text = string.Empty;
                MessageBox.Show(exception.Message);
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        private void m_BackToTheLastForm_Click(object sender, EventArgs e)
        {
            if(m_StartPanel.Visible == false)
            {
                foreach(Panel panel in m_PanelsList)
                {
                    panel.Visible = false;
                }

                m_StartPanel.Visible = true;
            }
            else
            {
               Close();
            }
        }

        private void m_NextButton_Click(object sender, EventArgs e)
        { 
            m_StrategyMenu.InitializeChoosePictureStrategy(m_StartPanel,m_PanelsList);
        }

        private void m_ButtonFindOutLikes_Click(object sender, EventArgs e)
        {
            r_LikeMostEngine.UpdateLikesCalculator(
                new InitializeByNumberOfLikesStrategyMethod(),
                (int)m_NumberOfLikesButton.Value,
                m_AlbumsCheckBoxLikes.Checked,
                m_PhotosCheckBoxLikes.Checked,
                m_PostCheckBoxLikes.Checked,
                (int)m_NumberOfFriendsLikes.Value);
            ButtonFindOutClicked();
        }

        private void m_FindOutDates_Click(object sender, EventArgs e)
        {
            r_LikeMostEngine.UpdateLikesCalculator(
                new InitializeByStartDateStrategyMethod(),
                m_DateTimePickerStartTime.Value,
                m_DateTimePickerEndTime.Value,
                m_CheckBoxAlbums.Checked,
                m_CheckBoxPhotos.Checked,
                m_CheckBoxPosts.Checked,
                (int)m_NumberOfFriendsTags.Value);
            ButtonFindOutClicked();
        }

        private void m_ButtonFindOutComments_Click(object sender, EventArgs e)
        {
            r_LikeMostEngine.UpdateLikesCalculator(
                new InitializeByNumberOfCommentsStrategyMethod(),
                (int)m_NumberOfCommentsButtom.Value,
                m_AlbumsCheckBoxComments.Checked,
                m_PhotosCheckBoxComments.Checked,
                m_PostsCheckBoxComments.Checked,
                (int)m_NumberOfFriendsTags.Value);
            ButtonFindOutClicked();
        }
    }
}
