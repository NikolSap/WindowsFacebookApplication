namespace BasicFacebookFeatures
{
    public partial class GroupsForm
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
            this.m_ReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_ReturnButton
            // 
            this.m_ReturnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_ReturnButton.Location = new System.Drawing.Point(11, 470);
            this.m_ReturnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_ReturnButton.Name = "m_ReturnButton";
            this.m_ReturnButton.Size = new System.Drawing.Size(128, 31);
            this.m_ReturnButton.TabIndex = 1;
            this.m_ReturnButton.Text = "Return back";
            this.m_ReturnButton.UseVisualStyleBackColor = true;
            this.m_ReturnButton.Click += new System.EventHandler(this.m_ReturnButton_Click);
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(945, 510);
            this.Controls.Add(this.m_ReturnButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GroupsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_ReturnButton;
    }
}