using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FacebookCustomAppEngine;

namespace LikesCounter
{
    public partial class LikesResultsForm : Form
    {
        private Dictionary<string, Dictionary<string, ImageAndString>> m_ResultsDictionary;
        private Dictionary<Point, PictureBox> m_DictionaryOfPictureBox;
        private List<Label> m_LabelHeadLineList;
        private Dictionary<Point, Label> m_LabelNamesDictionary;

        public LikesResultsForm(Dictionary<string, Dictionary<string, ImageAndString>> i_winningDictionary)
        {
            this.m_ResultsDictionary = i_winningDictionary;
            this.InitializeComponent();
            this.insertPictureBoxToDictionary();
            this.insrtLabelToList();
            this.printOneParts();
        }

        private void insrtLabelToList()
        {
            this.m_LabelNamesDictionary = new Dictionary<Point, Label>();
            this.m_LabelHeadLineList = new List<Label>();
            this.m_LabelHeadLineList.Add(this.m_LabelFirstSection);
            this.m_LabelHeadLineList.Add(this.m_LabelSecondSection);
            this.m_LabelHeadLineList.Add(this.m_LabelThirdSection);

            this.m_LabelNamesDictionary.Add(new Point(1, 1), this.m_Label11);
            this.m_LabelNamesDictionary.Add(new Point(1, 2), this.m_Label12);
            this.m_LabelNamesDictionary.Add(new Point(1, 3), this.m_Label13);
            this.m_LabelNamesDictionary.Add(new Point(1, 4), this.m_Label14);
            this.m_LabelNamesDictionary.Add(new Point(1, 5), this.m_Label15);
            this.m_LabelNamesDictionary.Add(new Point(1, 6), this.m_Label16);
            this.m_LabelNamesDictionary.Add(new Point(2, 1), this.m_Label21);
            this.m_LabelNamesDictionary.Add(new Point(2, 2), this.m_Label22);
            this.m_LabelNamesDictionary.Add(new Point(2, 3), this.m_Label23);
            this.m_LabelNamesDictionary.Add(new Point(2, 4), this.m_Label24);
            this.m_LabelNamesDictionary.Add(new Point(2, 5), this.m_Label25);
            this.m_LabelNamesDictionary.Add(new Point(2, 6), this.m_Label26);
            this.m_LabelNamesDictionary.Add(new Point(3, 1), this.m_Label31);
            this.m_LabelNamesDictionary.Add(new Point(3, 2), this.m_Label32);
            this.m_LabelNamesDictionary.Add(new Point(3, 3), this.m_Label33);
            this.m_LabelNamesDictionary.Add(new Point(3, 4), this.m_Label34);
            this.m_LabelNamesDictionary.Add(new Point(3, 5), this.m_label35);
            this.m_LabelNamesDictionary.Add(new Point(3, 6), this.m_Label36);
        }

        private void insertPictureBoxToDictionary()
        {
            this.m_DictionaryOfPictureBox = new Dictionary<Point, PictureBox>();
            this.m_DictionaryOfPictureBox.Add(new Point(1, 1), this.m_PictureBox11);
            this.m_DictionaryOfPictureBox.Add(new Point(1, 2), this.m_PictureBox12);
            this.m_DictionaryOfPictureBox.Add(new Point(1, 3), this.m_PictureBox13);
            this.m_DictionaryOfPictureBox.Add(new Point(1, 4), this.m_PictureBox14);
            this.m_DictionaryOfPictureBox.Add(new Point(1, 5), this.m_PictureBox15);
            this.m_DictionaryOfPictureBox.Add(new Point(1, 6), this.m_PictureBox16);
            this.m_DictionaryOfPictureBox.Add(new Point(2, 1), this.m_PictureBox21);
            this.m_DictionaryOfPictureBox.Add(new Point(2, 2), this.m_PictureBox22);
            this.m_DictionaryOfPictureBox.Add(new Point(2, 3), this.m_PictureBox23);
            this.m_DictionaryOfPictureBox.Add(new Point(2, 4), this.m_PictureBox24);
            this.m_DictionaryOfPictureBox.Add(new Point(2, 5), this.m_PictureBox25);
            this.m_DictionaryOfPictureBox.Add(new Point(2, 6), this.m_PictureBox26);
            this.m_DictionaryOfPictureBox.Add(new Point(3, 1), this.m_PictureBox31);
            this.m_DictionaryOfPictureBox.Add(new Point(3, 2), this.m_PictureBox32);
            this.m_DictionaryOfPictureBox.Add(new Point(3, 3), this.m_PictureBox33);
            this.m_DictionaryOfPictureBox.Add(new Point(3, 4), this.m_PictureBox34);
            this.m_DictionaryOfPictureBox.Add(new Point(3, 5), this.m_PictureBox35);
            this.m_DictionaryOfPictureBox.Add(new Point(3, 6), this.m_PictureBox36);
        }

        private void printOneParts()
        {
            int sectionSerializer = 0;
            int placeInSection;

            foreach (string key in this.m_ResultsDictionary.Keys)
            {
                switch (key)
                {
                    case "albums": 
                        this.m_LabelHeadLineList[sectionSerializer].Text = "Albums";
                        break;
                    case "photos":
                        this.m_LabelHeadLineList[sectionSerializer].Text = "Photos";
                        break;
                    case "posts":
                        this.m_LabelHeadLineList[sectionSerializer].Text = "Posts";
                        break;
                }

                sectionSerializer++;
                placeInSection = 1;

                foreach(KeyValuePair<string, ImageAndString> keyValuePair in this.m_ResultsDictionary[key])
                {
                    Point position = new Point(sectionSerializer, placeInSection);
                    this.m_DictionaryOfPictureBox[position].Image =
                        keyValuePair.Value.image;
                    this.m_DictionaryOfPictureBox[position].SizeMode = PictureBoxSizeMode.StretchImage;
                    this.m_LabelNamesDictionary[position].Text = keyValuePair.Value.StringToAdd;
                    placeInSection++;
                }
            }
        }

        private void m_ButtonBackToTheLastForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LikesResultsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
