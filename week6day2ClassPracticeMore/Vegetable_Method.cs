using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6day2ClassPracticeMore
{
    partial class Vegetable
    {
        //method
        public void Ripen()
        {
            this.Color = "orange";
            this.Shape = "round";
            this.Size = "large";
            this.Sweetness = "moderate";
        }

        //Polymorphism
        public void Ripen(string color)
        {
            this.Color = color;
            this.Shape = "round";
            this.Size = "large";
            this.Sweetness = "moderate";
        }

        public void Ripen(string color, string shape, string size, string sweetness)
        {
            this.Color = color;
            this.Shape = shape;
            this.Size = size;
            this.Sweetness = sweetness;
        }

    }
}
