using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6day2ClassPracticeMore
{
    partial class Vegetable
    {
        //fields under Invisibility cloak

        //properties
        public string Color { get; set; } 
        //public virtual string Type { get; set; } 
        public string Type { get; set; }
        public string Shape { get; set; }
        public string Size { get; set; } 
        public string Sweetness { get; set; } 

        //default constructor
        public Vegetable()
        {
            this.Color = "green";
            this.Type = "cucumber";
            this.Shape = "square";
            this.Sweetness = "sweet";
            this.Size = "large";
        }

    }
}
