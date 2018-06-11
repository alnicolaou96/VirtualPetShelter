using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFour_AlexandrosNicolaou
{
    class Program
    {
        static void Main(string[] args)
        {

            int pet = 0;

            VirtualPetShelter cat = new VirtualPetShelter();
            VirtualPetShelter dog = new VirtualPetShelter();
            VirtualPetShelter bird = new VirtualPetShelter();
            VirtualPetShelter chimera = new VirtualPetShelter();

            Console.Write("volunteer or manager: ");
            string managerOrVolunteer = Console.ReadLine().ToLower();

            Volunteer newPerson = new Volunteer();
            Manager newManager = new Manager();

            if (managerOrVolunteer== "manager")
            {
                do
                {


                    Console.WriteLine("1:Feed\n2:Play all\n3:Adopt\n4:Put Away");
                    int action = int.Parse(Console.ReadLine());
                    switch (action)
                    {
                        case 1:
                            Console.WriteLine("1:Cat\n2:Dog\n3:Bird\n4:chimera");
                            int whichPet = int.Parse(Console.ReadLine());
                            switch (whichPet)
                            {
                                case 1:
                                    break;
                            }
                            if (newManager.Feed() == 1)
                                Console.WriteLine("pet has been fed");
                            break;
                        case 2:
                            if (newManager.Play() == 3) ;
                            Console.WriteLine("pet has been played");
                            break;
                        case 3:
                            if (newManager.Adopt() == 4)
                                Console.WriteLine("pet has been adopted");
                            break;
                        case 4:
                            if (newManager.PutAway() == 3);
                            Console.WriteLine("you put pet away");
                            pet = 3;
                            Console.WriteLine("You Earned "+newManager.Paycheck()+"dollar");
                            break;


                    }
                } while (pet != 3);

            }

            

            


        }
    }
}
