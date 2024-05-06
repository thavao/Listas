using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Contact
    {
        string name;
        string phone;

        Contact next;

        public Contact(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public string getName()
        {
            return name;
        }

        public void setNext(Contact c)
        {
            this.next = c;
        }

        public Contact getNext()
        {
            return this.next;
        }
    }
}