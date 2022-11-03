using ContactBookMVC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactBookMVC.Controller
{
    public partial class ListContactsControl : UserControl
    {
        public ContactController contactController;
        public ListContactsControl(ContactController _contactController)
        {
            InitializeComponent();
            this.contactController = _contactController;
           
        }
        public ListContactsControl()
        {
            InitializeComponent();
        }
        private void startSearchBTN_Click(object sender, EventArgs e)
        {
            if (RightGoCB.Checked != true)
            {
                GenerateView(this.contactController.GetContacts().Where(i => i.Name.ToLower().Contains(searchTB.Text.ToLower())).ToList());
            }
            else
            {
                GenerateView(this.contactController.GetContacts().Where(i => i.Name.ToLower().Equals(searchTB.Text.ToLower())).ToList());
            }
        }
        public void GenerateView(List<Contact> contacList)
        {
            panel1.Controls.Clear();
            int x = 0;
            foreach (Contact item in contacList)
            {
                ContactControl tmp = new ContactControl(item);
                tmp.Location = new Point(0, x);
                tmp.dropEvent += ItemDelete;
                panel1.Controls.Add(tmp);
                x += tmp.Size.Height+5;
            }
        }

        private void ListContactsControl_Load(object sender, EventArgs e)
        {
            GenerateView(contactController.GetContacts());
        }

        private void searchTB_TextChanged(object sender, EventArgs e)
        {
            if(searchTB.Text==string.Empty)
            {
                GenerateView(contactController.GetContacts());
            }
            else
            {
                if (RightGoCB.Checked != true)
                {
                    GenerateView(this.contactController.GetContacts().Where(i => i.Name.ToLower().Contains(searchTB.Text.ToLower())).ToList());
                }
                else
                {
                    GenerateView(this.contactController.GetContacts().Where(i => i.Name.ToLower().Equals(searchTB.Text.ToLower())).ToList());
                }
            }
        }

        private void searchTB_Click(object sender, EventArgs e)
        {
            this.searchTB.Text = string.Empty;
        }

       private void ItemDelete(Contact contact)
        {
            contactController.DeleteContact(contact);   
            GenerateView(this.contactController.GetContacts());
        }
    }
}
