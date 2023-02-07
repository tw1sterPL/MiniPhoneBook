using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Phone.BL
{
    public class Contact
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string NameSurname
        {
            get
            {
                string nameSurname = Name;
                if (!string.IsNullOrEmpty(Surname))
                {
                    if (!string.IsNullOrEmpty(nameSurname))
                    {
                        nameSurname += ", ";
                    }
                    nameSurname += Surname;
                }
                return nameSurname;
            }
        }


        public bool IsValidPhoneNumber(string phoneNumber)
        {
            var pattern = @"^\+\d{2}\s\d{3}\s\d{3}\s\d{3}$";
            var match = Regex.Match(phoneNumber, pattern);
            return match.Success;
        }
        public bool Validate()
        {
            var valid = true;
            if (string.IsNullOrEmpty(Name)) valid = false;
            if (string.IsNullOrEmpty(Surname)) valid = false;
            if (string.IsNullOrEmpty(PhoneNumber))
            {
                if (!string.IsNullOrEmpty(PhoneNumber))
                {
                    IsValidPhoneNumber(PhoneNumber);
                }
                valid = false;
            }
            return valid;
        }
    }
}
