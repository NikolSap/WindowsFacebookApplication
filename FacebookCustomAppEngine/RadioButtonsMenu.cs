using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookCustomAppEngine
{
    public class RadioButtonsMenu:List<RadioButtonItem>
    {
        public void InitializeChoosePictureStrategy(Panel i_Panel,List<Panel> i_PanelsList)
        {
            int index;
            foreach (object button in i_Panel.Controls)
            {
                if(button.GetType()==typeof(RadioButton))
                {
                    if (((RadioButton)button).Checked)
                    {
                        index = int.Parse(((RadioButton)button).Tag.ToString());
                        i_Panel.Visible = false;
                        i_PanelsList[index-1].Visible = true;
                    }
                }
            }
        }
    }
}
