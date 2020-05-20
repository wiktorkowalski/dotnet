using System;
using System.Windows.Forms;
using System.Xml;

namespace zadanie4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var xml = new XmlDocument();
            xml.Load(@"..\..\randomuser.xml");
            treeView1.Nodes.Clear();
            foreach (XmlNode xNode in xml.ChildNodes)
            {
                var tNode = treeView1.Nodes[treeView1.Nodes.Add(new TreeNode(xNode.Name))];
                AddNode(xNode, tNode);
            }
        }

        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            if (inXmlNode.HasChildNodes)
            {
                if (inXmlNode.Attributes != null)
                {

                    foreach (XmlAttribute att in inXmlNode.Attributes)
                    {
                        inTreeNode.Text = inTreeNode.Text + " " + att.Name + ": " + att.Value;
                    }
                }

                var nodeList = inXmlNode.ChildNodes;

                for (var i = 0; i < nodeList.Count; i++)
                {
                    var xNode = inXmlNode.ChildNodes[i];
                    var tNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(xNode.Name))];
                    AddNode(xNode, tNode);
                }
            }
            else
            {
                inTreeNode.Text = (inXmlNode.OuterXml).Trim();
            }

            treeView1.ExpandAll();
        }


    }
}
