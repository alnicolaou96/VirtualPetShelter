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
            int i;
            int pet = 0;
            int whichPet;

            VirtualPetShelter cat = new VirtualPetShelter();
            VirtualPetShelter dog = new VirtualPetShelter();
            VirtualPetShelter bird = new VirtualPetShelter();
            VirtualPetShelter chimera = new VirtualPetShelter();

            PetType catTwo = new PetType();
            PetType dogTwo = new PetType();
            PetType birdTwo = new PetType();
            PetType chimeraTwo = new PetType();


            Console.Write("volunteer or manager: ");
            string managerOrVolunteer = Console.ReadLine().ToLower();

            Volunteer newPerson = new Volunteer();
            Manager newManager = new Manager();

            if (managerOrVolunteer== "manager")
            {
                do
                {


                    Console.WriteLine("1:Feed\n2:Play\n3:Adopt\n4:Put Away\n5: Check Status");
                    int action = int.Parse(Console.ReadLine());
                    switch (action)
                    {
                        case 1:
                            Console.WriteLine("1:Cat\n2:Dog\n3:Bird\n4:chimera");
                            whichPet = int.Parse(Console.ReadLine());
                            switch (whichPet)
                            {
                                case 1:
                                    catTwo.Feed();
                                    break;
                                case 2:
                                    dogTwo.Feed();
                                    break;
                                case 3:
                                    birdTwo.Feed();
                                    break;
                                case 4:
                                    chimeraTwo.Feed();
                                    break;
                            }
                            if (newManager.Feed() == 1)
                                Console.WriteLine("pet has been fed");
                            break;
                        case 2:
                            Console.WriteLine("1:Cat\n2:Dog\n3:Bird\n4:chimera");
                            whichPet = int.Parse(Console.ReadLine());
                            switch (whichPet)
                            {
                                case 1:
                                    catTwo.Play();
                                    break;
                                case 2:
                                    dogTwo.Play();
                                    break;
                                case 3:
                                    birdTwo.Play();
                                    break;
                                case 4:
                                    chimeraTwo.Play();
                                    break;
                            }
                            if (newManager.Play() == 3)
                               
                            Console.WriteLine("pet has been played");
                            break;
                        case 3:
                            Console.WriteLine("1:Cat\n2:Dog\n3:Bird\n4:chimera");
                            whichPet = int.Parse(Console.ReadLine());
                            if (newManager.Adopt() == 12)
                                Console.WriteLine("pet has been adopted");
                            break;
                        case 4:
                            Console.WriteLine("1:Cat\n2:Dog\n3:Bird\n4:chimera");
                            whichPet = int.Parse(Console.ReadLine());
                          
                            if (newManager.PutAway() == 3);
                            Console.WriteLine("you put pet away");
                            pet = 3;
                            Console.WriteLine("You Earned "+newManager.Paycheck()+"dollar");
                            break;
                        case 5:
                            Console.WriteLine("1:Cat\n2:Dog\n3:Bird\n4:chimera");
                            whichPet = int.Parse(Console.ReadLine());
                            switch (whichPet)
                            {
                                case 1:
                                    for (i = 0; i <= 3; i++)
                                    {
                                        Console.WriteLine(catTwo.CheckStatus(i));
                                    }
                                    break;
                                case 2:
                                    for (i = 0; i <= 3; i++)
                                    {
                                        Console.WriteLine(dogTwo.CheckStatus(i));
                                    }
                                    break;
                                case 3:
                                    for (i = 0; i <= 3; i++)
                                    {
                                        Console.WriteLine(birdTwo.CheckStatus(i));
                                    }
                                    break;
                                case 4:
                                    for (i = 0; i <= 3; i++)
                                    {
                                        Console.WriteLine(chimeraTwo.CheckStatus(i));
                                    }
                                    break;
                            }
                            break;
                        default:
                            return;
    
                    }
                   
                } while (pet != 3);

            }
            else if(managerOrVolunteer=="volunteer")
            {
                do
                {


                    Console.WriteLine("1:Feed\n2:Play\n3:Put Away\n4: Check Status");
                    int action = int.Parse(Console.ReadLine());
                    switch (action)
                    {
                        case 1:
                            Console.WriteLine("1:Cat\n2:Dog\n3:Bird\n4:chimera");
                            whichPet = int.Parse(Console.ReadLine());
                            switch (whichPet)
                            {
                                case 1:
                                    catTwo.Feed();
                                    break;
                                case 2:
                                    dogTwo.Feed();
                                    break;
                                case 3:
                                    birdTwo.Feed();
                                    break;
                                case 4:
                                    chimeraTwo.Feed();
                                    break;
                            }
                            if (newManager.Feed() == 1)
                                Console.WriteLine("pet has been fed");
                            break;
                        case 2:
                            Console.WriteLine("1:Cat\n2:Dog\n3:Bird\n4:chimera");
                            whichPet = int.Parse(Console.ReadLine());
                            switch (whichPet)
                            {
                                case 1:
                                    catTwo.Play();
                                    break;
                                case 2:
                                    dogTwo.Play();
                                    break;
                                case 3:
                                    birdTwo.Play();
                                    break;
                                case 4:
                                    chimeraTwo.Play();
                                    break;
                            }
                            if (newManager.Play() == 3)
                               
                            Console.WriteLine("pet has been played");
                            break;

                        case 3:
                            Console.WriteLine("1:Cat\n2:Dog\n3:Bird\n4:chimera");
                            whichPet = int.Parse(Console.ReadLine());

                            if (newManager.PutAway() == 3) ;
                            Console.WriteLine("you put pet away");
                            pet = 3;
                            Console.WriteLine("You Earned " + newPerson.Paycheck() + " dollar");
                            break;
                        case 4:
                            Console.WriteLine("1:Cat\n2:Dog\n3:Bird\n4:chimera");
                            whichPet = int.Parse(Console.ReadLine());
                            switch (whichPet)
                            {
                                case 1:
                                    for (i = 0; i <= 3; i++)
                                    {
                                        Console.WriteLine(catTwo.CheckStatus(i));
                                    }
                                    break;
                                case 2:
                                    for (i = 0; i <= 3; i++)
                                    {
                                        Console.WriteLine(dogTwo.CheckStatus(i));
                                    }
                                    break;
                                case 3:
                                    for (i = 0; i <= 3; i++)
                                    {
                                        Console.WriteLine(birdTwo.CheckStatus(i));
                                    }
                                    break;
                                case 4:
                                    for (i = 0; i <= 3; i++)
                                    {
                                        Console.WriteLine(chimeraTwo.CheckStatus(i));
                                    }
                                    break;
                            }
                            break;
                        default:
                            return;

                    }

                } while (pet != 3);
            }
            

            


        }
    }
}
