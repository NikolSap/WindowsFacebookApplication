using System;

namespace BasicFacebookFeatures
{
    public partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.m_CheckBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.m_PictureBoxProfilePhoto = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxProfilePhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogin.BackColor = System.Drawing.Color.Maroon;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("Aharoni", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(723, 249);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(239, 37);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogout.BackColor = System.Drawing.Color.Maroon;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogout.Font = new System.Drawing.Font("Aharoni", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(723, 294);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(239, 37);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // m_CheckBoxRememberMe
            // 
            this.m_CheckBoxRememberMe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_CheckBoxRememberMe.AutoSize = true;
            this.m_CheckBoxRememberMe.BackColor = System.Drawing.Color.Transparent;
            this.m_CheckBoxRememberMe.ForeColor = System.Drawing.Color.Maroon;
            this.m_CheckBoxRememberMe.Location = new System.Drawing.Point(723, 338);
            this.m_CheckBoxRememberMe.Name = "m_CheckBoxRememberMe";
            this.m_CheckBoxRememberMe.Size = new System.Drawing.Size(122, 21);
            this.m_CheckBoxRememberMe.TabIndex = 53;
            this.m_CheckBoxRememberMe.Text = "Remember me";
            this.m_CheckBoxRememberMe.UseVisualStyleBackColor = false;
            this.m_CheckBoxRememberMe.CheckedChanged += new System.EventHandler(this.m_CheckBoxRememberMe_CheckedChanged_1);
            // 
            // m_PictureBoxProfilePhoto
            // 
            this.m_PictureBoxProfilePhoto.AccessibleDescription = "";
            this.m_PictureBoxProfilePhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_PictureBoxProfilePhoto.BackColor = System.Drawing.Color.Transparent;
            this.m_PictureBoxProfilePhoto.Image = global::BasicFacebookFeatures.Properties.Resources._15_153145_to_log_onto_the_ez_net_web_portal_please_use_your_icon;
            this.m_PictureBoxProfilePhoto.Location = new System.Drawing.Point(723, 26);
            this.m_PictureBoxProfilePhoto.Name = "m_PictureBoxProfilePhoto";
            this.m_PictureBoxProfilePhoto.Size = new System.Drawing.Size(239, 186);
            this.m_PictureBoxProfilePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.m_PictureBoxProfilePhoto.TabIndex = 54;
            this.m_PictureBoxProfilePhoto.TabStop = false;
            this.m_PictureBoxProfilePhoto.Tag = "";
            this.m_PictureBoxProfilePhoto.Click += new System.EventHandler(this.m_PictureBoxProfilePhoto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BasicFacebookFeatures.Properties.Resources.oie_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(797, 393);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::BasicFacebookFeatures.Properties.Resources.NicePng_facebook_logo_png_4820;
            this.pictureBox2.Location = new System.Drawing.Point(595, 393);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 138);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 76;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.oie_KD8YrOCn3np31;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1101, 522);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.m_PictureBoxProfilePhoto);
            this.Controls.Add(this.m_CheckBoxRememberMe);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxProfilePhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
        private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.CheckBox m_CheckBoxRememberMe;
        private System.Windows.Forms.PictureBox m_PictureBoxProfilePhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}