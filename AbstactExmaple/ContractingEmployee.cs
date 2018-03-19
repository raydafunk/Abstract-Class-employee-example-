using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactExmaple
{
   public class ContractingEmployee : BaseEmployee
    {
       

        public int HourlyPay { get; set; }

        public int TotalHours  { get; set; }

        public override int GetMonthlySalary()
        {
            return this.TotalHours * this.HourlyPay;
        }
    }
}
