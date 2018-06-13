using System;
using System.Collections.Generic;
using System.Text;

namespace DogHouse.Domain
{
    public class DepositDog : Perrera
    {
        public static string validationMessage { get; set; }

        public static bool isValidDogName(Dog dogDeposit)
        {
            bool validDogName = true;
            if (dogDeposit.Name.Contains("People eater"))
            {
                validationMessage = "The dog its to danguerous to be Deposit. Dont come back.";
                validDogName = false;
            }
            return validDogName;
        }

        public static bool isValidDogForAge(Dog dogDeposit)
        {
            bool validDogForAge = true;
            if (dogDeposit.Age < 1)
            {
                validationMessage = "The dog its to small to be Deposit. Come back when the dog were older than 1 year.";
                validDogForAge = false;
            }
            else if (dogDeposit.Age > 30)
            {
                validationMessage = "WTF this not suppouse to be alive???. I will call the Zoo";
                validDogForAge = false;
            }
            else if (dogDeposit.Age > 10)
            {
                validationMessage = "The dog its to older to be Deposit. Dont come back.";
                validDogForAge = false;
            }
            return validDogForAge;
        }

        

        public static double DogDepositCostCalculate(Dog dog)
        {
            double depositPriceDouble;

            switch (dog.DogBreedRace)
            {
                //Big dogs are expensive to mantain
                case "Boxer":
                case "Bulldog":
                case "Rotweiler":
                case "GermanShepherd":
                    var bigDogPrice = (10 * dog.Age) * 2.0; //2.0 its the IVA
                    depositPriceDouble = bigDogPrice;
                    break;
                case "Chihuahua":
                    var smallDogPrice = (10 * dog.Age) * 2.0;
                    depositPriceDouble = smallDogPrice;
                    break;
                default:
                    var normalDogPrice = (10 * dog.Age) * 2.0;
                    depositPriceDouble = normalDogPrice;
                    break;
            }

            //return the price
            return depositPriceDouble;
        }

    }
}
