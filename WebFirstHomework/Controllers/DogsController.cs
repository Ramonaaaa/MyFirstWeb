using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebFirstHomework.Models;

namespace WebFirstHomework.Controllers
{
    public class DogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(FurColor? color, Gender? gender)
        {
            var dog = DogsList();

            if (gender.HasValue)
            {
                dog = dog.Where(x => x.Gender == gender.Value).ToList();
            }

            if (color.HasValue)
            {
                dog = dog.Where(x => x.FurColor == color.Value).ToList();
            }

            return View(dog);
        }

        private List<Dogs> DogsList()
        {
            Console.WriteLine("testing the branch.");
            List<Dogs> dog = new List<Dogs>();

            dog.Add(new Dogs()
            {
                DogName = "Lord",
                DogOwner = "Ramona",
                FurColor = FurColor.White,
                Gender = Gender.Male
            });

            dog.Add(new Dogs()
            {
                DogName = "Blacky",
                DogOwner = "Cecilia",
                FurColor = FurColor.Black,
                Gender = Gender.Female
            });

            dog.Add(new Dogs()
            {
                DogName = "Jerky",
                DogOwner = "Roxana",
                FurColor = FurColor.Yellow,
                Gender = Gender.Female
            });

            dog.Add(new Dogs()
            {
                DogName = "Haidi",
                DogOwner = "Theo",
                FurColor = FurColor.Black,
                Gender = Gender.Male
            });

            dog.Add(new Dogs()
            {
                DogName = "Uzu",
                DogOwner = "Raluca",
                FurColor = FurColor.White,
                Gender = Gender.Male
            });

            return dog;
        }
    }
}