
using System.Windows.Forms;

namespace LikesCounter
{
    partial class LikesCounterConfigurationForm
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
            this.m_CheckBoxPosts = new System.Windows.Forms.CheckBox();
            this.m_CheckBoxPhotos = new System.Windows.Forms.CheckBox();
            this.m_CheckBoxAlbums = new System.Windows.Forms.CheckBox();
            this.m_DateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.m_DateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.m_ListSize = new System.Windows.Forms.NumericUpDown();
            this.m_PictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.m_labelStartDate = new System.Windows.Forms.Label();
            this.m_ButtonFormHeadLine = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.m_ButtonFindOutTags = new System.Windows.Forms.Button();
            this.m_ButtonBackToTheLastForm = new System.Windows.Forms.Button();
            this.m_LabelWorkingOnIt = new System.Windows.Forms.Label();
            this.m_DateRadioButton1 = new System.Windows.Forms.RadioButton();
            this.m_NumberOfLikesRadioButton2 = new System.Windows.Forms.RadioButton();
            this.m_NumberOfTagesRadioButton3 = new System.Windows.Forms.RadioButton();
            this.m_ChooseLabel = new System.Windows.Forms.Label();
            this.m_ByDatePanel1 = new System.Windows.Forms.Panel();
            this.m_FindOutButtonDate = new System.Windows.Forms.Button();
            this.m_ByNumberOfLikesPanel2 = new System.Windows.Forms.Panel();
            this.m_ButtonFindOutLikes = new System.Windows.Forms.Button();
            this.m_NumberOfLikesButton = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.m_PostCheckBoxLikes = new System.Windows.Forms.CheckBox();
            this.m_PhotosCheckBoxLikes = new System.Windows.Forms.CheckBox();
            this.m_AlbumsCheckBoxLikes = new System.Windows.Forms.CheckBox();
            this.m_NumberOfFriendsLikes = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.m_ByNumberOfTagesPanel3 = new System.Windows.Forms.Panel();
            this.m_AlbumsCheckBoxComments = new System.Windows.Forms.CheckBox();
            this.m_NumberOfCommentsButtom = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.m_PostsCheckBoxComments = new System.Windows.Forms.CheckBox();
            this.m_PhotosCheckBoxComments = new System.Windows.Forms.CheckBox();
            this.m_NumberOfFriendsTags = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.m_StartPanel = new System.Windows.Forms.Panel();
            this.m_NextButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_ListSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.m_ByDatePanel1.SuspendLayout();
            this.m_ByNumberOfLikesPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_NumberOfLikesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_NumberOfFriendsLikes)).BeginInit();
            this.m_ByNumberOfTagesPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_NumberOfCommentsButtom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_NumberOfFriendsTags)).BeginInit();
            this.m_StartPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_CheckBoxPosts
            // 
            this.m_CheckBoxPosts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_CheckBoxPosts.AutoSize = true;
            this.m_CheckBoxPosts.BackColor = System.Drawing.Color.Transparent;
            this.m_CheckBoxPosts.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_CheckBoxPosts.ForeColor = System.Drawing.Color.Maroon;
            this.m_CheckBoxPosts.Location = new System.Drawing.Point(288, 184);
            this.m_CheckBoxPosts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_CheckBoxPosts.Name = "m_CheckBoxPosts";
            this.m_CheckBoxPosts.Size = new System.Drawing.Size(73, 20);
            this.m_CheckBoxPosts.TabIndex = 54;
            this.m_CheckBoxPosts.Text = "Posts";
            this.m_CheckBoxPosts.UseVisualStyleBackColor = false;
            // 
            // m_CheckBoxPhotos
            // 
            this.m_CheckBoxPhotos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_CheckBoxPhotos.AutoSize = true;
            this.m_CheckBoxPhotos.BackColor = System.Drawing.Color.Transparent;
            this.m_CheckBoxPhotos.Checked = true;
            this.m_CheckBoxPhotos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_CheckBoxPhotos.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_CheckBoxPhotos.ForeColor = System.Drawing.Color.Maroon;
            this.m_CheckBoxPhotos.Location = new System.Drawing.Point(290, 212);
            this.m_CheckBoxPhotos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_CheckBoxPhotos.Name = "m_CheckBoxPhotos";
            this.m_CheckBoxPhotos.Size = new System.Drawing.Size(86, 20);
            this.m_CheckBoxPhotos.TabIndex = 55;
            this.m_CheckBoxPhotos.Text = "Photos";
            this.m_CheckBoxPhotos.UseVisualStyleBackColor = false;
            // 
            // m_CheckBoxAlbums
            // 
            this.m_CheckBoxAlbums.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_CheckBoxAlbums.AutoSize = true;
            this.m_CheckBoxAlbums.BackColor = System.Drawing.Color.Transparent;
            this.m_CheckBoxAlbums.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_CheckBoxAlbums.ForeColor = System.Drawing.Color.Maroon;
            this.m_CheckBoxAlbums.Location = new System.Drawing.Point(288, 240);
            this.m_CheckBoxAlbums.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_CheckBoxAlbums.Name = "m_CheckBoxAlbums";
            this.m_CheckBoxAlbums.Size = new System.Drawing.Size(91, 20);
            this.m_CheckBoxAlbums.TabIndex = 56;
            this.m_CheckBoxAlbums.Text = "Albums";
            this.m_CheckBoxAlbums.UseVisualStyleBackColor = false;
            // 
            // m_DateTimePickerEndTime
            // 
            this.m_DateTimePickerEndTime.CalendarTitleBackColor = System.Drawing.Color.Navy;
            this.m_DateTimePickerEndTime.CalendarTrailingForeColor = System.Drawing.Color.Maroon;
            this.m_DateTimePickerEndTime.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_DateTimePickerEndTime.Location = new System.Drawing.Point(225, 72);
            this.m_DateTimePickerEndTime.Margin = new System.Windows.Forms.Padding(4);
            this.m_DateTimePickerEndTime.MaxDate = new System.DateTime(2021, 11, 9, 0, 0, 0, 0);
            this.m_DateTimePickerEndTime.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.m_DateTimePickerEndTime.Name = "m_DateTimePickerEndTime";
            this.m_DateTimePickerEndTime.Size = new System.Drawing.Size(265, 30);
            this.m_DateTimePickerEndTime.TabIndex = 57;
            this.m_DateTimePickerEndTime.Value = new System.DateTime(2021, 11, 9, 0, 0, 0, 0);
            // 
            // m_DateTimePickerStartTime
            // 
            this.m_DateTimePickerStartTime.CalendarMonthBackground = System.Drawing.Color.Transparent;
            this.m_DateTimePickerStartTime.CalendarTitleBackColor = System.Drawing.Color.Navy;
            this.m_DateTimePickerStartTime.CalendarTrailingForeColor = System.Drawing.Color.Maroon;
            this.m_DateTimePickerStartTime.Font = new System.Drawing.Font("Bernard MT Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_DateTimePickerStartTime.Location = new System.Drawing.Point(223, 26);
            this.m_DateTimePickerStartTime.Margin = new System.Windows.Forms.Padding(4);
            this.m_DateTimePickerStartTime.MaxDate = new System.DateTime(2021, 11, 9, 0, 0, 0, 0);
            this.m_DateTimePickerStartTime.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.m_DateTimePickerStartTime.Name = "m_DateTimePickerStartTime";
            this.m_DateTimePickerStartTime.Size = new System.Drawing.Size(265, 30);
            this.m_DateTimePickerStartTime.TabIndex = 58;
            this.m_DateTimePickerStartTime.Value = new System.DateTime(2021, 11, 9, 0, 0, 0, 0);
            // 
            // m_ListSize
            // 
            this.m_ListSize.BackColor = System.Drawing.Color.White;
            this.m_ListSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_ListSize.Location = new System.Drawing.Point(441, 117);
            this.m_ListSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_ListSize.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.m_ListSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m_ListSize.Name = "m_ListSize";
            this.m_ListSize.Size = new System.Drawing.Size(51, 24);
            this.m_ListSize.TabIndex = 59;
            this.m_ListSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // m_PictureBoxProfile
            // 
            this.m_PictureBoxProfile.BackColor = System.Drawing.Color.Transparent;
            this.m_PictureBoxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.m_PictureBoxProfile.Location = new System.Drawing.Point(29, 36);
            this.m_PictureBoxProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_PictureBoxProfile.Name = "m_PictureBoxProfile";
            this.m_PictureBoxProfile.Size = new System.Drawing.Size(172, 146);
            this.m_PictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_PictureBoxProfile.TabIndex = 81;
            this.m_PictureBoxProfile.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Silver;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(20, 27);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(192, 164);
            this.pictureBox5.TabIndex = 82;
            this.pictureBox5.TabStop = false;
            // 
            // m_labelStartDate
            // 
            this.m_labelStartDate.BackColor = System.Drawing.Color.Transparent;
            this.m_labelStartDate.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_labelStartDate.ForeColor = System.Drawing.Color.Maroon;
            this.m_labelStartDate.Location = new System.Drawing.Point(15, 26);
            this.m_labelStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_labelStartDate.Name = "m_labelStartDate";
            this.m_labelStartDate.Size = new System.Drawing.Size(168, 37);
            this.m_labelStartDate.TabIndex = 83;
            this.m_labelStartDate.Text = "From when:";
            this.m_labelStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_ButtonFormHeadLine
            // 
            this.m_ButtonFormHeadLine.BackColor = System.Drawing.Color.Transparent;
            this.m_ButtonFormHeadLine.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.oie_vd3kHFJo7qIZ;
            this.m_ButtonFormHeadLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.m_ButtonFormHeadLine.CausesValidation = false;
            this.m_ButtonFormHeadLine.Enabled = false;
            this.m_ButtonFormHeadLine.FlatAppearance.BorderSize = 0;
            this.m_ButtonFormHeadLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.m_ButtonFormHeadLine.Font = new System.Drawing.Font("Aharoni", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_ButtonFormHeadLine.ForeColor = System.Drawing.Color.Transparent;
            this.m_ButtonFormHeadLine.Location = new System.Drawing.Point(459, 36);
            this.m_ButtonFormHeadLine.Margin = new System.Windows.Forms.Padding(4);
            this.m_ButtonFormHeadLine.Name = "m_ButtonFormHeadLine";
            this.m_ButtonFormHeadLine.Size = new System.Drawing.Size(605, 126);
            this.m_ButtonFormHeadLine.TabIndex = 89;
            this.m_ButtonFormHeadLine.Text = "Find Out Who Gave You The Most Of The Likes ";
            this.m_ButtonFormHeadLine.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 37);
            this.label2.TabIndex = 91;
            this.label2.Text = "To:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(15, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 37);
            this.label1.TabIndex = 92;
            this.label1.Text = "Amount Of Friends:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(15, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 37);
            this.label3.TabIndex = 93;
            this.label3.Text = "Includes:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BasicFacebookFeatures.Properties.Resources.oie_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(925, 558);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::BasicFacebookFeatures.Properties.Resources.NicePng_facebook_logo_png_4820;
            this.pictureBox3.Location = new System.Drawing.Point(875, 558);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 95;
            this.pictureBox3.TabStop = false;
            // 
            // m_ButtonFindOutTags
            // 
            this.m_ButtonFindOutTags.BackColor = System.Drawing.Color.Maroon;
            this.m_ButtonFindOutTags.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.m_ButtonFindOutTags.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.m_ButtonFindOutTags.Font = new System.Drawing.Font("Aharoni", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_ButtonFindOutTags.ForeColor = System.Drawing.Color.Transparent;
            this.m_ButtonFindOutTags.Location = new System.Drawing.Point(37, 213);
            this.m_ButtonFindOutTags.Margin = new System.Windows.Forms.Padding(4);
            this.m_ButtonFindOutTags.Name = "m_ButtonFindOutTags";
            this.m_ButtonFindOutTags.Size = new System.Drawing.Size(217, 48);
            this.m_ButtonFindOutTags.TabIndex = 96;
            this.m_ButtonFindOutTags.Text = "Click To Find Out";
            this.m_ButtonFindOutTags.UseVisualStyleBackColor = false;
            this.m_ButtonFindOutTags.Click += new System.EventHandler(this.m_ButtonFindOutComments_Click);
            // 
            // m_ButtonBackToTheLastForm
            // 
            this.m_ButtonBackToTheLastForm.BackColor = System.Drawing.Color.Transparent;
            this.m_ButtonBackToTheLastForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.m_ButtonBackToTheLastForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.m_ButtonBackToTheLastForm.Font = new System.Drawing.Font("Aharoni", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_ButtonBackToTheLastForm.ForeColor = System.Drawing.Color.Transparent;
            this.m_ButtonBackToTheLastForm.Location = new System.Drawing.Point(29, 558);
            this.m_ButtonBackToTheLastForm.Margin = new System.Windows.Forms.Padding(4);
            this.m_ButtonBackToTheLastForm.Name = "m_ButtonBackToTheLastForm";
            this.m_ButtonBackToTheLastForm.Size = new System.Drawing.Size(139, 52);
            this.m_ButtonBackToTheLastForm.TabIndex = 97;
            this.m_ButtonBackToTheLastForm.Text = "<- Go Back";
            this.m_ButtonBackToTheLastForm.UseVisualStyleBackColor = false;
            this.m_ButtonBackToTheLastForm.Click += new System.EventHandler(this.m_BackToTheLastForm_Click);
            // 
            // m_LabelWorkingOnIt
            // 
            this.m_LabelWorkingOnIt.AutoSize = true;
            this.m_LabelWorkingOnIt.BackColor = System.Drawing.Color.Transparent;
            this.m_LabelWorkingOnIt.ForeColor = System.Drawing.Color.Maroon;
            this.m_LabelWorkingOnIt.Location = new System.Drawing.Point(532, 534);
            this.m_LabelWorkingOnIt.Name = "m_LabelWorkingOnIt";
            this.m_LabelWorkingOnIt.Size = new System.Drawing.Size(0, 17);
            this.m_LabelWorkingOnIt.TabIndex = 98;
            // 
            // m_DateRadioButton1
            // 
            this.m_DateRadioButton1.AutoSize = true;
            this.m_DateRadioButton1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_DateRadioButton1.ForeColor = System.Drawing.Color.Maroon;
            this.m_DateRadioButton1.Location = new System.Drawing.Point(104, 64);
            this.m_DateRadioButton1.Name = "m_DateRadioButton1";
            this.m_DateRadioButton1.Size = new System.Drawing.Size(88, 30);
            this.m_DateRadioButton1.TabIndex = 99;
            this.m_DateRadioButton1.TabStop = true;
            this.m_DateRadioButton1.Tag = "1";
            this.m_DateRadioButton1.Text = "Date";
            this.m_DateRadioButton1.UseVisualStyleBackColor = true;
            // 
            // m_NumberOfLikesRadioButton2
            // 
            this.m_NumberOfLikesRadioButton2.AutoSize = true;
            this.m_NumberOfLikesRadioButton2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_NumberOfLikesRadioButton2.ForeColor = System.Drawing.Color.Maroon;
            this.m_NumberOfLikesRadioButton2.Location = new System.Drawing.Point(104, 120);
            this.m_NumberOfLikesRadioButton2.Name = "m_NumberOfLikesRadioButton2";
            this.m_NumberOfLikesRadioButton2.Size = new System.Drawing.Size(218, 30);
            this.m_NumberOfLikesRadioButton2.TabIndex = 100;
            this.m_NumberOfLikesRadioButton2.TabStop = true;
            this.m_NumberOfLikesRadioButton2.Tag = "2";
            this.m_NumberOfLikesRadioButton2.Text = "Number of likes";
            this.m_NumberOfLikesRadioButton2.UseVisualStyleBackColor = true;
            // 
            // m_NumberOfTagesRadioButton3
            // 
            this.m_NumberOfTagesRadioButton3.AutoSize = true;
            this.m_NumberOfTagesRadioButton3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_NumberOfTagesRadioButton3.ForeColor = System.Drawing.Color.Maroon;
            this.m_NumberOfTagesRadioButton3.Location = new System.Drawing.Point(104, 176);
            this.m_NumberOfTagesRadioButton3.Name = "m_NumberOfTagesRadioButton3";
            this.m_NumberOfTagesRadioButton3.Size = new System.Drawing.Size(275, 30);
            this.m_NumberOfTagesRadioButton3.TabIndex = 101;
            this.m_NumberOfTagesRadioButton3.TabStop = true;
            this.m_NumberOfTagesRadioButton3.Tag = "3";
            this.m_NumberOfTagesRadioButton3.Text = "number of comments";
            this.m_NumberOfTagesRadioButton3.UseVisualStyleBackColor = true;
            // 
            // m_ChooseLabel
            // 
            this.m_ChooseLabel.AutoSize = true;
            this.m_ChooseLabel.Location = new System.Drawing.Point(262, 179);
            this.m_ChooseLabel.Name = "m_ChooseLabel";
            this.m_ChooseLabel.Size = new System.Drawing.Size(0, 17);
            this.m_ChooseLabel.TabIndex = 102;
            // 
            // m_ByDatePanel1
            // 
            this.m_ByDatePanel1.Controls.Add(this.m_FindOutButtonDate);
            this.m_ByDatePanel1.Controls.Add(this.label1);
            this.m_ByDatePanel1.Controls.Add(this.m_CheckBoxPosts);
            this.m_ByDatePanel1.Controls.Add(this.m_CheckBoxPhotos);
            this.m_ByDatePanel1.Controls.Add(this.m_CheckBoxAlbums);
            this.m_ByDatePanel1.Controls.Add(this.m_DateTimePickerEndTime);
            this.m_ByDatePanel1.Controls.Add(this.m_DateTimePickerStartTime);
            this.m_ByDatePanel1.Controls.Add(this.m_ListSize);
            this.m_ByDatePanel1.Controls.Add(this.m_labelStartDate);
            this.m_ByDatePanel1.Controls.Add(this.label2);
            this.m_ByDatePanel1.Controls.Add(this.label3);
            this.m_ByDatePanel1.Location = new System.Drawing.Point(420, 145);
            this.m_ByDatePanel1.Name = "m_ByDatePanel1";
            this.m_ByDatePanel1.Size = new System.Drawing.Size(546, 287);
            this.m_ByDatePanel1.TabIndex = 103;
            this.m_ByDatePanel1.Visible = false;
            // 
            // m_FindOutButtonDate
            // 
            this.m_FindOutButtonDate.BackColor = System.Drawing.Color.Maroon;
            this.m_FindOutButtonDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.m_FindOutButtonDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.m_FindOutButtonDate.Font = new System.Drawing.Font("Aharoni", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_FindOutButtonDate.ForeColor = System.Drawing.Color.Transparent;
            this.m_FindOutButtonDate.Location = new System.Drawing.Point(36, 224);
            this.m_FindOutButtonDate.Margin = new System.Windows.Forms.Padding(4);
            this.m_FindOutButtonDate.Name = "m_FindOutButtonDate";
            this.m_FindOutButtonDate.Size = new System.Drawing.Size(217, 48);
            this.m_FindOutButtonDate.TabIndex = 97;
            this.m_FindOutButtonDate.Text = "Click To Find Out";
            this.m_FindOutButtonDate.UseVisualStyleBackColor = false;
            this.m_FindOutButtonDate.Click += new System.EventHandler(this.m_FindOutDates_Click);
            // 
            // m_ByNumberOfLikesPanel2
            // 
            this.m_ByNumberOfLikesPanel2.Controls.Add(this.m_ButtonFindOutLikes);
            this.m_ByNumberOfLikesPanel2.Controls.Add(this.m_NumberOfLikesButton);
            this.m_ByNumberOfLikesPanel2.Controls.Add(this.label4);
            this.m_ByNumberOfLikesPanel2.Controls.Add(this.m_PostCheckBoxLikes);
            this.m_ByNumberOfLikesPanel2.Controls.Add(this.m_PhotosCheckBoxLikes);
            this.m_ByNumberOfLikesPanel2.Controls.Add(this.m_AlbumsCheckBoxLikes);
            this.m_ByNumberOfLikesPanel2.Controls.Add(this.m_NumberOfFriendsLikes);
            this.m_ByNumberOfLikesPanel2.Controls.Add(this.label5);
            this.m_ByNumberOfLikesPanel2.Controls.Add(this.label7);
            this.m_ByNumberOfLikesPanel2.Location = new System.Drawing.Point(420, 142);
            this.m_ByNumberOfLikesPanel2.Name = "m_ByNumberOfLikesPanel2";
            this.m_ByNumberOfLikesPanel2.Size = new System.Drawing.Size(546, 287);
            this.m_ByNumberOfLikesPanel2.TabIndex = 104;
            this.m_ByNumberOfLikesPanel2.Visible = false;
            // 
            // m_ButtonFindOutLikes
            // 
            this.m_ButtonFindOutLikes.BackColor = System.Drawing.Color.Maroon;
            this.m_ButtonFindOutLikes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.m_ButtonFindOutLikes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.m_ButtonFindOutLikes.Font = new System.Drawing.Font("Aharoni", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_ButtonFindOutLikes.ForeColor = System.Drawing.Color.Transparent;
            this.m_ButtonFindOutLikes.Location = new System.Drawing.Point(39, 205);
            this.m_ButtonFindOutLikes.Margin = new System.Windows.Forms.Padding(4);
            this.m_ButtonFindOutLikes.Name = "m_ButtonFindOutLikes";
            this.m_ButtonFindOutLikes.Size = new System.Drawing.Size(217, 48);
            this.m_ButtonFindOutLikes.TabIndex = 97;
            this.m_ButtonFindOutLikes.Text = "Click To Find Out";
            this.m_ButtonFindOutLikes.UseVisualStyleBackColor = false;
            this.m_ButtonFindOutLikes.Click += new System.EventHandler(this.m_ButtonFindOutLikes_Click);
            // 
            // m_NumberOfLikesButton
            // 
            this.m_NumberOfLikesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_NumberOfLikesButton.Location = new System.Drawing.Point(306, 40);
            this.m_NumberOfLikesButton.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m_NumberOfLikesButton.Name = "m_NumberOfLikesButton";
            this.m_NumberOfLikesButton.Size = new System.Drawing.Size(55, 22);
            this.m_NumberOfLikesButton.TabIndex = 94;
            this.m_NumberOfLikesButton.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(4, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 37);
            this.label4.TabIndex = 92;
            this.label4.Text = "Amount Of Friends:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_PostCheckBoxLikes
            // 
            this.m_PostCheckBoxLikes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_PostCheckBoxLikes.AutoSize = true;
            this.m_PostCheckBoxLikes.BackColor = System.Drawing.Color.Transparent;
            this.m_PostCheckBoxLikes.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_PostCheckBoxLikes.ForeColor = System.Drawing.Color.Maroon;
            this.m_PostCheckBoxLikes.Location = new System.Drawing.Point(288, 184);
            this.m_PostCheckBoxLikes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_PostCheckBoxLikes.Name = "m_PostCheckBoxLikes";
            this.m_PostCheckBoxLikes.Size = new System.Drawing.Size(73, 20);
            this.m_PostCheckBoxLikes.TabIndex = 54;
            this.m_PostCheckBoxLikes.Text = "Posts";
            this.m_PostCheckBoxLikes.UseVisualStyleBackColor = false;
            // 
            // m_PhotosCheckBoxLikes
            // 
            this.m_PhotosCheckBoxLikes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_PhotosCheckBoxLikes.AutoSize = true;
            this.m_PhotosCheckBoxLikes.BackColor = System.Drawing.Color.Transparent;
            this.m_PhotosCheckBoxLikes.Checked = true;
            this.m_PhotosCheckBoxLikes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_PhotosCheckBoxLikes.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_PhotosCheckBoxLikes.ForeColor = System.Drawing.Color.Maroon;
            this.m_PhotosCheckBoxLikes.Location = new System.Drawing.Point(290, 212);
            this.m_PhotosCheckBoxLikes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_PhotosCheckBoxLikes.Name = "m_PhotosCheckBoxLikes";
            this.m_PhotosCheckBoxLikes.Size = new System.Drawing.Size(86, 20);
            this.m_PhotosCheckBoxLikes.TabIndex = 55;
            this.m_PhotosCheckBoxLikes.Text = "Photos";
            this.m_PhotosCheckBoxLikes.UseVisualStyleBackColor = false;
            // 
            // m_AlbumsCheckBoxLikes
            // 
            this.m_AlbumsCheckBoxLikes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_AlbumsCheckBoxLikes.AutoSize = true;
            this.m_AlbumsCheckBoxLikes.BackColor = System.Drawing.Color.Transparent;
            this.m_AlbumsCheckBoxLikes.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_AlbumsCheckBoxLikes.ForeColor = System.Drawing.Color.Maroon;
            this.m_AlbumsCheckBoxLikes.Location = new System.Drawing.Point(288, 240);
            this.m_AlbumsCheckBoxLikes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_AlbumsCheckBoxLikes.Name = "m_AlbumsCheckBoxLikes";
            this.m_AlbumsCheckBoxLikes.Size = new System.Drawing.Size(91, 20);
            this.m_AlbumsCheckBoxLikes.TabIndex = 56;
            this.m_AlbumsCheckBoxLikes.Text = "Albums";
            this.m_AlbumsCheckBoxLikes.UseVisualStyleBackColor = false;
            // 
            // m_NumberOfFriendsLikes
            // 
            this.m_NumberOfFriendsLikes.BackColor = System.Drawing.Color.White;
            this.m_NumberOfFriendsLikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_NumberOfFriendsLikes.Location = new System.Drawing.Point(306, 92);
            this.m_NumberOfFriendsLikes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_NumberOfFriendsLikes.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.m_NumberOfFriendsLikes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m_NumberOfFriendsLikes.Name = "m_NumberOfFriendsLikes";
            this.m_NumberOfFriendsLikes.Size = new System.Drawing.Size(55, 24);
            this.m_NumberOfFriendsLikes.TabIndex = 59;
            this.m_NumberOfFriendsLikes.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(7, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 37);
            this.label5.TabIndex = 83;
            this.label5.Text = "NUMBER OF LIKES:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(12, 142);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 37);
            this.label7.TabIndex = 93;
            this.label7.Text = "Includes:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_ByNumberOfTagesPanel3
            // 
            this.m_ByNumberOfTagesPanel3.Controls.Add(this.m_AlbumsCheckBoxComments);
            this.m_ByNumberOfTagesPanel3.Controls.Add(this.m_NumberOfCommentsButtom);
            this.m_ByNumberOfTagesPanel3.Controls.Add(this.label6);
            this.m_ByNumberOfTagesPanel3.Controls.Add(this.m_PostsCheckBoxComments);
            this.m_ByNumberOfTagesPanel3.Controls.Add(this.m_PhotosCheckBoxComments);
            this.m_ByNumberOfTagesPanel3.Controls.Add(this.m_NumberOfFriendsTags);
            this.m_ByNumberOfTagesPanel3.Controls.Add(this.label8);
            this.m_ByNumberOfTagesPanel3.Controls.Add(this.label9);
            this.m_ByNumberOfTagesPanel3.Controls.Add(this.m_ButtonFindOutTags);
            this.m_ByNumberOfTagesPanel3.Location = new System.Drawing.Point(420, 145);
            this.m_ByNumberOfTagesPanel3.Name = "m_ByNumberOfTagesPanel3";
            this.m_ByNumberOfTagesPanel3.Size = new System.Drawing.Size(546, 287);
            this.m_ByNumberOfTagesPanel3.TabIndex = 105;
            this.m_ByNumberOfTagesPanel3.Visible = false;
            // 
            // m_AlbumsCheckBoxComments
            // 
            this.m_AlbumsCheckBoxComments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_AlbumsCheckBoxComments.AutoSize = true;
            this.m_AlbumsCheckBoxComments.BackColor = System.Drawing.Color.Transparent;
            this.m_AlbumsCheckBoxComments.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_AlbumsCheckBoxComments.ForeColor = System.Drawing.Color.Maroon;
            this.m_AlbumsCheckBoxComments.Location = new System.Drawing.Point(288, 240);
            this.m_AlbumsCheckBoxComments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_AlbumsCheckBoxComments.Name = "m_AlbumsCheckBoxComments";
            this.m_AlbumsCheckBoxComments.Size = new System.Drawing.Size(91, 20);
            this.m_AlbumsCheckBoxComments.TabIndex = 106;
            this.m_AlbumsCheckBoxComments.Text = "Albums";
            this.m_AlbumsCheckBoxComments.UseVisualStyleBackColor = false;
            // 
            // m_NumberOfCommentsButtom
            // 
            this.m_NumberOfCommentsButtom.Location = new System.Drawing.Point(306, 25);
            this.m_NumberOfCommentsButtom.Name = "m_NumberOfCommentsButtom";
            this.m_NumberOfCommentsButtom.Size = new System.Drawing.Size(57, 22);
            this.m_NumberOfCommentsButtom.TabIndex = 105;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(12, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 37);
            this.label6.TabIndex = 92;
            this.label6.Text = "Amount Of Friends:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_PostsCheckBoxComments
            // 
            this.m_PostsCheckBoxComments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_PostsCheckBoxComments.AutoSize = true;
            this.m_PostsCheckBoxComments.BackColor = System.Drawing.Color.Transparent;
            this.m_PostsCheckBoxComments.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_PostsCheckBoxComments.ForeColor = System.Drawing.Color.Maroon;
            this.m_PostsCheckBoxComments.Location = new System.Drawing.Point(290, 184);
            this.m_PostsCheckBoxComments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_PostsCheckBoxComments.Name = "m_PostsCheckBoxComments";
            this.m_PostsCheckBoxComments.Size = new System.Drawing.Size(73, 20);
            this.m_PostsCheckBoxComments.TabIndex = 54;
            this.m_PostsCheckBoxComments.Text = "Posts";
            this.m_PostsCheckBoxComments.UseVisualStyleBackColor = false;
            // 
            // m_PhotosCheckBoxComments
            // 
            this.m_PhotosCheckBoxComments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.m_PhotosCheckBoxComments.AutoSize = true;
            this.m_PhotosCheckBoxComments.BackColor = System.Drawing.Color.Transparent;
            this.m_PhotosCheckBoxComments.Checked = true;
            this.m_PhotosCheckBoxComments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.m_PhotosCheckBoxComments.Font = new System.Drawing.Font("Aharoni", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_PhotosCheckBoxComments.ForeColor = System.Drawing.Color.Maroon;
            this.m_PhotosCheckBoxComments.Location = new System.Drawing.Point(290, 212);
            this.m_PhotosCheckBoxComments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_PhotosCheckBoxComments.Name = "m_PhotosCheckBoxComments";
            this.m_PhotosCheckBoxComments.Size = new System.Drawing.Size(86, 20);
            this.m_PhotosCheckBoxComments.TabIndex = 55;
            this.m_PhotosCheckBoxComments.Text = "Photos";
            this.m_PhotosCheckBoxComments.UseVisualStyleBackColor = false;
            // 
            // m_NumberOfFriendsTags
            // 
            this.m_NumberOfFriendsTags.BackColor = System.Drawing.Color.White;
            this.m_NumberOfFriendsTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_NumberOfFriendsTags.Location = new System.Drawing.Point(306, 92);
            this.m_NumberOfFriendsTags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_NumberOfFriendsTags.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.m_NumberOfFriendsTags.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m_NumberOfFriendsTags.Name = "m_NumberOfFriendsTags";
            this.m_NumberOfFriendsTags.Size = new System.Drawing.Size(55, 24);
            this.m_NumberOfFriendsTags.TabIndex = 59;
            this.m_NumberOfFriendsTags.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(-5, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(306, 37);
            this.label8.TabIndex = 83;
            this.label8.Text = "NUMBER OF comments";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(12, 143);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 37);
            this.label9.TabIndex = 93;
            this.label9.Text = "Includes:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_StartPanel
            // 
            this.m_StartPanel.Controls.Add(this.m_NextButton);
            this.m_StartPanel.Controls.Add(this.label10);
            this.m_StartPanel.Controls.Add(this.m_DateRadioButton1);
            this.m_StartPanel.Controls.Add(this.m_NumberOfLikesRadioButton2);
            this.m_StartPanel.Controls.Add(this.m_NumberOfTagesRadioButton3);
            this.m_StartPanel.Location = new System.Drawing.Point(420, 136);
            this.m_StartPanel.Name = "m_StartPanel";
            this.m_StartPanel.Size = new System.Drawing.Size(543, 293);
            this.m_StartPanel.TabIndex = 106;
            // 
            // m_NextButton
            // 
            this.m_NextButton.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_NextButton.ForeColor = System.Drawing.Color.Maroon;
            this.m_NextButton.Location = new System.Drawing.Point(384, 227);
            this.m_NextButton.Name = "m_NextButton";
            this.m_NextButton.Size = new System.Drawing.Size(103, 47);
            this.m_NextButton.TabIndex = 103;
            this.m_NextButton.Text = "NEXT";
            this.m_NextButton.UseVisualStyleBackColor = true;
            this.m_NextButton.Click += new System.EventHandler(this.m_NextButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(16, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 30);
            this.label10.TabIndex = 102;
            this.label10.Text = "FIND BY:";
            // 
            // LikesCounterConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.oie_KD8YrOCn3np3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 619);
            this.Controls.Add(this.m_StartPanel);
            this.Controls.Add(this.m_ByNumberOfLikesPanel2);
            this.Controls.Add(this.m_ByNumberOfTagesPanel3);
            this.Controls.Add(this.m_ByDatePanel1);
            this.Controls.Add(this.m_ChooseLabel);
            this.Controls.Add(this.m_LabelWorkingOnIt);
            this.Controls.Add(this.m_ButtonBackToTheLastForm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.m_ButtonFormHeadLine);
            this.Controls.Add(this.m_PictureBoxProfile);
            this.Controls.Add(this.pictureBox5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LikesCounterConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Who Like Me The Most";
            ((System.ComponentModel.ISupportInitialize)(this.m_ListSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.m_ByDatePanel1.ResumeLayout(false);
            this.m_ByDatePanel1.PerformLayout();
            this.m_ByNumberOfLikesPanel2.ResumeLayout(false);
            this.m_ByNumberOfLikesPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_NumberOfLikesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_NumberOfFriendsLikes)).EndInit();
            this.m_ByNumberOfTagesPanel3.ResumeLayout(false);
            this.m_ByNumberOfTagesPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_NumberOfCommentsButtom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_NumberOfFriendsTags)).EndInit();
            this.m_StartPanel.ResumeLayout(false);
            this.m_StartPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox m_CheckBoxPosts;
        private System.Windows.Forms.CheckBox m_CheckBoxPhotos;
        private System.Windows.Forms.CheckBox m_CheckBoxAlbums;
        private DateTimePicker m_DateTimePickerEndTime;
        private DateTimePicker m_DateTimePickerStartTime;
        private NumericUpDown m_ListSize;
        private PictureBox m_PictureBoxProfile;
        private PictureBox pictureBox5;
        private Label m_labelStartDate;
        private Button m_ButtonFormHeadLine;
        private Label label2;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button m_ButtonFindOutTags;
        private Button m_ButtonBackToTheLastForm;
        private Label m_LabelWorkingOnIt;
        private RadioButton m_DateRadioButton1;
        private RadioButton m_NumberOfLikesRadioButton2;
        private RadioButton m_NumberOfTagesRadioButton3;
        private Label m_ChooseLabel;
        private Panel m_ByDatePanel1;
        private Panel m_ByNumberOfLikesPanel2;
        private Label label4;
        private CheckBox m_PostCheckBoxLikes;
        private CheckBox m_PhotosCheckBoxLikes;
        private CheckBox m_AlbumsCheckBoxLikes;
        private NumericUpDown m_NumberOfFriendsLikes;
        private Label label5;
        private Label label7;
        private Button m_FindOutButtonDate;
        private Button m_ButtonFindOutLikes;
        private Panel m_ByNumberOfTagesPanel3;
        private NumericUpDown m_NumberOfLikesButton;
        private Label label6;
        private CheckBox m_PostsCheckBoxComments;
        private CheckBox m_PhotosCheckBoxComments;
        private NumericUpDown m_NumberOfFriendsTags;
        private Label label8;
        private Label label9;
        private Panel m_StartPanel;
        private Label label10;
        private NumericUpDown m_NumberOfCommentsButtom;
        private Button m_NextButton;
        private CheckBox m_AlbumsCheckBoxComments;
    }
}