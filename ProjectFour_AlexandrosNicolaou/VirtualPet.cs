using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFour_AlexandrosNicolaou
{
    public class VirtualPet
    {
        //properties
        public int Hunger { get; set; }
        public int Tiredness { get; set; }
        public int Boredom { get; set; }
        public int LifeSpan { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        //constructors
        public VirtualPet()
        {
            //default constructor
        }
        public VirtualPet(string name, string description, int hunger, int tiredness, int boredom)
        {
            this.Boredom = boredom;
            this.Tiredness = tiredness;
            this.Hunger = hunger;
            this.LifeSpan = LifeSpan;
            this.Name = name;
            this.Description = description;
        }
        public VirtualPet(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        //methods
        public void Play()
        {
            Boredom-=2;
            Hunger++;
            LifeSpan++;
        }
        public void Feed()
        {
            Hunger -= 2;
            LifeSpan++;
        }
        public void BedTime()
        {
            Tiredness -= 2;
            Hunger += 2;
            LifeSpan++;
        }
        public void Doctor()
        {
            LifeSpan += 3;
            Boredom += 5;
        }
        public int CheckStatus(int ask)
        {
            if (ask == 1)
            {
                return Hunger;
            }
            else if (ask == 2)
            {
                return Tiredness;
            }
            else if (ask == 3)
            {
                return LifeSpan;
            }
            else
                return 0;
        }
        public void Tick()
        {
            Random r = new Random();
            int lifeUpDown = r.Next(1, 4);

            if (lifeUpDown==1)
            {
                LifeSpan--;
            }
            else if(lifeUpDown==2)
            {
                LifeSpan++;
            }
            else
            {
                Hunger--;
            }
        }
        
    }
}
