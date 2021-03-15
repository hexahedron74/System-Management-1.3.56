using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Manager
{
    public partial class Developer : UserControl
    {
        public Developer()
        {
            InitializeComponent();
        }

        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                GithubLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void blogLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                BlogLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void websiteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                WebsiteLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GithubLink()
        {
            //Call the Process.Start method to open the default browser
            //with a URL:
            System.Diagnostics.Process.Start("https://github.com/hexahedron74");
        }

        private void BlogLink()
        {
            System.Diagnostics.Process.Start("https://blog.naver.com/hexahedron74");
        }

        private void WebsiteLink()
        {
            System.Diagnostics.Process.Start("https://syntaxack-team.netlify.app/");
        }
    }
}
