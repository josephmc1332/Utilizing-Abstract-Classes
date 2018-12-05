using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassConsoleApp
{
    public class ContractEmployee : CustomerBase
    {
        public int HoursPerMonth { get; set; }
        public int PayPerHour { get; set; }

        public override int GetMonthlyPay()
        {
            return PayPerHour * HoursPerMonth;
        }
    }
}
