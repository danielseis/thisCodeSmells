using System;
using System.Collections.Generic;
using System.Linq;

namespace DogHouse.Domain
{
    public class Perrera
    {
        public List<Dog> Dogs = new List<Dog>();

        public string Deposit(string userName, Dog dog)
        {
            string validationMessage = "";

            if (dog.Age < 1)
            {
                validationMessage = "The dog its to small to be Deposit. Come back when the dog were older than 1 year.";
                return validationMessage;
            }
            else if (dog.Age > 30)
            {
                validationMessage = "WTF this not suppouse to be alive???. I will call the Zoo";
                return validationMessage;
            }
            else if (dog.Age > 10)
            {
                validationMessage = "The dog its to older to be Deposit. Dont come back.";
                return validationMessage;
            }
            else if (dog.Name.Contains("People eater"))
            {
                validationMessage = "The dog its to danguerous to be Deposit. Dont come back.";
                return validationMessage;
            }
            else if (this.Dogs.Count >= 100)
            {
                validationMessage = "We are full :(. Why dont you Adopt one";
                return validationMessage;
            }
           

            var price = this.Calculate(dog);
            this.SetIdToDog(dog);

            //Put the dog into its cage
            this.Dogs.Add(dog);

         
            return Ticket.Print(dog.ToString(), price, "Deposit", userName); ;
        }

        public string Adopt(string userName, string raceEnum)
        {
            string validationMessage = "";

            if (!this.Dogs.Any(x => x.DogBreedRace == raceEnum))
            {
                validationMessage = "We dont have the dog you want";
                return validationMessage;
                //throw new InvaidPerreraException(validationMessage);
            }
            else if (userName.Contains("Dog killer"))
            {
                validationMessage = "I will call Police";
                return validationMessage;
                //throw new InvaidPerreraException(validationMessage);
            }

          

            var dog = this.Dogs.FirstOrDefault(x => x.DogBreedRace == raceEnum);
            var price = this.Calculate2(dog);


            return Ticket.Print(dog.ToString(), price, "Adopt", userName);
        }

        //Calculate the cost of Deposit a Dog
        private double Calculate(Dog dog)
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

        //Calculate the cost of Adopt a Dog
        private double Calculate2(Dog dog)
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

        private void SetIdToDog(Dog dog)
        {
            dog.DogHouseId = Guid.NewGuid();
            //if we are setting Id its becouse we are going to Deposit so we set flag to true.
            dog.IsInDogHouse = true;
            dog.DepositAt = DateTime.UtcNow;

            //this.RenameDog(dog);
        }

        private void RenameDog(Dog dog)
        {
            dog.Name = dog.Name + " is on Deposit now :(";
        }
    }
}