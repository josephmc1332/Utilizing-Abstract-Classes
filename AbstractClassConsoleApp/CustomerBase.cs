using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassConsoleApp
{
    public abstract class CustomerBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int IDNumber { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public abstract int GetMonthlyPay();

    }
}
