using ContactBookMVC.Model;
using ContactBookMVC.View;
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
    public partial class ContactControl : UserControl
    {
        public Contact contact { get; set; }
        public delegate void DropEvent(Contact contact);
        public DropEvent dropEvent;

        public ContactControl()
        {
            InitializeComponent();
        }
        public ContactControl(Contact _contact)
        {
            InitializeComponent();
            contact = _contact;
            this.label1.Text = _contact.Name;
            this.label2.Text = _contact.Surname;
        }

        private void ContactControl_Load(object sender, EventArgs e)
        {
        }

        private void ContactControl_Click(object sender, EventArgs e)
        {
            ViewContactForm viewContactForm = new ViewContactForm(this.contact,contact.Id,contact.Name, contact.Surname,contact.Address,contact.Number);
            viewContactForm.dropEvent += DropItem;
            viewContactForm.ShowDialog();
            this.contact = viewContactForm.oldContact;
            this.label1.Text = viewContactForm.oldContact.Name;
            this.label2.Text = viewContactForm.oldContact.Surname;
        }
        void DropItem(Contact contact)
        {
            dropEvent?.Invoke(this.contact);
        }
    }
}
