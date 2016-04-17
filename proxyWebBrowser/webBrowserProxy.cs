using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Misc;

namespace ProxyWebBrowser
{




    public partial class webBrowserProxy : Form
    {

        public webBrowserProxy()
        {
            InitializeComponent();
        }

        
        private void urlFeedPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonGoClick(this, new EventArgs());
            }
        }



        private void buttonGoClick(object sender, EventArgs e)
        {
            webBrowser.Navigate(urlFeed.Text);



           // Uri urifeed = new Uri(urlFeed.Text);

           //// WebProxy proxy = ProxyClient.ClientSideProxy.getAvailableProxy();
           // WebProxy proxy = new WebProxy("103.243.25.134", 80);

           // HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(urifeed);

           // //request.Proxy = proxy;

           // HttpWebResponse response = (HttpWebResponse)request.GetResponse();

           // webBrowser.DocumentStream = response.GetResponseStream();

            
            

        }

        private void buttonBackClick(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void buttonHomeClick(object sender, EventArgs e)
        {
            webBrowser.GoHome();
        }

        private void buttonStopClick(object sender, EventArgs e)
        {
            webBrowser.Stop();
        }

        private void buttonRefreshClick(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void buttonForwardClick(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void ButtonUseProxyClick(object sender, EventArgs e)
        {
            string proxyAddress = Misc.InternetFunctions.StartUpProxy();

            if(proxyAddress == null || proxyAddress.Length == 0)
            {
                ipLabel.Text = "none";
                portLabel.Text = "none";

            }
            else
            {
                string[] ipport = proxyAddress.Split(':');

                ipLabel.Text = ipport[0];
                portLabel.Text = ipport[1];

            }

        }



        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            currentUrl.Text = webBrowser.DocumentTitle;
            urlFeed.Text = webBrowser.Url.ToString();
         
        }

        private void webBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            status.Text = webBrowser.StatusText;
            
        }




        


        








    }
}
