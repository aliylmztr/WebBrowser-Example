using System;
using System.Windows.Forms;

namespace WebBrowserExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_git_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.tr");
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btn_ileri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
    }
}
