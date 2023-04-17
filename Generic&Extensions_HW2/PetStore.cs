using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Generic_Extensions_HW2
{
    public class PetStore<T> where T : Pet
    {
        public List<T> Db;

        public PetStore()
        {
            Db = new List<T>();
        }

        public void PrintsPets(List<T> pets)
        {
            foreach(T pet in pets)
            {
                Console.WriteLine(pet.PrintInfo());
            }
        }

        //BuyPet() - Method that takes ‘name’ as parameter, find the first pet by that name,
        //    removes it from the list and gives a success message.If there is no pet by that name, inform the customer

        public void BuyPet(List<T> pets , string nameInput)
        {
            T findPet = pets.FirstOrDefault(x => x.Name == nameInput);

            if(findPet == null)
            {
                throw new Exception("Pet with that name not found");
            }

            Db.Remove(findPet);
            Console.WriteLine($"Successfuly bought {nameInput}");
        }
    }
}
