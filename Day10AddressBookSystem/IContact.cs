﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10AddressBookSystem
{
    interface IContact
    {
        List<Contact> AddNewContact();
        void ViewContact();
        void EditContact(string input);
        void DeleteContact(string fName, string lName);
        void AddNewAddressBook();
    }
}
