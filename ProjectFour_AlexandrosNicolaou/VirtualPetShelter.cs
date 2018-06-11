using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFour_AlexandrosNicolaou
{
    public class VirtualPetShelter
    {
        //list of objects
        List<Employee> Workers = new List<Employee>();
        List<PetType> Pet = new List<PetType>();

        public void NewWorkers(Employee employee)
        {
            Workers.Add(employee);
        }

        public List<Employee> GetEmployees()
        {
            return Workers;
        }

        public void NewPet(PetType goodBoy)
        {
            Pet.Add(goodBoy);
        }

        public List<PetType> GetPets()
        {
            return Pet;
        }

    }
}
