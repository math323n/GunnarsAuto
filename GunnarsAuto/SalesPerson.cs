using System;
using System.Collections.Generic;
using System.Text;

namespace GunnarsAuto
{
    public class SalesPerson
    {
        private string firstName;
        private string lastName;
        private string initials;

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

        public SalesPerson(string firstName, string lastName, string initials)
        {
            FirstName = firstName;
            LastName = lastName;
            Initials = initials;
        }


    }
}
