using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10AddressBookSystem
{
    public class AddressBookSystem
    {
        public static List<Person> People = new List<Person>();
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string email { get; set; }
            public string phoneNumber { get; set; }
        }

        //Add Contact in address book
        public static void CreateContact()
        {
            char choice;
            Console.WriteLine("Do u want to add new contact (Y/N) :");
            choice = Convert.ToChar(Console.ReadLine());
            while (choice == 'Y' || choice == 'Y')
            {
                bool exist = false;
                Person person = new Person();

                Console.Write("Enter First Number :");
                person.FirstName = Console.ReadLine();
                Console.Write("Enter Last Number :");
                person.LastName = Console.ReadLine();
                Console.Write("Enter Address :");
                person.Address = Console.ReadLine();
                Console.Write("Enter City :");
                person.City = Console.ReadLine();
                Console.Write("Enter State :");
                person.State = Console.ReadLine();
                Console.Write("Enter Zip :");
                person.Zip = Console.ReadLine();
                Console.Write("Enter email :");
                person.email = Console.ReadLine();
                Console.Write("Enter phoneNumber :");
                person.phoneNumber = Console.ReadLine();

                foreach (var per in People.ToList())
                {
                    if (per.FirstName == person.FirstName && per.LastName == person.LastName)
                    {
                        exist = true;
                        Console.WriteLine("contact arleady present");
                    }

                }
                if (exist == false)
                {
                    People.Add(person);
                }
                Console.WriteLine("Do u Want to add New Contact (Y/N) :");
                choice = Convert.ToChar(Console.ReadLine());
            }
        }
        public static void PrintContacts(Person person)
        {
            Console.WriteLine("First Name :" + person.FirstName);
            Console.WriteLine("Last Name :" + person.LastName);
            Console.WriteLine("Address  :" + person.Address);
            Console.WriteLine("City : " + person.City);
            Console.WriteLine("State :" + person.State);
            Console.WriteLine("Zip :" + person.Zip);
            Console.WriteLine("email :" + person.email);
            Console.WriteLine("Phone Number :" + person.phoneNumber);

        }
    }
}






        