using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Mobile_Contacts.Contact;

namespace Mobile_Contacts
{
    public class Service
    {
        Contact.Person[] contacts = new Contact.Person[5];

        public void RecordContact()
        { 
           /* for (int i = 0; i < contacts.Length; i++)
            {
            Console.WriteLine("Nr." + (i+1));
            contacts[i] = Contact.Person.AddContact();
            }*/

        Contact.Person person1 = new Contact.Person();
            person1.firstName = "Gutu";
            person1.lastName = "Ionela";
            person1.number = "060996633";
            person1.status = StatusContact.active;

            Contact.Person person2 = new Contact.Person();
            person2.firstName = "Sirbu";
            person2.lastName = "Ion";
            person2.number = "069355023";
            person2.status = StatusContact.active;

            Contact.Person person3 = new Contact.Person();
            person3.firstName = "Ou";
            person3.lastName = "Andreea";
            person3.number = "067698002";
            person3.status = StatusContact.inactive;

            Contact.Person person4 = new Contact.Person();
            person4.firstName = "Pavel";
            person4.lastName = "David";
            person4.number = "067666999";
            person4.status = StatusContact.active;

            Contact.Person person5 = new Contact.Person();
            person5.firstName = "Marin";
            person5.lastName = "Alexandru";
            person5.number = "067698015";
            person5.status = StatusContact.active;

            contacts[0] = person1;
            contacts[1] = person2;
            contacts[2] = person3;
            contacts[3] = person4;
            contacts[4] = person5;
        }

        public void DisplayContact()
        {
            int counter = 1;
            for (int i = 0; i < contacts.Length; i++)
            {
                Console.Write(counter + ".  ");
                contacts[i].DisplayContact();  
                counter++;
            }
            
        }

        public void SearchContactByFirstName() 
        {
            Contact.Person searchPerson = new Contact.Person(); 

            Console.WriteLine("For search person, enter the First Name: ");
            string searchName = Console.ReadLine();

            int counter = 1;

            for (int i = 0; i < contacts.Length; i++)

            {
                if (contacts[i].firstName == searchName)
                {
                    searchPerson = contacts[i];
                    Console.Write(counter + ".  " );
                    DisplayPersonPrivat(searchPerson);
                    counter++;
                }   
            }
        }

        public void SearchContactByLastName()
        {
            Contact.Person searchPerson = new Contact.Person();

            Console.WriteLine("For search person, enter the Last Name: ");
            string searchName = Console.ReadLine();

            int counter = 1;

            for (int i = 0; i < contacts.Length; i++)


            {
                if (contacts[i].lastName == searchName)
                {
                    searchPerson = contacts[i];
                    Console.Write(counter + ".  " );
                    DisplayPersonPrivat(searchPerson);
                    counter++;
                }
            }
        }

        public void SearchContactByNumber()
        {
            Console.WriteLine("For search person, enter the numbers you know from the Phone Number: ");
            string numbersPhone = Console.ReadLine();

            int counter = 1;

            for (int i = 0; i < contacts.Length; i++)
            {
                if (contacts[i].number.Contains(numbersPhone))
                {
                    Console.Write(counter + ".  ");
                    DisplayPersonPrivat(contacts[i]);
                    counter++;
                }
            }
        }

        private void DisplayPersonPrivat(Person myPerson)
        {
            Console.WriteLine(myPerson.firstName + " " +
                              myPerson.lastName + " " +
                              myPerson.number + " " +
                              myPerson.status);

        }
        public void EditContact()
        { 
            Console.WriteLine("For Edit the contact, enter the order number from the displayed list: ");
            int orderNumber = int.Parse(Console.ReadLine());

            if (orderNumber < 0 || orderNumber > contacts.Length)
            {
                Console.WriteLine("Invalide chose.");
            }
            else
            {
                DisplayPersonPrivat(contacts[orderNumber-1]);

                Console.WriteLine("For Edit the contact, choose:\n" +
                    "1 - edit First Name\n" +
                    "2 - edit Last Name\n" +
                    "3 - edit number contact\n");
                int userChoose = int.Parse(Console.ReadLine());

                if (userChoose == 1)
                {
                    Console.WriteLine("Enter the NEW First Name:");
                    contacts[orderNumber - 1].firstName = Console.ReadLine();
                }
                else if (userChoose == 2)
                {
                    Console.WriteLine("Enter the NEW Last Name:");
                    contacts[orderNumber - 1].lastName = Console.ReadLine();
                }
                else if (userChoose == 3)
                {
                    Console.WriteLine("Enter the NEW Phone Number:");
                    contacts[orderNumber - 1].number = Console.ReadLine();
                }
                else
                { Console.WriteLine("Invalide chose.");}

                Console.WriteLine("The edited person is:"); 
                DisplayPersonPrivat(contacts[orderNumber - 1]);

            }

        }

        public void DeleteContact()
        { 
            Console.WriteLine("For Delete the contact,enter the order number from the displayed list: ");
            int orderNumber = int.Parse(Console.ReadLine());

            for (int i = orderNumber - 1; i < contacts.Length - 1; i++)
            {
                contacts[i] = contacts[i + 1];
            }

            Array.Resize(ref contacts, contacts.Length - 1);

            Console.WriteLine("The New LIST is: ");
            int counter = 1;

            for (int i = 0; i < contacts.Length; i++)
            {
                Console.Write(counter + ".  ");
                contacts[i].DisplayContact();
                counter++;
            }
        }
    }
}
