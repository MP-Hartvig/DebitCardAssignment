using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitCardAssignment
{
    public class Account
    {
        public double Subtract(double x, double y)
        {
            if (x - y > double.MinValue)
            {
                return x - y;
            }
            else
            {
                return 0;
            }
        }
    }
}
