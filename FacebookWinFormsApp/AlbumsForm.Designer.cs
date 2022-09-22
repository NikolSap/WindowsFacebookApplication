namespace BasicFacebookFeatures
{
    public partial class AlbumsForm
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.m_ReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_ReturnButton
            // 
            this.m_ReturnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_ReturnButton.Location = new System.Drawing.Point(11, 411);
            this.m_ReturnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_ReturnButton.Name = "m_ReturnButton";
            this.m_ReturnButton.Size = new System.Drawing.Size(105, 29);
            this.m_ReturnButton.TabIndex = 0;
            this.m_ReturnButton.Text = "Return Back";
            this.m_ReturnButton.UseVisualStyleBackColor = true;
            this.m_ReturnButton.Click += new System.EventHandler(this.m_ReturnButton_Click);
            // 
            // AlbumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.m_ReturnButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AlbumsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlbumsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_ReturnButton;
    }
}