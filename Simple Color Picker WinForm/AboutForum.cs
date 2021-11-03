using ComponentFactory.Krypton.Toolkit;
using System;
using System.Diagnostics;

namespace Simple_Color_Picker_WinForm
{
    public partial class AboutForum : KryptonForm
    {
        public AboutForum()
        {
            InitializeComponent();
        }

        public void SetTomMost(bool TopMost)
        {
            this.TopMost = TopMost;
        }

        private void kryptonLinkLabel1_LinkClicked(object sender, EventArgs e)
        {
            Process.Start("https://github.com/MRKaZ");
        }

        private void LblLicense_LinkClicked(object sender, EventArgs e)
        {
            Process.Start("https://raw.githubusercontent.com/MRKaZ/Simple-Color-Picker/main/LICENSE");    
        }
    }
}
