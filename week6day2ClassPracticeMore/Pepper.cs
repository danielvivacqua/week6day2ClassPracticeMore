using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6day2ClassPracticeMore
{
    class Pepper:Vegetable //this is how you indicate INHERITANCE
    {
        public new string Type { get; set; } = "pepper";
        //public override string Type { get; set; } = "pepper";

        public Pepper()
        {
            this.Color = "red";
            this.Size = "small";
            this.Sweetness = "little";
            //this.Type = "bell pepper";
            this.Shape = "round";
        }
    }
}
