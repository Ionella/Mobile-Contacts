using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Contacts
{
    public class Contact
    {
        public enum StatusContact
        { active,
          inactive
        }

         public struct Person
        { 
            public string firstName;
            public string lastName;
            public string number;
            public StatusContact status ;

            public void DisplayContact()
            { 
            Console.WriteLine(firstName+" "+lastName+" "+number+" "+status);
            }

            public void DisplayContact(Person person)
            {
                Console.WriteLine(person.firstName + " " + person.lastName + " " + person.number + " " + person.status);
            }

            public static Person AddContact()
            { 
            Person person = new Person();
               
            Console.WriteLine("Enter the First Name of the person:");
            person.firstName = Console.ReadLine();

            Console.WriteLine("Enter the Last Name of the person:");
            person.lastName = Console.ReadLine();

            Console.WriteLine("Enter the Phon Number of the person:");
            person.number = Console.ReadLine();

            Console.WriteLine("Enter the Status of the person: 1-active/ 0-inactive");
            int chose = int.Parse(Console.ReadLine());
                if ( chose == 0 )
                {
                    person.status = StatusContact.inactive;
                }
                else if ( chose == 1 ) 
                {
                    person.status = StatusContact.active;
                }
                else
                {
                    Console.WriteLine("Invalide chose.");
                }

                return person;   
            } 
        }
    }
}
