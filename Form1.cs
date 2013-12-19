using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace HtmlDocumentExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

        private void buildUI(string html)
        {
            doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            tvw.Nodes.Clear();
            var root = tvw.Nodes.Add("root");
            addNode(doc.DocumentNode, root);
        }

        private void btnLoadFromClipboard_Click(object sender, EventArgs e)
        {
            string html = Clipboard.GetText();
            buildUI(html);
        }

        private void addNode(HtmlAgilityPack.HtmlNode n, TreeNode tn)
        {
            foreach (var node in n.ChildNodes)
            {
                var tm = tn.Nodes.Add(node.XPath, node.Name);
                tm.Name = node.XPath;
                addNode(node, tm);
            }
            Application.DoEvents();
        }

        HtmlAgilityPack.HtmlNodeCollection collection = null;
        int matchIndex = 0;

        private void txtXpath_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtXpath.Text.StartsWith("http://"))
                {
                    try
                    {
                        web.Navigate(txtXpath.Text);
                    }
                    catch
                    {

                    }
                }
                else
                {
                    try
                    {
                        collection = doc.DocumentNode.SelectNodes(txtXpath.Text);
                        if (collection == null) return;
                        btnPrevMatch.Visible = btnNextMatch.Visible = true;
                        btnPrevMatch.Enabled = false; btnNextMatch.Enabled = collection.Count > 1;
                        matchIndex = 0;
                        selectMatchNode();
                    }
                    catch { }
                    tvw.Focus();
                }
            }
        }

        private void selectMatchNode()
        {
            var xpath = collection[matchIndex].XPath;
           findNode(tvw.Nodes[0], xpath);
        }

        private void findNode(TreeNode root, string key)
        {
            Application.DoEvents();

            string[] seg = key.Split('/');
            string ppath = "";
            for (int i = 1; i < seg.Length; ++i)
            {
                ppath += "/" + seg[i];
                if (!root.Nodes.ContainsKey(ppath)) return;
                root = root.Nodes[ppath];
            }
            tvw.SelectedNode = root;
        }

        private void tvw_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtXpath.Text = e.Node.Name;
            try
            {
                txtInnerHtml.Text = chkTextOnly.Checked ? doc.DocumentNode.SelectSingleNode(txtXpath.Text).InnerText : doc.DocumentNode.SelectSingleNode(txtXpath.Text).OuterHtml;
            }
            catch { }
        }

        private void web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            try { buildUI(web.Document.GetElementsByTagName("html")[0].InnerHtml); }
            catch { }
        }

        private void btnPrevMatch_Click(object sender, EventArgs e)
        {
            matchIndex--;
            selectMatchNode();
            btnNextMatch.Enabled = true;
            if (collection == null || matchIndex <= 0) { btnPrevMatch.Enabled = false; return; }
        }

        private void btnNextMatch_Click(object sender, EventArgs e)
        {
            matchIndex++;
            selectMatchNode();
            btnPrevMatch.Enabled = true;
            if (collection == null || matchIndex >= collection.Count - 1) { btnNextMatch.Enabled = false; return; }
        }
    }
}
