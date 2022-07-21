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
            Console.WriteLine(" Welcome to Address Book Program");
          AddressBookSystem.CreateContact();
            AddressBookSystem.Modify();
            AddressBookSystem.Delete();
            AddressBookSystem.ContactList();
        }
    }
}
