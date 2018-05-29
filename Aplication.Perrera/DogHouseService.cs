using DogHouse.Domain;
using DogHouse.Infrastructure.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DogHouse.Application.Impl
{
    public class DogHouseService
    {

        IDogHouseRepository _repository;


        public DogHouseService(IDogHouseRepository repository)
        {
            _repository = repository;
        }


        public List<Dog> GetDogs()
        {
            return _repository.GetDog();
        }

        public Perrera DogHouse()
        {
             return _repository.GetDogHouse();
        }
    }
}
