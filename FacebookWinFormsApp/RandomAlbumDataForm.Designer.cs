
namespace BasicFacebookFeatures
{
    partial class RandomAlbumDataForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label linkLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label countLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.countLabel1 = new System.Windows.Forms.Label();
            this.albumBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.createdTimeLabel1 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.imageAlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.linkLinkLabel = new System.Windows.Forms.LinkLabel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.m_AgainButton = new System.Windows.Forms.Button();
            this.m_BackButton = new System.Windows.Forms.Button();
            createdTimeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            linkLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            createdTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            createdTimeLabel.Location = new System.Drawing.Point(129, 401);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(136, 22);
            createdTimeLabel.TabIndex = 1;
            createdTimeLabel.Text = "Created Time:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            descriptionLabel.Location = new System.Drawing.Point(129, 439);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(124, 21);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description:";
            // 
            // linkLabel
            // 
            linkLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            linkLabel.Location = new System.Drawing.Point(129, 478);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new System.Drawing.Size(106, 21);
            linkLabel.TabIndex = 7;
            linkLabel.Text = "Album Link:";
            // 
            // nameLabel
            // 
            nameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            nameLabel.Location = new System.Drawing.Point(129, 358);
            nameLabel.Name = "nameLabel";
            nameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            nameLabel.Size = new System.Drawing.Size(115, 20);
            nameLabel.TabIndex = 9;
            nameLabel.Text = "Album Name:";
            // 
            // countLabel
            // 
            countLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            countLabel.Location = new System.Drawing.Point(129, 520);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(165, 21);
            countLabel.TabIndex = 10;
            countLabel.Text = "Number of images:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(countLabel);
            this.panel1.Controls.Add(this.countLabel1);
            this.panel1.Controls.Add(createdTimeLabel);
            this.panel1.Controls.Add(this.createdTimeLabel1);
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(this.imageAlbumPictureBox);
            this.panel1.Controls.Add(linkLabel);
            this.panel1.Controls.Add(this.linkLinkLabel);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Location = new System.Drawing.Point(147, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(658, 638);
            this.panel1.TabIndex = 0;
            // 
            // countLabel1
            // 
            this.countLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.countLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource2, "Count", true));
            this.countLabel1.Location = new System.Drawing.Point(302, 520);
            this.countLabel1.Name = "countLabel1";
            this.countLabel1.Size = new System.Drawing.Size(209, 29);
            this.countLabel1.TabIndex = 11;
            this.countLabel1.Text = "label1";
            // 
            // albumBindingSource2
            // 
            this.albumBindingSource2.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // createdTimeLabel1
            // 
            this.createdTimeLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.createdTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource2, "CreatedTime", true));
            this.createdTimeLabel1.Location = new System.Drawing.Point(322, 401);
            this.createdTimeLabel1.Name = "createdTimeLabel1";
            this.createdTimeLabel1.Size = new System.Drawing.Size(189, 22);
            this.createdTimeLabel1.TabIndex = 2;
            this.createdTimeLabel1.Text = "label1";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource2, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(260, 439);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(250, 26);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // imageAlbumPictureBox
            // 
            this.imageAlbumPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.imageAlbumPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource2, "ImageAlbum", true));
            this.imageAlbumPictureBox.Location = new System.Drawing.Point(133, 25);
            this.imageAlbumPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imageAlbumPictureBox.Name = "imageAlbumPictureBox";
            this.imageAlbumPictureBox.Size = new System.Drawing.Size(378, 298);
            this.imageAlbumPictureBox.TabIndex = 6;
            this.imageAlbumPictureBox.TabStop = false;
            // 
            // linkLinkLabel
            // 
            this.linkLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.linkLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource2, "Link", true));
            this.linkLinkLabel.Location = new System.Drawing.Point(256, 478);
            this.linkLinkLabel.Name = "linkLinkLabel";
            this.linkLinkLabel.Size = new System.Drawing.Size(280, 22);
            this.linkLinkLabel.TabIndex = 8;
            this.linkLinkLabel.TabStop = true;
            this.linkLinkLabel.Text = "linkLabel1";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource2, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(260, 358);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(250, 26);
            this.nameTextBox.TabIndex = 10;
            // 
            // m_AgainButton
            // 
            this.m_AgainButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.m_AgainButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.m_AgainButton.Font = new System.Drawing.Font("Malgun Gothic Semilight", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_AgainButton.Location = new System.Drawing.Point(304, 679);
            this.m_AgainButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_AgainButton.Name = "m_AgainButton";
            this.m_AgainButton.Size = new System.Drawing.Size(138, 62);
            this.m_AgainButton.TabIndex = 2;
            this.m_AgainButton.Text = "AGAIN";
            this.m_AgainButton.UseVisualStyleBackColor = false;
            this.m_AgainButton.Click += new System.EventHandler(this.m_AgainButton_Click);
            // 
            // m_BackButton
            // 
            this.m_BackButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.m_BackButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.m_BackButton.Font = new System.Drawing.Font("Malgun Gothic Semilight", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_BackButton.Location = new System.Drawing.Point(477, 679);
            this.m_BackButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.m_BackButton.Name = "m_BackButton";
            this.m_BackButton.Size = new System.Drawing.Size(138, 62);
            this.m_BackButton.TabIndex = 3;
            this.m_BackButton.Text = "RETURN BACK";
            this.m_BackButton.UseVisualStyleBackColor = false;
            this.m_BackButton.Click += new System.EventHandler(this.m_BackButton_Click);
            // 
            // RandomAlbumDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(968, 756);
            this.Controls.Add(this.m_BackButton);
            this.Controls.Add(this.m_AgainButton);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RandomAlbumDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RandomAlbumDataForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label createdTimeLabel1;
        private System.Windows.Forms.BindingSource albumBindingSource2;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.PictureBox imageAlbumPictureBox;
        private System.Windows.Forms.LinkLabel linkLinkLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label countLabel1;
        private System.Windows.Forms.Button m_AgainButton;
        private System.Windows.Forms.Button m_BackButton;
    }
}