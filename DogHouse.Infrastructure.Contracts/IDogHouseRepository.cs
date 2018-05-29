using System;
using System.Collections.Generic;
using System.Text;
using DogHouse;
using DogHouse.Domain;

namespace DogHouse.Infrastructure.Contracts
{
    public interface IDogHouseRepository 
    {
        
        Perrera GetDogHouse();

        List<Dog> GetDog();

        //void Update(DogHouse dogHouse);


    }
}
