using MyGameProject.Abstract;
using MyGameProject.Adapter;
using MyGameProject.Concrete;
using System;

namespace MyGameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseGamerManager gamerManager = new GamerManager(new MerinsCheckAdapter());
            gamerManager.Add(new Gamer
            {
                FirstName = "Tuba",
                LastName = "Duymaz",
                DateOfBirth = new DateTime(1990,10,28),
                NationalityId = "12037117934"

            });

            Console.ReadLine();
         
        }
    }
}
