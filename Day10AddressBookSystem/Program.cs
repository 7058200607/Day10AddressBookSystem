using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10AddressBookSystem 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=-=-=-=-=-=-=-=Welcome to address book system=-=-=-=-=-=-=-=");

            AddressBook addressBook = new AddressBook();

            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. View Contact :");
            Console.WriteLine("2.Add new Contact :");
            Console.WriteLine("3. Edit Contact:");
            Console.WriteLine("4.Delete Contact:");
            Console.WriteLine("5.Add Multiple Addressbook");
            Console.WriteLine("6.To find a person in state or city:");
            Console.WriteLine("7.To view a person in state or city:");
            Console.WriteLine("8.to Count by City or State:");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    addressBook.ViewContact();
                    break;
                case 2:
                    addressBook.AddNewContact();
                    addressBook.ViewContact();
                    break;
                case 3:
                    Console.WriteLine("\nEnter First name to edit it's contact details");
                    string input = Console.ReadLine();
                    addressBook.EditContact(input);
                    addressBook.ViewContact();
                    break;
                case 4:
                    Console.WriteLine("\nEnter First name to delete it's contact details");
                    string fName = Console.ReadLine();
                    Console.WriteLine("Enter last name to delete it's contact details");
                    string lName = Console.ReadLine();
                    addressBook.DeleteContact(fName, lName);
                    addressBook.ViewContact();
                    break;
                case 5:
                    addressBook.AddNewAddressBook();
                    addressBook.ViewContact();
                    break;
                case 6:
                    addressBook.SearchPersonInCityOrState();
                    break;
                case 7:
                    addressBook.ViewPersonInCityOrState();
                    break;
                case 8:
                    addressBook.AddNewAddressBook();
                    addressBook.CountByCityOrState();
                    break;


            }
        }
    }
}

