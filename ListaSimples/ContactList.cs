
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class ContactList
    {
        Contact? head;
        Contact? tail;

        public ContactList()
        {
            this.head = null;
            this.tail = null;
        }

        public void Add(Contact contact)
        {
            if (isEmpty())
            {
                this.head = contact;
                this.tail = contact;
            }
            else
            {
                int compare = string.Compare(contact.getName(), head.getName(), comparisonType: StringComparison.OrdinalIgnoreCase);
                if (compare <= 0)
                {
                    Contact aux = head;
                    head = contact;
                    head.setNext(aux);
                }
                else
                {
                    Contact aux = head;
                    Contact prev = head;

                    do
                    {
                        compare = string.Compare(contact.getName(), aux.getName());
                        if (compare > 0)
                        {
                            prev = aux;
                            aux = aux.getNext();
                        }

                    } while (aux != null && compare > 0);

                    prev.setNext(contact);
                    contact.setNext(aux);
                    if (aux == null)
                        tail = contact;
                }
            }
        }

        bool isEmpty()
        {
            if (this.head == null && this.tail == null)
                return true;
            else
                return false;
        }

        public void RemoveByName(string name)
        {
            if (!isEmpty())
            {
                if (name == this.head.getName())
                {
                    if (head == tail)
                        tail = head = null;
                    else
                    {
                        head = head.getNext();
                    }
                }
                else
                {
                    Contact aux = head;
                    Contact prev = head;
                    bool compare;
                    do
                    {
                        compare = name.Equals(aux.getName());
                        if (!compare)
                        {
                            prev = aux;
                            aux = aux.getNext();
                        }
                        else
                        {
                            prev.setNext(aux.getNext());
                            if (prev.getNext() == null)
                                tail = prev;
                        }

                    } while (compare == false && aux != null);

                    if (aux == null)
                    {
                        Console.WriteLine("Não existe o contato na lista.");
                    }
                }
            }
        }

        public void ShowAll()
        {
            Contact aux = head;
            do
            {
                Console.WriteLine(aux.ToString());
                aux = aux.getNext();
            } while (aux != null);
        }
    }
}