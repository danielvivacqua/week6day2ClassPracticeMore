using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6day2ClassPracticeMore
{
    class Program
    {
        static void Main(string[] args)
        {
            Vegetable peppy = new Vegetable();
            peppy.Ripen();
            peppy.Color = "purple";
            Console.WriteLine("Peppy's color is {0}.", peppy.Color);

            Vegetable miguel = new Vegetable();
            miguel.Ripen("blue", "square", "small", "bitter");
            Console.WriteLine("Miguel's color is {0}. Shape is {1}. Miguel's size is {2}. Miguel's sweetness is {3}.", miguel.Color, miguel.Shape, miguel.Size, miguel.Sweetness);

            //Now I'm testing Inheritance
            //create new Pepper object

            Pepper piper = new Pepper();
            //piper.Ripen();
            Console.WriteLine("Color : {0}. Shape : {1}. Size : {2}. Sweetness : {3}. Type : {4}.", piper.Color, piper.Shape, piper.Size, piper.Sweetness, piper.Type);

            //let's create a pumpkin
            Pumpkin jack = new Pumpkin();
            Console.WriteLine("Color : {0}. Shape : {1}. Size : {2}. Sweetness : {3}. Type : {4}.", jack.Color, jack.Shape, jack.Size, jack.Sweetness, jack.Type);
        }
    }
}
