using ContactBookMVC.Controller;
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

namespace ContactBookMVC.View
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            Application.ApplicationExit+=new EventHandler(this.AppClose);

        }
        private void AppClose(object sender,EventArgs e)
        {
            writeReadController.Write(contactController.GetContacts());
        }
        private void addContactLB_Click(object sender, EventArgs e)
        {
            AddContactForm addContactForm = new AddContactForm(contactController.GetContacts());
            addContactForm.ShowDialog();
            this.contactController.AddContact(addContactForm.contact);
            this.listContactsControl1.GenerateView(contactController.GetContacts());
            writeReadController.Write(contactController.GetContacts());
        }
    }
}
