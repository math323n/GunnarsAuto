using System;
using System.Collections.Generic;
using System.Text;

namespace GunnarsAuto
{
    public class SalesPerson
    {
        private int id;
        private string firstName;
        private string lastName;
        private string initials;


        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public string Initials
        {
            get
            {
                return initials;
            }
            set
            {
                initials = value;
            }

        }

        public SalesPerson(int id, string firstName, string lastName, string initials)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Initials = initials;
        }


    }
}
