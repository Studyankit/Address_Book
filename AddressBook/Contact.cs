﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    class Contact
    {
        // variables
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string zipCode;
        public string phoneNumber;
        public string email;
        //// constructor that gets user detail and store it in the current object.
        public Contact(string firstName, string lastName, string address, string city, string state, string zipCode, string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
        /// <summary>
        /// To display the contact details.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("First Name:{0}", this.firstName);
            Console.WriteLine("Last Name:{0}", this.lastName);
            Console.WriteLine("Address:{0}", this.address);
            Console.WriteLine("City: {0}", this.city);
            Console.WriteLine("State:{0}", this.state);
            Console.WriteLine("Zipcode:{0}", this.zipCode);
            Console.WriteLine("Phone number:{0}", this.phoneNumber);
            Console.WriteLine("Email ID:{0}", this.email);
        }
    }
}