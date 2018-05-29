﻿using System;
using CodeSmellsWithinClasses.ToRefactor;

namespace CodeSmellsWithinClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            DogBuilder pluto = new DogBuilder().WithName("Pluto").WithBreed(DogBreedEnum.Rotweiler).WithAge(1);
            DogBuilder chelsea = new DogBuilder().WithName("Chelsea").WithBreed(DogBreedEnum.Boxer).WithAge(2);

            DogBuilder rinTinTin = new DogBuilder().WithName("RinTinTin").WithBreed(DogBreedEnum.GermanShepherd).WithAge(5).InDogHouse();
            DogBuilder lazie = new DogBuilder().WithName("Lazie").WithBreed(DogBreedEnum.Chihuahua).WithAge(1).InDogHouse();
            DogBuilder rex = new DogBuilder().WithName("Rex").WithBreed(DogBreedEnum.GermanShepherd).WithAge(4).InDogHouse();

            DogHouse dogHouse = new DogHouse();
            dogHouse.Dogs.Add(rinTinTin);
            dogHouse.Dogs.Add(lazie);
            dogHouse.Dogs.Add(rex);


            Console.WriteLine(dogHouse.Deposit("Amalfi", chelsea));
            Console.WriteLine(dogHouse.Adopt("Amalfi", DogBreedEnum.Chihuahua));

            Console.WriteLine(dogHouse.Deposit("Georgina", pluto));
            Console.WriteLine(dogHouse.Adopt("Georgina", DogBreedEnum.GermanShepherd));

            Console.WriteLine(dogHouse.Adopt("Pau", DogBreedEnum.GermanShepherd));

            Console.WriteLine(dogHouse.Adopt("Dog killer Pshyco", DogBreedEnum.Boxer));

            Console.Read();
        }
    }
}
