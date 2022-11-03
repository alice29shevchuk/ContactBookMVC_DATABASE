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
    public partial class ViewContactUserControl : UserControl
    {
        public ViewContactUserControl()
        {
            InitializeComponent();
        }
        public string GetName()
        {
            return this.name_surnameLB.Text;
        }
        public string GetAddress()
        {
            return this.textBox1.Text;
        }
        public List<string> GetNumber()
        {
            List<string> items = new List<string>();
            foreach (var item in listBox1.Items)
            {
                items.Add(item.ToString());
            }
            return items;
        }
        public void SetNameSurname(string name,string surname)
        {
            this.name_surnameLB.Text = $"{name} {surname}";
        }
        public void SetAddress(string address)
        {
            this.textBox1.Text = address;
        }
        public void SetNumber(string numb)
        {
            this.listBox1.Items.Clear();
            this.listBox1.Items.Add(numb);
        }
    }
}
