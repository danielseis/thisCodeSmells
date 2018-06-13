using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogHouse.Domain
{
    class AdoptDog : Perrera
    {
        public static string validationMessage { get; set; }


        public static double DogAdoptCostCalculate(Dog dog)
        {
            double depositPriceDouble;

            switch (dog.DogBreedRace)
            {
                //Its ugly and noisy its free
                case "Chihuahua":
                    depositPriceDouble = 0;
                    break;
                default:
                    var normalDogPrice = dog.HowLongInDogHouse() * 2.0; //2.0 its the IVA
                    depositPriceDouble = normalDogPrice;
                    break;
            }

            //return the price
            return depositPriceDouble;
        }


        public static bool isValidAdoptUserName(string userName)
        {
            bool isvalidusername = true;
            if (userName.Contains("Dog killer"))
            {
                validationMessage = "I will call Police";
                isvalidusername = false;
                //throw new InvaidPerreraException(validationMessage);
            }
            return isvalidusername;
        }

        public static bool ContainsRaceInPerrera(string raceEnum, List<Dog> Dogs)
        {
            bool isContainsRaceInPerrera = true;
            if (!Dogs.Any(x => x.DogBreedRace == raceEnum))
            {
                validationMessage = "We dont have the dog you want";
                isContainsRaceInPerrera = false;
            }

            return isContainsRaceInPerrera;
        }
    }
}
