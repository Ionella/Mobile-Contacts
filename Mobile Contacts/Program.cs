using Mobile_Contacts;
using System;
using System.Threading.Tasks.Dataflow;

namespace Mobile;

class Program
{
    static void Main(string[] args)
    {
        bool exitMenu = true;

        Service obj = new Service();

        while (exitMenu) 
        {
            Console.WriteLine("===========MENU============");
            Console.WriteLine("1.Record contacts from memory ");
            Console.WriteLine("2.Display all contacts ");
            Console.WriteLine("3.Edit contact ");
            Console.WriteLine("4.Search contact ");
            Console.WriteLine("5.Delete contact ");
            Console.WriteLine("6.Exit menu ");
            Console.WriteLine("===========================");
            Console.WriteLine("Select option:");

            int userChose = int.Parse(Console.ReadLine());

            if (userChose == 1)
            {
                obj.RecordContact();
            }
            else if (userChose == 2)
            {
                obj.DisplayContact();
            }
            else if (userChose == 3)
            {
                obj.DisplayContact();
                obj.EditContact();
            }
            else if (userChose == 4)
            {
                Console.WriteLine("===========MENU SEARCH============");
                Console.WriteLine("1.Search by First name ");
                Console.WriteLine("2.Search by Last name ");
                Console.WriteLine("3.Search by Phone Number ");
                Console.WriteLine("==================================");
                Console.WriteLine("Select option:");
           
                int userChoseSearch = int.Parse(Console.ReadLine());

                if (userChoseSearch == 1)
                { 
                    obj.SearchContactByFirstName();
                }
                else if (userChoseSearch == 2)
                {
                    obj.SearchContactByLastName();
                }
                else if (userChoseSearch == 3)
                {
                    obj.SearchContactByNumber();
                }
                else
                { Console.WriteLine("Invalide chose."); }
            }
            else if (userChose == 5)
            {
                obj.DisplayContact();
                obj.DeleteContact();
            }
            else if (userChose == 6)
            {
                exitMenu = false;
            }
            else
            { Console.WriteLine("Invalide chose."); }
        }
    }
}

