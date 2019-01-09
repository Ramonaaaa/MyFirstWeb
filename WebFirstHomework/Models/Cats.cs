using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFirstHomework.Models
{
    public enum FurColor
    {
        Black,
        White,
        Yellow
    }

    public enum Gender
    {
        Male,
        Female
    }

    public class Cats
    {
        public string CatName { get; set; }
        public int CatAge { get; set; }
        public Gender Gender { get; set; }
        public FurColor FurColor { get; set; }
    }
}
