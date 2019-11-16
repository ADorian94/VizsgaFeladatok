using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefonkonyv
{
    public partial class Form1 : Form
    {
        private List<Person> _contacts;

        public Form1()
        {
            InitializeComponent();
            _contacts = new List<Person>();
            DeleteButton.Enabled = false;
            EditButton.Enabled = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(NameBox.Text != string.Empty && NameBox.Text != null 
                && PhoneNumberBox.Text != string.Empty && PhoneNumberBox.Text != null)
            {
                _contacts.Add(new Person(NameBox.Text, PhoneNumberBox.Text));
                ContactBox.Items.Add(NameBox.Text);
                ContactBox.Sorted = true;

                NameBox.Text = string.Empty;
                PhoneNumberBox.Text = string.Empty;
            }
        }

        private void Click(object sender, MouseEventArgs e)
        {
            int index = this.ContactBox.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                NameBox.Text = _contacts[index].GetName();
                PhoneNumberBox.Text = _contacts[index].GetPhoneNumber();
                DeleteButton.Enabled = true;
                EditButton.Enabled = true;
            }
        }

        private void ContactBox_Leave(object sender, EventArgs e)
        {
            NameBox.Text = string.Empty;
            PhoneNumberBox.Text = string.Empty;
            DeleteButton.Enabled = false;
            EditButton.Enabled = false;
        }
    }
}
