using System;
using System.IO;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using FacebookCustomAppEngine;

namespace BasicFacebookFeatures
{
    public partial class MainForm : Form
    {
        private static readonly string s_AppSettingsFileName =
            $"{Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName}\\appSettings.xml";
        
        private readonly AppSettings r_AppSettings;

        private LoginResult m_LoginResult;
        private User m_LoggedInUser;

        public MainForm()
        {
            this.InitializeComponent();
            FacebookService.s_CollectionLimit = 100;
            this.r_AppSettings = new AppSettings();
            this.r_AppSettings.LoadAppSettingsData(s_AppSettingsFileName);
            this.m_CheckBoxRememberMe.Checked = this.r_AppSettings.RememberUser;
            this.m_LoginResult = null;
            this.m_LoggedInUser = null;
        }

        public LoginResult LoginResult
        {
            get
            {
                return this.m_LoginResult;
            }

            set
            {
                LoginResult = value;
            }
        }

        public PictureBox ProfilePicture
        {
            get
            {
                return this.m_PictureBoxProfilePhoto;
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.m_PictureBoxProfilePhoto.Image = Properties.Resources.Generic_profile_photo;

            if (this.r_AppSettings.RememberUser && !string.IsNullOrEmpty(this.r_AppSettings.LastAccessToken))
            {
                try
                {
                    this.m_LoginResult = FacebookService.Connect(this.r_AppSettings.LastAccessToken);
                    this.tryToGoFeatureForm();
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Can't connect to facebook. Error: { exception.Message }");
                }
            }
        }

        private void tryToGoFeatureForm()
        {
            if (this.IsThereLoggedInUser(this.m_LoginResult))
            {
                this.m_LoggedInUser = this.m_LoginResult.LoggedInUser;
                this.Hide();
                FacebookAppEngine.Instance.SetUser(m_LoggedInUser);
                FeaturesForm featuresForm = new FeaturesForm(this);
                featuresForm.ShowDialog();
            }

            if (!this.IsThereLoggedInUser(this.m_LoginResult))
            {
                this.m_PictureBoxProfilePhoto.Image = Properties.Resources.Generic_profile_photo;
                this.Show();
            }

            this.Show(); 
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            this.saveAppSettings();
        }

        private void saveAppSettings()
        {
            this.r_AppSettings.RememberUser = this.m_CheckBoxRememberMe.Checked;

            if (this.r_AppSettings.RememberUser && this.m_LoginResult != null)
            {
                this.r_AppSettings.LastAccessToken = this.m_LoginResult.AccessToken;
            }
            else
            {
                this.r_AppSettings.LastAccessToken = null;
            }

            this.r_AppSettings.SaveData(s_AppSettingsFileName);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
           this.loginAndInit();
        }

        private void loginAndInit()
        {
            if (this.m_LoggedInUser != null)
            {
                MessageBox.Show("You need to logout first");
                return;
            }

            Clipboard.SetText("design.patterns20cc");

            try
            {
                this.m_LoginResult = FacebookService.Login(AppSettings.AppId, AppSettings.Permissions);
                this.tryToGoFeatureForm();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Can't connect to facebook. Error: { exception.Message }");
            }
        }

        public void FetchLoggedInUser(LoginResult i_LoginResult)
        {
            if (this.IsThereLoggedInUser(i_LoginResult))
            {
                this.m_LoggedInUser = i_LoginResult.LoggedInUser;
                this.buttonLogin.Text = $"Logged in as {i_LoginResult.LoggedInUser.Name}";
                this.m_PictureBoxProfilePhoto.ImageLocation = this.m_LoggedInUser.PictureNormalURL;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.UserLogout();
        }

        public void UserLogout()
        {
            if (this.m_LoggedInUser == null)
            {
                MessageBox.Show("You are already logged out");
            }
            else
            {
                try
                {
                    FacebookService.LogoutWithUI();
                    this.m_CheckBoxRememberMe.Checked = false;
                    this.r_AppSettings.LastAccessToken = null;
                    this.r_AppSettings.RememberUser = false;
                    this.m_LoggedInUser = null;
                    this.m_LoginResult = null;
                    this.buttonLogin.Text = "Login";
                }
                catch (Exception exception)
                {
                    MessageBox.Show($"Can't connect to facebook. Error: {exception.Message}");
                }
            }
        }

        public bool IsThereLoggedInUser(LoginResult i_LoginResult)
        {
            return i_LoginResult != null && !string.IsNullOrEmpty(i_LoginResult.AccessToken);
        }

        private void m_CheckBoxRememberMe_CheckedChanged_1(object sender, EventArgs e)
        {
            this.RememberMe(sender);
        }

        public void RememberMe(object sender)
        {
            if (sender is CheckBox rememberSender)
            {
                this.r_AppSettings.RememberUser = rememberSender.Checked;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!this.IsThereLoggedInUser(this.m_LoginResult))
            {
                this.m_PictureBoxProfilePhoto.Image = Properties.Resources.Generic_profile_photo;
            }
        }

        private void m_PictureBoxProfilePhoto_Click(object sender, EventArgs e)
        {
        }
    }
}
