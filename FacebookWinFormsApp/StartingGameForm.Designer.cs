
namespace FourInRowForms
{
    partial class StartingGameForm
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
            this.m_PlayersLabel = new System.Windows.Forms.Label();
            this.m_Player1Label = new System.Windows.Forms.Label();
            this.m_Player1TextBox = new System.Windows.Forms.TextBox();
            this.m_Player2Label = new System.Windows.Forms.Label();
            this.m_Player2ComboBox = new System.Windows.Forms.ComboBox();
            this.m_BoardSizeLabel = new System.Windows.Forms.Label();
            this.m_RowsLabel = new System.Windows.Forms.Label();
            this.m_RowsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.m_ColsLabel = new System.Windows.Forms.Label();
            this.m_ColsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.m_CheckBoxPlayer2 = new System.Windows.Forms.CheckBox();
            this.m_StartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_RowsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ColsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // m_PlayersLabel
            // 
            this.m_PlayersLabel.AutoSize = true;
            this.m_PlayersLabel.BackColor = System.Drawing.Color.LightBlue;
            this.m_PlayersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_PlayersLabel.ForeColor = System.Drawing.Color.Black;
            this.m_PlayersLabel.Location = new System.Drawing.Point(36, 31);
            this.m_PlayersLabel.Name = "m_PlayersLabel";
            this.m_PlayersLabel.Size = new System.Drawing.Size(91, 25);
            this.m_PlayersLabel.TabIndex = 0;
            this.m_PlayersLabel.Text = "Players:";
            // 
            // m_Player1Label
            // 
            this.m_Player1Label.AutoSize = true;
            this.m_Player1Label.BackColor = System.Drawing.Color.LightBlue;
            this.m_Player1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_Player1Label.Location = new System.Drawing.Point(71, 64);
            this.m_Player1Label.Name = "m_Player1Label";
            this.m_Player1Label.Size = new System.Drawing.Size(74, 18);
            this.m_Player1Label.TabIndex = 1;
            this.m_Player1Label.Text = "Player 1:";
            // 
            // m_Player1TextBox
            // 
            this.m_Player1TextBox.BackColor = System.Drawing.Color.LightBlue;
            this.m_Player1TextBox.Enabled = false;
            this.m_Player1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_Player1TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.m_Player1TextBox.Location = new System.Drawing.Point(169, 63);
            this.m_Player1TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_Player1TextBox.Name = "m_Player1TextBox";
            this.m_Player1TextBox.ReadOnly = true;
            this.m_Player1TextBox.Size = new System.Drawing.Size(151, 24);
            this.m_Player1TextBox.TabIndex = 2;
            // 
            // m_Player2Label
            // 
            this.m_Player2Label.AutoSize = true;
            this.m_Player2Label.BackColor = System.Drawing.Color.LightBlue;
            this.m_Player2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_Player2Label.Location = new System.Drawing.Point(71, 106);
            this.m_Player2Label.Name = "m_Player2Label";
            this.m_Player2Label.Size = new System.Drawing.Size(74, 18);
            this.m_Player2Label.TabIndex = 3;
            this.m_Player2Label.Text = "Player 2:";
            // 
            // m_Player2ComboBox
            // 
            this.m_Player2ComboBox.BackColor = System.Drawing.Color.LightBlue;
            this.m_Player2ComboBox.Enabled = false;
            this.m_Player2ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_Player2ComboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.m_Player2ComboBox.FormattingEnabled = true;
            this.m_Player2ComboBox.Location = new System.Drawing.Point(169, 106);
            this.m_Player2ComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_Player2ComboBox.Name = "m_Player2ComboBox";
            this.m_Player2ComboBox.Size = new System.Drawing.Size(151, 26);
            this.m_Player2ComboBox.TabIndex = 4;
            this.m_Player2ComboBox.TabStop = false;
            this.m_Player2ComboBox.Text = "[Computer]";
            this.m_Player2ComboBox.SelectedIndexChanged += new System.EventHandler(this.m_Player2ComboBox_SelectedIndexChanged);
            // 
            // m_BoardSizeLabel
            // 
            this.m_BoardSizeLabel.AutoSize = true;
            this.m_BoardSizeLabel.BackColor = System.Drawing.Color.LightBlue;
            this.m_BoardSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_BoardSizeLabel.Location = new System.Drawing.Point(36, 191);
            this.m_BoardSizeLabel.Name = "m_BoardSizeLabel";
            this.m_BoardSizeLabel.Size = new System.Drawing.Size(125, 25);
            this.m_BoardSizeLabel.TabIndex = 5;
            this.m_BoardSizeLabel.Text = "Board Size:";
            // 
            // m_RowsLabel
            // 
            this.m_RowsLabel.AutoSize = true;
            this.m_RowsLabel.BackColor = System.Drawing.Color.LightBlue;
            this.m_RowsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_RowsLabel.Location = new System.Drawing.Point(73, 233);
            this.m_RowsLabel.Name = "m_RowsLabel";
            this.m_RowsLabel.Size = new System.Drawing.Size(56, 18);
            this.m_RowsLabel.TabIndex = 6;
            this.m_RowsLabel.Text = "Rows:";
            // 
            // m_RowsNumericUpDown
            // 
            this.m_RowsNumericUpDown.BackColor = System.Drawing.Color.LightBlue;
            this.m_RowsNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_RowsNumericUpDown.Location = new System.Drawing.Point(145, 233);
            this.m_RowsNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_RowsNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.m_RowsNumericUpDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.m_RowsNumericUpDown.Name = "m_RowsNumericUpDown";
            this.m_RowsNumericUpDown.Size = new System.Drawing.Size(51, 24);
            this.m_RowsNumericUpDown.TabIndex = 7;
            this.m_RowsNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // m_ColsLabel
            // 
            this.m_ColsLabel.AutoSize = true;
            this.m_ColsLabel.BackColor = System.Drawing.Color.LightBlue;
            this.m_ColsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_ColsLabel.Location = new System.Drawing.Point(236, 234);
            this.m_ColsLabel.Name = "m_ColsLabel";
            this.m_ColsLabel.Size = new System.Drawing.Size(48, 18);
            this.m_ColsLabel.TabIndex = 8;
            this.m_ColsLabel.Text = "Cols:";
            // 
            // m_ColsNumericUpDown
            // 
            this.m_ColsNumericUpDown.BackColor = System.Drawing.Color.LightBlue;
            this.m_ColsNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_ColsNumericUpDown.Location = new System.Drawing.Point(289, 233);
            this.m_ColsNumericUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_ColsNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.m_ColsNumericUpDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.m_ColsNumericUpDown.Name = "m_ColsNumericUpDown";
            this.m_ColsNumericUpDown.Size = new System.Drawing.Size(51, 24);
            this.m_ColsNumericUpDown.TabIndex = 9;
            this.m_ColsNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.m_ColsNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // m_CheckBoxPlayer2
            // 
            this.m_CheckBoxPlayer2.AutoSize = true;
            this.m_CheckBoxPlayer2.Location = new System.Drawing.Point(47, 106);
            this.m_CheckBoxPlayer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_CheckBoxPlayer2.Name = "m_CheckBoxPlayer2";
            this.m_CheckBoxPlayer2.Size = new System.Drawing.Size(18, 17);
            this.m_CheckBoxPlayer2.TabIndex = 11;
            this.m_CheckBoxPlayer2.UseVisualStyleBackColor = true;
            this.m_CheckBoxPlayer2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // m_StartButton
            // 
            this.m_StartButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.m_StartButton.Location = new System.Drawing.Point(156, 300);
            this.m_StartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.m_StartButton.Name = "m_StartButton";
            this.m_StartButton.Size = new System.Drawing.Size(140, 33);
            this.m_StartButton.TabIndex = 10;
            this.m_StartButton.Text = "START !";
            this.m_StartButton.UseVisualStyleBackColor = true;
            this.m_StartButton.Click += new System.EventHandler(this.m_StartButton_Click);
            // 
            // StartingGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(427, 359);
            this.Controls.Add(this.m_CheckBoxPlayer2);
            this.Controls.Add(this.m_StartButton);
            this.Controls.Add(this.m_ColsNumericUpDown);
            this.Controls.Add(this.m_ColsLabel);
            this.Controls.Add(this.m_RowsNumericUpDown);
            this.Controls.Add(this.m_RowsLabel);
            this.Controls.Add(this.m_BoardSizeLabel);
            this.Controls.Add(this.m_Player2ComboBox);
            this.Controls.Add(this.m_Player2Label);
            this.Controls.Add(this.m_Player1TextBox);
            this.Controls.Add(this.m_Player1Label);
            this.Controls.Add(this.m_PlayersLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartingGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Four In Row";
            ((System.ComponentModel.ISupportInitialize)(this.m_RowsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ColsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label m_PlayersLabel;
        private System.Windows.Forms.Label m_Player1Label;
        private System.Windows.Forms.TextBox m_Player1TextBox;
        private System.Windows.Forms.Label m_Player2Label;
        private System.Windows.Forms.ComboBox m_Player2ComboBox;
        private System.Windows.Forms.Label m_BoardSizeLabel;
        private System.Windows.Forms.Label m_RowsLabel;
        private System.Windows.Forms.NumericUpDown m_RowsNumericUpDown;
        private System.Windows.Forms.Label m_ColsLabel;
        private System.Windows.Forms.NumericUpDown m_ColsNumericUpDown;
        private System.Windows.Forms.Button m_StartButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox m_CheckBoxPlayer2;
    }
}