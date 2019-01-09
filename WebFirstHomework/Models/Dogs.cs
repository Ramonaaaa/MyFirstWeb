using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFirstHomework.Models
{ 
    public class Dogs
    {
        public string DogName { get; set; }
        public string DogOwner { get; set; }
        public Gender Gender { get; set; }
        public FurColor FurColor { get; set; }
    }
}
