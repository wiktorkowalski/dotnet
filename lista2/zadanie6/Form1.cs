using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace zadanie6
{
    public partial class Form1 : Form
    {
        private ListViewColumnSorter lvwColumnSorter;
        private static List<Person> people = new List<Person>
        {
            new Person(1, "Miriam", "Herrero", "Elche Calle de Argumosa 3247", DateTime.Parse("1959-12-28T13:25:02.798Z")),
            new Person(2, "Mari", "Galema", "Onna De Geerstraat 9339", DateTime.Parse("1950-07-18T22:07:06.977Z")),
            new Person(3, "Cheng", "Van Antwerpen", "Kerkrade Achterheuvel 6582", DateTime.Parse("1981-07-23T11:07:09.448Z")),
            new Person(4, "Deborah", "Riley", "Letterkenny New Street 2763", DateTime.Parse("1959-11-15T17:51:12.215Z")),
            new Person(5, "Édipo", "Gonçalves", "Aparecida de Goiânia Beco dos Namorados 197", DateTime.Parse("1994-11-30T08:40:32.798Z")),
            new Person(6, "Pearl",  "Bishop", "Maitland Green Rd 3354", DateTime.Parse("1997-01-26T06:37:48.184Z")),
            new Person(7, "Aiden", "Montgomery", "Portlaoise Rochestown Road 1855", DateTime.Parse("1989-02-20T18:26:43.627Z")),
            new Person(8, "Alex", "Castillo","Bilbao Calle del Arenal 7823", DateTime.Parse( "1974-05-05T06:41:35.514Z")),
            new Person(9, "Meg", "Geerling",  "Spijkerboor Dr Knibbelallee 2207", DateTime.Parse("1997-04-06T06:09:32.951Z"))
        };
        private static List<Person> copy = new List<Person>(people);
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
                string[] row = { person.Id.ToString(), person.Name, person.Surname, person.Address, person.BirthDate.ToString() };
                ListViewItem listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
            }
            listView1.EndUpdate();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            populateListView(people);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            populateListView(copy);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var criteria = textBox1.Text.ToLower();
            var filtered = people.FindAll(person => person.ToString().ToLower().Contains(criteria));
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
                Person toRemove = people.FirstOrDefault(item => item.Id.Equals(int.Parse(selectedItem.Text)));
                people.Remove(toRemove);
            }
        }
    }
}
