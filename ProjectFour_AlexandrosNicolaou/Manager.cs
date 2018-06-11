using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFour_AlexandrosNicolaou
{
    public class Manager:Employee
    {
        public int Salary { get; set; }

        public int Adopt()
        {
            return 12;
        }
        public override int Paycheck()
        {
            this.Salary = 1;
            return this.Salary;
        }
        public override void ClockIn()
        {
            throw new NotImplementedException();
        }
        public override void ShowId()
        {
            throw new NotImplementedException();
        }
    }
}
