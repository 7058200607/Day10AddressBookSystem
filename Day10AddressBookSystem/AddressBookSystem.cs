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
        public static void Modify()
        {
            if (People.Count != 0)
            {
                char choice;
                Console.WriteLine("Do u want to modify Contact (Y/N) :");
                choice = Convert.ToChar(Console.ReadLine());
                while (choice == 'y' || choice == 'Y')
                {
                    Console.WriteLine("Enter a first name to modify : ");
                    string Modified = Console.ReadLine();
                    bool exist = false;
                    foreach (var person in People)
                    {
                        if (person.FirstName.ToUpper() == Modified.ToUpper())
                        {
                            exist = true;
                            Console.WriteLine("choose the field to modify ");
                            Console.WriteLine("Enter 1 to change First Name ");
                            Console.WriteLine("Enter 2 to change Last Name ");
                            Console.WriteLine("Enter 3 to change  Address ");
                            Console.WriteLine("Enter 4 to change  City ");
                            Console.WriteLine("Enter 5 to change  State ");
                            Console.WriteLine("Enter 6 to change  Zip ");
                            Console.WriteLine("Enter 7 to change  email ");
                            Console.WriteLine("Enter 8 to change  Phone Number ");
                            string check = (Console.ReadLine());
                            switch (check)
                            {
                                case "0":
                                    Console.WriteLine("Enter First Number :");
                                    person.FirstName = Console.ReadLine();
                                    break;
                                case "1":
                                    Console.WriteLine("Enter Last Number :");
                                    person.LastName = Console.ReadLine();
                                    break;
                                case "2":
                                    Console.WriteLine("Enter Address :");
                                    person.Address = Console.ReadLine();
                                    break;
                                case "3":
                                    Console.WriteLine("Enter city");
                                    person.City = (Console.ReadLine());
                                    break;
                                case "4":
                                    Console.WriteLine("enter state");
                                    person.State = (Console.ReadLine());
                                    break;
                                case "5":
                                    Console.WriteLine("Enter zip");
                                    person.email = (Console.ReadLine());
                                    break;
                                case "6":
                                    Console.WriteLine(" Enter a email");
                                    person.FirstName = (Console.ReadLine());
                                    break;
                                case "7":
                                    Console.WriteLine("Enter Phone Nmuber");
                                    person.phoneNumber = (Console.ReadLine());
                                    break;
                                default:
                                    Console.WriteLine("Enter Valid Choice");
                                    break;

                            }
                        }

                    }
                    if (exist == false)
                    {
                        Console.WriteLine("Enter Valid Name ");
                    }
                    Console.WriteLine("Do you want to modify contact (Y/N) : ");
                    choice = Convert.ToChar(Console.ReadLine());
                }
            }
        }
        public static void Delete()
        {
            if (People.Count != 0)
            {
                char choice;
                Console.WriteLine("\n Do you wish to delete Contact ? (Y/N) :");
                choice = Convert.ToChar(Console.ReadLine());
                while (choice == 'y' || choice == 'Y')
                {
                    Console.WriteLine("\n Enter a first name of contact to delete : ");
                    string remove = Console.ReadLine();
                    bool exist = false;
                    foreach (var person in People.ToList())
                    {
                        if (person.FirstName.ToUpper() == remove.ToUpper())
                        {
                            exist = true;

                            Console.WriteLine("choose the field to remove ");
                            Console.WriteLine("Enter 1 to change First Name ");
                            Console.WriteLine("Enter 2 to change Last Name ");
                            Console.WriteLine("Enter 3 to change  Address ");
                            Console.WriteLine("Enter 4 to change  City ");
                            Console.WriteLine("Enter 5 to change  State ");
                            Console.WriteLine("Enter 6 to change  Zip ");
                            Console.WriteLine("Enter 7 to change  email ");
                            Console.WriteLine("Enter 8 to change  Phone Number ");
                            string check = (Console.ReadLine());
                            switch (check)
                            {
                                case "0":
                                    Console.WriteLine("Enter First Number :");
                                    person.FirstName = Console.ReadLine();
                                    break;
                                case "1":
                                    Console.WriteLine("Enter Last Number :");
                                    person.LastName = Console.ReadLine();
                                    break;
                                case "2":
                                    Console.WriteLine("Enter Address :");
                                    person.Address = Console.ReadLine();
                                    break;
                                case "3":
                                    Console.WriteLine("Enter city");
                                    person.City = (Console.ReadLine());
                                    break;
                                case "4":
                                    Console.WriteLine("enter state");
                                    person.State = (Console.ReadLine());
                                    break;
                                case "5":
                                    Console.WriteLine("Enter zip");
                                    person.email = (Console.ReadLine());
                                    break;
                                case "6":
                                    Console.WriteLine(" Enter a email");
                                    person.FirstName = (Console.ReadLine());
                                    break;
                                case "7":
                                    Console.WriteLine("Enter Phone Nmuber");
                                    person.phoneNumber = (Console.ReadLine());
                                    break;
                                default:
                                    Console.WriteLine("Enter Valid Choice");
                                    break;

                            }
                        }

                    }
                    if (exist == false)
                    {
                        Console.WriteLine("Contact dosent exist ");
                    }
                    Console.WriteLine("Do you want to delete contact (Y/N) : ");
                    choice = Convert.ToChar(Console.ReadLine());
                }
            }
        }
    }
}



        