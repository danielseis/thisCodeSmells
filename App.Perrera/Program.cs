
using DogHouse.Application.Impl;
using DogHouse.Domain;
using DogHouse.Infrastructure.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogHouse.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            DogHouseService dogHouse = new DogHouseService(new DogHouseRepority());
            List<Dog> dogList = dogHouse.GetDogs();
            Perrera laPerrera = dogHouse.DogHouse();

          
            Console.WriteLine(laPerrera.Deposit("Amalfi", dogList.Find(p => p.Name == "Chelsea")));

            Console.WriteLine(laPerrera.Adopt("Amalfi", "Chihuahua"));

            Console.WriteLine(laPerrera.Deposit("Georgina", dogList.Find(p => p.Name == "Pluto")));
            Console.WriteLine(laPerrera.Adopt("Georgina", "GermanShepherd"));

            Console.WriteLine(laPerrera.Adopt("Pau", "GermanShepherd"));

            Console.WriteLine(laPerrera.Adopt("Dog killer Pshyco", "Boxer"));


           

            Console.Read();

        }
    }
}
