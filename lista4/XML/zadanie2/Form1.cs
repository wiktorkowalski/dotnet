using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace zadanie2
{
    public partial class Form1 : Form
    {
        private ListViewColumnSorter lvwColumnSorter;


        private static People people = new People();

        private static List<Person> copy;
        public Form1()
        {
            InitializeComponent();
            lvwColumnSorter = new ListViewColumnSorter();
            this.listView1.ListViewItemSorter = lvwColumnSorter;
        }

        private void populateListView(List<Person> people)
        {

            listView1.BeginUpdate();
            foreach (Person person in people)
            {
                string[] row = { person.Id.ToString(), person.Name, person.Surname, person.Address, person.PhoneNumber.ToString() };
                ListViewItem listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }
            listView1.EndUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            populateListView(copy);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var criteria = textBox1.Text.ToLower();
            var filtered = people.PeopleList.FindAll(person => person.ToString().ToLower().Contains(criteria));
            listView1.Items.Clear();
            populateListView(filtered);
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.listView1.Sort();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in listView1.SelectedItems)
            {
                listView1.Items.Remove(selectedItem);
                Person toRemove = people.PeopleList.FirstOrDefault(item => item.Id.Equals(int.Parse(selectedItem.Text)));
                people.PeopleList.Remove(toRemove);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var addNewPersonForm = new Form2())
            {
                var result = addNewPersonForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var person = addNewPersonForm.NewPerson;
                    Person lastPerson = people.PeopleList?.LastOrDefault();
                    int id = 1;
                    if (lastPerson != null)
                    {
                        id = lastPerson.Id + 1;
                    }
                    person.Id = id;
                    people.PeopleList.Add(person);
                    string[] row = { person.Id.ToString(), person.Name, person.Surname, person.Address, person.PhoneNumber.ToString() };
                    listView1.Items.Add(new ListViewItem(row));
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "XML-File | *.xml";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var stream = saveFileDialog1.OpenFile();

                var xmlSerializer = new XmlSerializer(typeof(People));
                xmlSerializer.Serialize(stream, people);
                stream.Close();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XML-File | *.xml";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var schemas = new XmlSchemaSet();
                schemas.Add("", @"../../osoby.xsd");
                var doc = XDocument.Load(openFileDialog1.FileName);
                var validationError = false;
                doc.Validate(schemas, (o, validationEvent) =>
                {
                    validationError = true;
                    MessageBox.Show($"Wybrano nieprawidłowy plik XML\n{validationEvent.Message}", "Nieprawidłowy plik XML",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                });

                if (validationError) return;

                var stream = openFileDialog1.OpenFile();
                var xmlSerializer = new XmlSerializer(typeof(People));
                using (var reader = new StreamReader(stream))
                {
                    people = (People)xmlSerializer.Deserialize(reader);
                }

                copy = new List<Person>(people.PeopleList);
                populateListView(people.PeopleList);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            people.PeopleList = new List<Person>();
            copy = new List<Person>(people.PeopleList);
        }
    }
}