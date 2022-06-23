using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitCardAssignment
{
    public class Validate
    {
        public bool ValidatePin(string pin)
        {
            if (CheckPinLength(pin))
            {
                return CheckForNumbers(pin);
            }
            return false;
        }

        private bool CheckPinLength(string pin)
        {
            if (pin.Count() == 4)
            {
                return true;
            }
            return false;
        }

        public bool ValidateCardnumber(string cardnumber, string pin)
        {
            if (CheckCardnumberLength(cardnumber))
            {
                return CheckForNumbers(cardnumber);
            }
            return false;
        }

        private bool CheckCardnumberLength(string cardnumber)
        {
            if (cardnumber.Count() == 16)
            {
                return true;
            }
            return false;
        }

        private bool CheckForNumbers(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
