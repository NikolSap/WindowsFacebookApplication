using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BasicFacebookFeatures;
using FacebookCustomAppEngine;

namespace FourInRowForms
{
    public partial class StartingGameForm : BaseClassOfAllFeaturesForm
    {
        private string m_SecondPlayerName;
        private Image m_SecondPlayerPhoto;
        List<ImageAndString> m_SelectionFriendsList;

        public StartingGameForm()
        {
            m_SelectionFriendsList = new List<ImageAndString>();
            Dictionary<string, ImageAndString> userFriends = FacebookAppEngine.Instance.FetchFriendsDictionary();
            InitializeComponent();
            m_Player1TextBox.Text = FacebookAppEngine.Instance.GetUserName();
            foreach (KeyValuePair<string, ImageAndString> keyValuePair in userFriends)
            {
                m_SelectionFriendsList.Add(keyValuePair.Value);
                m_Player2ComboBox.Items.Add(keyValuePair.Value.StringToAdd);
            }
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void m_StartButton_Click(object sender, EventArgs e)
        {
            if (!m_Player2ComboBox.Items.Contains(m_Player2ComboBox.Text) && m_Player2ComboBox.Text != "[Computer]")
            {
                MessageBox.Show(
                    "This is not your facebook friend!",
                    "Please select friend from the list.",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            else
            {
                if (m_Player1TextBox.Text == string.Empty || m_Player2ComboBox.Text == string.Empty)
                {
                    MessageBox.Show(
                        "Please fill all fields.",
                        "Fill all information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    if (!m_CheckBoxPlayer2.Checked)
                    {
                        m_SecondPlayerName = "Computer";
                    }
                    else
                    {
                        m_SecondPlayerName = m_SelectionFriendsList[m_Player2ComboBox.SelectedIndex].StringToAdd;
                        m_SecondPlayerPhoto = m_SelectionFriendsList[m_Player2ComboBox.SelectedIndex].image;
                    }
                    Hide();
                    GameFormBoard gameBoard = new GameFormBoard(
                        (int)m_RowsNumericUpDown.Value,
                        (int)m_ColsNumericUpDown.Value,
                        m_Player1TextBox.Text,
                        m_SecondPlayerName, m_SecondPlayerPhoto, !m_CheckBoxPlayer2.Checked);
                    gameBoard.ShowDialog();
                }
            }


        }

        private void StartingGameForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (m_CheckBoxPlayer2.Checked == false)
            {
                m_Player2ComboBox.Text = "[Computer]";
                m_Player2ComboBox.Enabled = false;
            }
            else
            {
                m_Player2ComboBox.Enabled = true;
            }

        }

        private void m_Player2ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}
