namespace ProxyWebBrowser
{
    partial class webBrowserProxy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.urlFeed = new System.Windows.Forms.TextBox();
            this.currentUrl = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1089, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonGoClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1008, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonRefreshClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(927, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Stop";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonStopClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonBackClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(49, 24);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = ">";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonForwardClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(88, 24);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Home";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonHomeClick);
            // 
            // urlFeed
            // 
            this.urlFeed.Location = new System.Drawing.Point(169, 26);
            this.urlFeed.Name = "urlFeed";
            this.urlFeed.Size = new System.Drawing.Size(752, 20);
            this.urlFeed.TabIndex = 6;
            this.urlFeed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlFeedPress);
            // 
            // currentUrl
            // 
            this.currentUrl.AutoSize = true;
            this.currentUrl.Location = new System.Drawing.Point(12, 59);
            this.currentUrl.Name = "currentUrl";
            this.currentUrl.Size = new System.Drawing.Size(53, 13);
            this.currentUrl.TabIndex = 7;
            this.currentUrl.Text = "currentUrl";
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(9, 595);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(35, 13);
            this.status.TabIndex = 8;
            this.status.Text = "status";
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(12, 88);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1152, 504);
            this.webBrowser.TabIndex = 9;
            this.webBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser_DocumentCompleted);
            this.webBrowser.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser_ProgressChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1225, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "IP :";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(1266, 88);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(38, 13);
            this.ipLabel.TabIndex = 11;
            this.ipLabel.Text = "NONE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1225, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Port : ";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(1266, 126);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(38, 13);
            this.portLabel.TabIndex = 13;
            this.portLabel.Text = "NONE";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1190, 158);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(154, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "Use/Refresh Proxy";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ButtonUseProxyClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 617);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.status);
            this.Controls.Add(this.currentUrl);
            this.Controls.Add(this.urlFeed);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox urlFeed;
        private System.Windows.Forms.Label currentUrl;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Button button7;
    }
}

