
using DogHouse.Domain;
using DogHouse.Infrastructure.Contracts;
using System;


namespace DogHouse.Application.Impl
{
    public class DogBuilder
    {
        private Guid dogHouseId;
        private bool isInDogHouse;
        private DateTime depositAt;
        private string dogBreedRace;
        private string name;
        private int age;


        public DogBuilder InDogHouse()
        {
            this.isInDogHouse = true;
            this.depositAt = DateTime.UtcNow.AddMonths(-(new Random().Next(0, 24)));
            this.dogHouseId = Guid.NewGuid();
            return this;
        }

        public DogBuilder WithDogHouseId(Guid dogHouseId)
        {
            this.dogHouseId = dogHouseId;
            return this;
        }

        public DogBuilder WithIsInDogHouse(bool isInDogHouse)
        {
            this.isInDogHouse = isInDogHouse;
            return this;
        }

        public DogBuilder WithDepositAt(DateTime depositAt)
        {
            this.depositAt = depositAt;
            return this;
        }

        public DogBuilder WithBreed(string race)
        {
            this.dogBreedRace = race;
            return this;
        }

        public DogBuilder WithName(string name)
        {
            this.name = name;
            return this;
        }

        public DogBuilder WithAge(int age)
        {
            this.age = age;
            return this;
        }
    }
}