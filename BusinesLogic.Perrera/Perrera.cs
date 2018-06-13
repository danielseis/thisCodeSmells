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
            Dog dogDeposit = new Dog();
            dogDeposit = dog;
            if (isValidCapacityPerrera())
            {

                if (DepositDog.isValidDogForAge(dogDeposit) && DepositDog.isValidDogName(dogDeposit))
                {
                    var price = DepositDog.DogDepositCostCalculate(dog);
                    this.SetIdToDog(dog);

                    //Put the dog into its cage
                    Dogs.Add(dog);

                    return Ticket.Print(dog.ToString(), price, "Deposit", userName); ;
                }
                
            }

            return DepositDog.validationMessage;
        }

      

        public string Adopt(string userName, string raceEnum)
        {

            if (AdoptDog.isValidAdoptUserName(userName) && AdoptDog.ContainsRaceInPerrera(raceEnum,Dogs))
            {
                var dog = Dogs.FirstOrDefault(x => x.DogBreedRace == raceEnum);
                var price = AdoptDog.DogAdoptCostCalculate(dog);

                return Ticket.Print(dog.ToString(), price, "Adopt", userName);
            }

            return AdoptDog.validationMessage;

        }

        public bool isValidCapacityPerrera()
        {
            bool capacityPerrera = true;
            if (Dogs.Count >= 100)
            {
                DepositDog.validationMessage = "We are full :(. Why dont you Adopt one";
                capacityPerrera = false;
            }
            return capacityPerrera;
        }


        //Calculate the cost of Adopt a Dog
        



        private void SetIdToDog(Dog dog)
        {
            dog.DogHouseId = Guid.NewGuid();
            //if we are setting Id its becouse we are going to Deposit so we set flag to true.
            dog.IsInDogHouse = true;
            dog.DepositAt = DateTime.UtcNow;

            //this.RenameDog(dog);
        }

       
    }
}