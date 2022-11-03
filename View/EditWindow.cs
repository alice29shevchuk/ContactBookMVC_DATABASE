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
    public partial class EditWindow : Form
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string Number { get; set; }
        public bool isButtonok;
        public Contact editContact;
        public EditWindow()
        {
            InitializeComponent();
        }
        public EditWindow(string name,string surname,string address,string number):this()
        {
            this.Name = name;
            this.Surname = surname;
            this.Address = address;
            this.Number = number;
            this.isButtonok = false;
            SetContactInformation();
        }
        public void ShowInfoContactInformation()
        {
            MessageBox.Show($"Name: {this.Name}| Surname: {this.Surname}| Address:{this.Address}| Number:{this.Number}");
        }
        public void SetContactInformation()
        {
            this.textBox1.Text = this.Name;
            this.textBox4.Text = this.Surname;
            this.textBox2.Text = this.Address;
            this.textBox3.Text = this.Number;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.isButtonok = true;
            editContact = new Contact(this.textBox1.Text, this.textBox4.Text, this.textBox2.Text, this.textBox3.Text);
            this.Close();
        }
        public Contact GetEditContact()
        {
            return this.editContact;
        }
        public bool GetinfoButtonOk()
        {
            return this.isButtonok;
        }
    }
}
