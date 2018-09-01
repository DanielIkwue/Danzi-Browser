using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Danzi_Browser
{
    public partial class DanziBrowse : Form
    {
        public DanziBrowse()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5500);
            InitializeComponent();
            t.Abort();
        }

        public void StartForm() {
            Application.Run(new frmSplashScreen());

        }

        private void DanziBrowse_Load(object sender, EventArgs e)
        {

            webBrowser.Navigate("http://www.google.com/");
            webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = webBrowser.DocumentTitle;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
                web.Navigate(txtUrl.Text);
        }


        WebBrowser webtab = null;

        private void btnNewtab_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "New Tab";
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount - 1);
            webtab = new WebBrowser() { ScriptErrorsSuppressed = true };
            webtab.Parent = tab;
            webtab.Dock = DockStyle.Fill;
            webtab.Navigate("https://www.google.com");
            txtUrl.Text = "https://www.google.com";
            webtab.DocumentCompleted += Webtab_DocumentCompleted;
        }

        private void Webtab_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = webtab.DocumentTitle; 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoBack)
                    web.GoBack();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoForward)
                    web.GoForward();
            }
        }

        private void txtUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
                if (web != null)
                {
                    web.Navigate(txtUrl.Text);
                }
            }
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void Homebtn_Click(object sender, EventArgs e) => webBrowser.GoHome();

        private void RemoveTab_Click(object sender, EventArgs e)
        {
            TabPage current_tab = tabControl.SelectedTab;
            tabControl.TabPages.Remove(current_tab);
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Program was made by Daniel Ikwue in C# using visual studio 2017 edition by Microsoft");
        }
    }
}
