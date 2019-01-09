using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebFirstHomework.Models;

namespace WebFirstHomework.Controllers
{
    public class CatsController : Controller
    {       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(Gender? gender, FurColor? furColor)
        {
            var cats = CatsList();

            if(gender.HasValue)
            {
                cats = cats.Where(x => x.Gender == gender.Value).ToList();                
            }

            if(furColor.HasValue)
            {               
                cats = cats.Where(x => x.FurColor == furColor.Value).ToList();
            }
        
            return View(cats);

        }

        private List<Cats> CatsList()
        {
            List<Cats> cats = new List<Cats>();

            cats.Add(new Cats()
            {
                CatAge = 4,
                CatName = "Lulu",
                Gender =Gender.Male,
                FurColor = FurColor.Black
               
            });

            cats.Add(new Cats()
            {
                CatAge = 1,
                CatName = "Lolo",
                Gender = Gender.Female,
                FurColor = FurColor.White
            });

            cats.Add(new Cats()
            {
                CatAge = 2,
                CatName = "Lili",
                Gender = Gender.Male,
                FurColor = FurColor.Yellow
            });

            cats.Add(new Cats()
            {
                CatAge = 2,
                CatName = "Sisi",
                Gender = Gender.Female,
                FurColor = FurColor.Black
            });

            cats.Add(new Cats()
            {
                CatAge = 2,
                CatName = "Soso",
                Gender = Gender.Female,
                FurColor = FurColor.Yellow
            });

            return cats;
        }
       
    }
}