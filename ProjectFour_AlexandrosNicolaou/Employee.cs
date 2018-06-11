using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFour_AlexandrosNicolaou
{
    public abstract class Employee
    {
       
        public int Food { get; set; }
        public int Cage { get; set; }
        public int Toy { get; set; }
        public int GetPaid { get; set; }

        public Employee()
        {
            //default
        }
        public Employee(int food, int cage, int toy, int getPaid)
        {
            this.Food=food;
            this.Cage = cage;
            this.Toy = toy;
            this.GetPaid = getPaid;
        }


        public int Feed()
        {
            return 1;
        }
        public int PutAway()
        {
            return 2;
        }
        public int Play()
        {
            return 3;
        }
        public virtual int Paycheck()
        {
            return GetPaid;
        }


        public abstract void ClockIn();
        public abstract void ShowId();
    }
}
