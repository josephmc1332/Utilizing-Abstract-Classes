using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassConsoleApp
{
    public class FullTimeEmployee : CustomerBase
    {
        public int SalaryAnnual { get; set; }

        public override int GetMonthlyPay()
        {
            return SalaryAnnual / 12;
        }
    }
}
