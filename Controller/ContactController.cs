using ContactBookMVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ContactBookMVC.Controller
{
    public class ContactController
    {
        private List<Contact> contactsList { get; set; }
        Singleton singleton = Singleton.GetInstance();
        public ContactController(List<Contact> contactsList)
        {
            this.contactsList = contactsList;
        }
        public ContactController()
        {
            this.contactsList = new List<Contact>();
            //string connStr  = @"Server=localhost\SQLEXPRESS01;Database=ContactBook;Trusted_Connection=True;";
            using (SqlConnection conn = singleton.GetSqlConnection)
            {
                conn.Open();
                string commStr = "SELECT * FROM [Contacts];";
                using (SqlCommand command = new SqlCommand(commStr, conn))
                {
                    SqlDataReader sqlData =  command.ExecuteReader();

                    while (sqlData.Read())
                    {
                        contactsList.Add(new Contact(Convert.ToInt32(sqlData.GetValue(0)), sqlData.GetValue(1).ToString(), sqlData.GetValue(2).ToString(), sqlData.GetValue(3).ToString(), sqlData.GetValue(4).ToString()));
                    }
                }
            }
        }

        public ContactController(ContactController contactController)
        {
            this.contactsList = contactController.GetContacts();
        }

        public void AddContact(Contact contact)
        {
            if (contact != null)
            {
                contact.Id = this.contactsList.Count + 1;
                contactsList.Add(contact);
            }
        }
        public void DeleteContact(Contact contact)
        {
            contactsList.Remove(contact);
        }
        public List<Contact> GetContacts()
        {
            return contactsList;
        }
        public Contact GetById(int id) => contactsList.Where(item => item.Id.Equals(id)).First<Contact>();
    }
}
