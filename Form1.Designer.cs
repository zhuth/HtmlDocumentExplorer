namespace HtmlDocumentExplorer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnPrevMatch = new System.Windows.Forms.Button();
            this.btnNextMatch = new System.Windows.Forms.Button();
            this.chkTextOnly = new System.Windows.Forms.CheckBox();
            this.txtXpath = new System.Windows.Forms.TextBox();
            this.btnLoadFromClipboard = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvw = new System.Windows.Forms.TreeView();
            this.web = new System.Windows.Forms.WebBrowser();
            this.txtInnerHtml = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnPrevMatch);
            this.splitContainer2.Panel1.Controls.Add(this.btnNextMatch);
            this.splitContainer2.Panel1.Controls.Add(this.chkTextOnly);
            this.splitContainer2.Panel1.Controls.Add(this.txtXpath);
            this.splitContainer2.Panel1.Controls.Add(this.btnLoadFromClipboard);
            this.splitContainer2.Panel1MinSize = 60;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(698, 496);
            this.splitContainer2.SplitterDistance = 60;
            this.splitContainer2.TabIndex = 5;
            // 
            // btnPrevMatch
            // 
            this.btnPrevMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevMatch.Location = new System.Drawing.Point(523, 33);
            this.btnPrevMatch.Name = "btnPrevMatch";
            this.btnPrevMatch.Size = new System.Drawing.Size(41, 23);
            this.btnPrevMatch.TabIndex = 8;
            this.btnPrevMatch.Text = "Prev";
            this.btnPrevMatch.UseVisualStyleBackColor = true;
            this.btnPrevMatch.Visible = false;
            this.btnPrevMatch.Click += new System.EventHandler(this.btnPrevMatch_Click);
            // 
            // btnNextMatch
            // 
            this.btnNextMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextMatch.Location = new System.Drawing.Point(570, 33);
            this.btnNextMatch.Name = "btnNextMatch";
            this.btnNextMatch.Size = new System.Drawing.Size(41, 23);
            this.btnNextMatch.TabIndex = 7;
            this.btnNextMatch.Text = "Next";
            this.btnNextMatch.UseVisualStyleBackColor = true;
            this.btnNextMatch.Visible = false;
            this.btnNextMatch.Click += new System.EventHandler(this.btnNextMatch_Click);
            // 
            // chkTextOnly
            // 
            this.chkTextOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTextOnly.AutoSize = true;
            this.chkTextOnly.Location = new System.Drawing.Point(638, 37);
            this.chkTextOnly.Name = "chkTextOnly";
            this.chkTextOnly.Size = new System.Drawing.Size(48, 16);
            this.chkTextOnly.TabIndex = 6;
            this.chkTextOnly.Text = "Text";
            this.chkTextOnly.UseVisualStyleBackColor = true;
            // 
            // txtXpath
            // 
            this.txtXpath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXpath.Location = new System.Drawing.Point(162, 10);
            this.txtXpath.Name = "txtXpath";
            this.txtXpath.Size = new System.Drawing.Size(524, 21);
            this.txtXpath.TabIndex = 5;
            this.txtXpath.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtXpath_KeyUp);
            // 
            // btnLoadFromClipboard
            // 
            this.btnLoadFromClipboard.Location = new System.Drawing.Point(12, 10);
            this.btnLoadFromClipboard.Name = "btnLoadFromClipboard";
            this.btnLoadFromClipboard.Size = new System.Drawing.Size(144, 23);
            this.btnLoadFromClipboard.TabIndex = 4;
            this.btnLoadFromClipboard.Text = "Load from Clipboard";
            this.btnLoadFromClipboard.UseVisualStyleBackColor = true;
            this.btnLoadFromClipboard.Click += new System.EventHandler(this.btnLoadFromClipboard_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvw);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.web);
            this.splitContainer1.Panel2.Controls.Add(this.txtInnerHtml);
            this.splitContainer1.Size = new System.Drawing.Size(698, 432);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.TabIndex = 5;
            // 
            // tvw
            // 
            this.tvw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvw.Location = new System.Drawing.Point(0, 0);
            this.tvw.Name = "tvw";
            this.tvw.Size = new System.Drawing.Size(232, 432);
            this.tvw.TabIndex = 3;
            this.tvw.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvw_AfterSelect);
            // 
            // web
            // 
            this.web.IsWebBrowserContextMenuEnabled = false;
            this.web.Location = new System.Drawing.Point(90, 161);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.ScriptErrorsSuppressed = true;
            this.web.Size = new System.Drawing.Size(250, 250);
            this.web.TabIndex = 4;
            this.web.Visible = false;
            this.web.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.web_DocumentCompleted);
            // 
            // txtInnerHtml
            // 
            this.txtInnerHtml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInnerHtml.Location = new System.Drawing.Point(0, 0);
            this.txtInnerHtml.Multiline = true;
            this.txtInnerHtml.Name = "txtInnerHtml";
            this.txtInnerHtml.ReadOnly = true;
            this.txtInnerHtml.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInnerHtml.Size = new System.Drawing.Size(462, 432);
            this.txtInnerHtml.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 496);
            this.Controls.Add(this.splitContainer2);
            this.Name = "Form1";
            this.Text = "HtmlDocument Explorer";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox txtXpath;
        private System.Windows.Forms.Button btnLoadFromClipboard;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvw;
        private System.Windows.Forms.TextBox txtInnerHtml;
        private System.Windows.Forms.WebBrowser web;
        private System.Windows.Forms.CheckBox chkTextOnly;
        private System.Windows.Forms.Button btnPrevMatch;
        private System.Windows.Forms.Button btnNextMatch;

    }
}

