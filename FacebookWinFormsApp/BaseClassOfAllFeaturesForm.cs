using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class BaseClassOfAllFeaturesForm : Form
    {
        public BaseClassOfAllFeaturesForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }
    }
}
