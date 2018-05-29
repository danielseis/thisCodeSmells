
using DogHouse.Domain;
using DogHouse.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogHouse.Infrastructure.Impl
{
    public class DogHouseRepority : IDogHouseRepository
    {
        private static object lockObject = new object();


        private List<Dog> dog = new List<Dog>();

        private static Perrera dogHouse = new Perrera();


        #region IDogHouseRepository

       
        

        public List<Dog> GetDog()
        {
            

            dog.Add(new Dog { Name = "Pluto", DogBreedRace = "Rotweiler", Age = 1 });
            dog.Add(new Dog { Name = "Chelsea", DogBreedRace = "Boxer", Age = 2 });
            dog.Add(new Dog { Name = "RinTinTin", DogBreedRace = "GermanShepherd", Age = 5, IsInDogHouse = true });
            dog.Add(new Dog { Name = "Lazie", DogBreedRace = "Chihuahua", Age = 1, IsInDogHouse = true });
            dog.Add(new Dog { Name = "Rex", DogBreedRace = "GermanShepherd", Age = 4, IsInDogHouse = true });

            return dog;
        }

        Perrera IDogHouseRepository.GetDogHouse()
        {
            dogHouse.Dogs.Add(dog.Find(p => p.Name == "RinTinTin"));
            dogHouse.Dogs.Add(dog.Find(p => p.Name == "Lazie"));
            dogHouse.Dogs.Add(dog.Find(p => p.Name == "Rex"));

            return dogHouse;
        }

        #endregion


    }
}
