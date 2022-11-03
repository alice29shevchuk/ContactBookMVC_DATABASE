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
using System.Data.SqlClient;

namespace ContactBookMVC.View
{
    public partial class ViewContactForm : Form
    {

        public Contact contact { get; set; }
        public delegate void DropEvent(Contact contact);
        public DropEvent dropEvent;
        public int idDell;
        public Contact oldContact;

        public ViewContactForm(Contact _contact,int id,string name,string surname,string address,string numb)
        {
            InitializeComponent();
            this.idDell = id;
            this.userControl.SetNameSurname(name,surname);
            this.userControl.SetAddress(address);
            this.userControl.SetNumber(numb);
            this.contact = new Contact(name, surname, address, numb);
            this.oldContact = _contact;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Contact GetDeleteContact()
        {
            return this.contact;
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы действительно хотите удалить контакт?","Удаление",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                dropEvent?.Invoke(contact);
                string connStr = @"Server=localhost\SQLEXPRESS01;Database=ContactBook;Trusted_Connection=True;";
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand($"DELETE [Contacts] WHERE Id = {this.idDell}", conn))
                    {
                        if (command.ExecuteNonQuery() > 0)
                        {
                            this.Close();
                        }
                    }
                }
            }
        }

        private void editBTN_Click(object sender, EventArgs e)
        {
            EditWindow editWindow = new EditWindow(this.contact.Name, this.contact.Surname, this.contact.Address, this.contact.Number);
            editWindow.ShowDialog();
            if (editWindow.GetinfoButtonOk())
            {
                Contact tempContact = editWindow.GetEditContact();
                this.userControl.SetNameSurname(tempContact.Name, tempContact.Surname);
                this.userControl.SetAddress(tempContact.Address);
                this.userControl.SetNumber(tempContact.Number);
                this.oldContact = tempContact;
                string connStr = @"Server=localhost\SQLEXPRESS01;Database=ContactBook;Trusted_Connection=True;";
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    //MessageBox.Show(tempContact.Name+"|"+ this.idDell);
                    using (SqlCommand command = new SqlCommand($"UPDATE [Contacts] SET [Name] = \'{tempContact.Name}\',[Surname] = \'{tempContact.Surname}\',[Address] = \'{tempContact.Address}\',[PhoneNumber] = \'{tempContact.Number}\' WHERE Id = {this.idDell}", conn))
                    {
                        if (command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Удачно обновлено!");
                        }
                    }
                }
            }
            
        }
    }
}
