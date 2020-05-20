using System;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace zadanie3
{
    public partial class Form1 : Form
    {
        private string XmlSchemaPath;
        private string XmlPath;
        private bool XsdValid = true;
        private bool DtdValid = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XSD-File | *.xsd";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XmlSchemaPath = openFileDialog1.FileName;
                label2.Text = openFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XML-File | *.xml";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XmlPath = openFileDialog1.FileName;
                label3.Text = openFileDialog1.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var schema = new XmlSchemaSet();
            schema.Add("", XmlSchemaPath);
            var rd = XmlReader.Create(XmlPath, new XmlReaderSettings { DtdProcessing = DtdProcessing.Ignore });
            var doc = XDocument.Load(rd);
            doc.Validate(schema, (o, args) =>
            {
                XsdValid = false;
            });

            var rd1 = XmlReader.Create(XmlPath, new XmlReaderSettings
            {
                DtdProcessing = DtdProcessing.Parse
            });
            var doc1 = XDocument.Load(rd1);
            doc1.Validate(schema, (o, args) =>
            {
                DtdValid = false;
            });

            if (!XsdValid)
            {
                MessageBox.Show($"Plik XML niezgodny z definicją XSD");
            }

            if (!DtdValid)
            {
                MessageBox.Show($"Plik XML niezgodny z definicja DTD");
            }

            if (XsdValid && DtdValid)
            {
                MessageBox.Show("Plik XML zgodny z definicją XSD i DTD ");
            }
        }
    }
}
