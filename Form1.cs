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

        private void button1_Click(object sender, EventArgs e)
        {
            string html = Clipboard.GetText();
            doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            tvw.Nodes.Clear();
            var root = tvw.Nodes.Add("root");
            addNode(doc.DocumentNode, root);
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

        private void txtXpath_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    var sg = doc.DocumentNode.SelectSingleNode(txtXpath.Text);
                    if (sg == null) return;
                    var xpath = sg.XPath;
                    found = false;
                    findNode(tvw.Nodes[0], xpath);
                }
                catch { }
                tvw.Focus();
            }
        }

        bool found = false;
        private void findNode(TreeNode tn, string key)
        {
            Application.DoEvents();
            if (found) return;
            if (tn.Nodes[key] == null)
            {
                foreach (TreeNode child in tn.Nodes)
                {
                    findNode(child, key);
                }
            }
            else
            {
                tvw.SelectedNode = tn.Nodes[key];
                found = true;
            }
        }

        private void tvw_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtXpath.Text = e.Node.Name;
            try
            {
                txtInnerHtml.Text = doc.DocumentNode.SelectSingleNode(txtXpath.Text).OuterHtml;
            }
            catch { }
        }
    }
}
