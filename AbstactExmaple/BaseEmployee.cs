using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactExmaple
{
    public abstract class BaseEmployee 
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }


        public string GetFullName()
        {
            return this.FirstName + String.Empty + LastName;
        }
        public abstract int GetMonthlySalary();
    }
}
