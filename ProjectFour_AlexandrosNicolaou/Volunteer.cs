using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFour_AlexandrosNicolaou
{
    public class Volunteer:Employee
    {
        public int WaterAll()
        {
            return 11;
        }
        public int FeedAll()
        {
            return 10;
        }
        public override int Paycheck()
        {
            return 0;
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
