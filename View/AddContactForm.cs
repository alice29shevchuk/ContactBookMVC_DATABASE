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
using System.Data.SqlClient;

namespace ContactBookMVC.View
{
    public partial class AddContactForm : Form
    {
        public Contact contact { get; set; }
        public List<Contact> contacts;
        Singleton singleton = Singleton.GetInstance();
        public AddContactForm(List<Contact> _contacts)
        {
            InitializeComponent();
            this.contacts = _contacts;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contact = new Contact(this.nameTB.Text, this.surnameTB.Text, this.addressTB.Text, this.numberTB.Text);
            //string connStr = @"Server=localhost\SQLEXPRESS01;Database=ContactBook;Trusted_Connection=True;";
            using (SqlConnection conn = singleton.GetSqlConnection)
            {
                conn.Open();

                using (SqlCommand command = new SqlCommand($"INSERT INTO [dbo].[Contacts]([Name],[Surname],[Address],[PhoneNumber]) VALUES(\'{this.nameTB.Text}\',\'{this.surnameTB.Text}\',\'{this.addressTB.Text}\',\'{this.numberTB.Text}\');", conn))
                {
                    if (command.ExecuteNonQuery() > 0)
                    {
                        this.Close();
                    }
                }
            }
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
