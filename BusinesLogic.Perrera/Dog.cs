using System;

namespace DogHouse.Domain
{ 
    public class Dog
    {
        public Guid DogHouseId { get; set; }
        public bool IsInDogHouse { get; set; }
        public DateTime DepositAt { get; set; }

        //public DogBreed Race { get; set; }
        public string DogBreedRace { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }


        public override string ToString()
        {            
            return $"{Name}. {DogBreedRace}. {Age} years.";
        }

        //Calculate the months in the DogHouse.
        public int HowLongInDogHouse()
        {
            int months = 0;
            if (!this.IsInDogHouse)
            {
                //i found it on stacoverflow suck it!!
                months = (DateTime.UtcNow.Month - this.DepositAt.Month) + 12 * (DateTime.UtcNow.Year - this.DepositAt.Year);
            }
            return months;
        }

        private void RenameDog()
        {
            Name = Name + " is on Deposit now :(";
        }
    }
}