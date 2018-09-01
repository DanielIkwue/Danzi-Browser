namespace Danzi_Browser
{
    partial class DanziBrowse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanziBrowse));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnNewtab = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.Refreshbtn = new System.Windows.Forms.Button();
            this.Homebtn = new System.Windows.Forms.Button();
            this.RemoveTab = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Salmon;
            this.btnBack.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(4, 9);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(58, 27);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.Salmon;
            this.btnForward.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.Location = new System.Drawing.Point(67, 9);
            this.btnForward.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(58, 28);
            this.btnForward.TabIndex = 1;
            this.btnForward.Text = ">>";
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnNewtab
            // 
            this.btnNewtab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewtab.BackColor = System.Drawing.Color.Gold;
            this.btnNewtab.Font = new System.Drawing.Font("Oswald", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewtab.Location = new System.Drawing.Point(1055, 9);
            this.btnNewtab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNewtab.Name = "btnNewtab";
            this.btnNewtab.Size = new System.Drawing.Size(68, 26);
            this.btnNewtab.TabIndex = 2;
            this.btnNewtab.Text = "New Tab";
            this.btnNewtab.UseVisualStyleBackColor = false;
            this.btnNewtab.Click += new System.EventHandler(this.btnNewtab_Click);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.BackColor = System.Drawing.Color.Gold;
            this.btnGo.Font = new System.Drawing.Font("Oswald", 8.25F);
            this.btnGo.Location = new System.Drawing.Point(928, 10);
            this.btnGo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(50, 26);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUrl.Font = new System.Drawing.Font("Oswald", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(131, 12);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(603, 25);
            this.txtUrl.TabIndex = 4;
            this.txtUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrl_KeyPress);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl.Location = new System.Drawing.Point(-2, 41);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1136, 597);
            this.tabControl.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.webBrowser);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Size = new System.Drawing.Size(1128, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(2, 3);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScriptErrorsSuppressed = true;
            this.webBrowser.Size = new System.Drawing.Size(1124, 561);
            this.webBrowser.TabIndex = 0;
            // 
            // Refreshbtn
            // 
            this.Refreshbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Refreshbtn.BackColor = System.Drawing.Color.Gold;
            this.Refreshbtn.Font = new System.Drawing.Font("Oswald", 8.25F);
            this.Refreshbtn.Location = new System.Drawing.Point(862, 9);
            this.Refreshbtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Refreshbtn.Name = "Refreshbtn";
            this.Refreshbtn.Size = new System.Drawing.Size(60, 26);
            this.Refreshbtn.TabIndex = 6;
            this.Refreshbtn.Text = "Refresh";
            this.Refreshbtn.UseVisualStyleBackColor = false;
            this.Refreshbtn.Click += new System.EventHandler(this.Refreshbtn_Click);
            // 
            // Homebtn
            // 
            this.Homebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Homebtn.BackColor = System.Drawing.Color.Gold;
            this.Homebtn.Font = new System.Drawing.Font("Oswald", 8.25F);
            this.Homebtn.Location = new System.Drawing.Point(740, 8);
            this.Homebtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Homebtn.Name = "Homebtn";
            this.Homebtn.Size = new System.Drawing.Size(61, 27);
            this.Homebtn.TabIndex = 7;
            this.Homebtn.Text = "Home";
            this.Homebtn.UseVisualStyleBackColor = false;
            this.Homebtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // RemoveTab
            // 
            this.RemoveTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveTab.BackColor = System.Drawing.Color.Gold;
            this.RemoveTab.Font = new System.Drawing.Font("Oswald", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveTab.Location = new System.Drawing.Point(984, 9);
            this.RemoveTab.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.RemoveTab.Name = "RemoveTab";
            this.RemoveTab.Size = new System.Drawing.Size(65, 26);
            this.RemoveTab.TabIndex = 8;
            this.RemoveTab.Text = "Close Tab";
            this.RemoveTab.UseVisualStyleBackColor = false;
            this.RemoveTab.Click += new System.EventHandler(this.RemoveTab_Click);
            // 
            // About
            // 
            this.About.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.About.BackColor = System.Drawing.Color.Gold;
            this.About.Font = new System.Drawing.Font("Oswald", 8.25F);
            this.About.Location = new System.Drawing.Point(811, 8);
            this.About.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(44, 27);
            this.About.TabIndex = 9;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = false;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // DanziBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(1129, 639);
            this.Controls.Add(this.About);
            this.Controls.Add(this.RemoveTab);
            this.Controls.Add(this.Homebtn);
            this.Controls.Add(this.Refreshbtn);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnNewtab);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "DanziBrowse";
            this.Text = "DanziBrowse";
            this.Load += new System.EventHandler(this.DanziBrowse_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnNewtab;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button Refreshbtn;
        private System.Windows.Forms.Button Homebtn;
        private System.Windows.Forms.Button RemoveTab;
        private System.Windows.Forms.Button About;
    }
}

