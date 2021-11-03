using ComponentFactory.Krypton.Toolkit;
using System.Diagnostics;

namespace Simple_Color_Picker_WinForm
{
    public partial class UsageForum : KryptonForm
    {
        public UsageForum()
        {
            InitializeComponent();
        }

        public void SetTomMost(bool TopMost)
        {
            this.TopMost = TopMost;
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, System.EventArgs e)
        {
            Process.Start("https://github.com/MRKaZ");
        }

        private void linkLblLicense_LinkClicked(object sender, System.EventArgs e)
        {
            Process.Start("https://raw.githubusercontent.com/MRKaZ/Simple-Color-Picker/main/LICENSE");
        }
    }
}
