using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookMVC.Model
{
    public class Contact
    {
        public Contact(int id,string name, string surname, string address, string number)
        {
            Name = name;
            Surname = surname;
            Address = address;
            Number = number;
            Id = id;
        }
        public Contact(string name, string surname, string address, string number)
        {
            Name = name;
            Surname = surname;
            Address = address;
            Number = number;
        }
        public Contact()
        {
            Name = string.Empty;
            Surname = string.Empty;
            Address = string.Empty;
            Number = string.Empty;
            Id = 0;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public int Id { get; set; }
        public string Number { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}",this.Name,this.Surname);
        }
        public string GetInfoContact()
        {
            string s = String.Format("{0}|{1} {2}|{3}|{4}", this.Id, this.Name, this.Surname, this.Address,this.Number);
            return s;
        }
    }
}
