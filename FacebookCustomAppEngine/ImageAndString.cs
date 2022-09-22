using System.Drawing;

namespace FacebookCustomAppEngine
{
    public class ImageAndString
    {
        private readonly Image r_Image;
        private readonly string r_StringToAdd;

        public ImageAndString(Image i_Image, string i_string)
        {
            this.r_Image = i_Image;
            this.r_StringToAdd = i_string;
        }

        public Image image
        {
            get
            {
                return this.r_Image;
            }
        }

        public string StringToAdd
        {
            get
            {
                return this.r_StringToAdd;
            }
        }
    }
}
