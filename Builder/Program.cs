using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //The builder pattern - a builder object is responsible for set up
            //builders can work differently
            //here we make a house using a lazy builder and a sneaky builder. similar to the abstract factory
            //however here the outer method acts as a director (Hey build the house!) and the builder follows direction.

            var lazyguy = new LazyBuilder(); //builds it but not very well. maybe for poor cpu systems? 
            var criminal = new ShadyBuilder(); //says he builds it but actually doesnt

            //lazy build a house and a mansion
            var a = MakeHouse(lazyguy);
            var b = MakeMansion(lazyguy);
            //sneaky build a house and mansion
            var c = MakeHouse(criminal);
            var d = MakeMansion(criminal);

            //Halt
            Console.Read();
        }
        static Building MakeHouse(IBuilder builder)
        {
            Console.WriteLine("HOUSE START:");
            builder.MakeRoof();
            builder.MakeWalls();
            builder.MakeFloor();
            Console.WriteLine("HOUSE END:");
            return builder.GetBuilding();
        }
        static Building MakeHouse(ABuilder builder)
        {
            Console.WriteLine("HOUSE START:");
            builder.MakeRoof();
            builder.MakeWalls();
            builder.MakeFloor();
            Console.WriteLine("HOUSE END:");
            return builder.GetBuilding();
        }
        static Building MakeMansion(IBuilder builder)
        {
            Console.WriteLine("MANSION START:");
            builder.MakeRoof();
            builder.MakeWalls();
            builder.MakeFloor();
            builder.MakeRoof();
            builder.MakeWalls();
            builder.MakeFloor();
            builder.MakeRoof();
            builder.MakeWalls();
            builder.MakeFloor();
            builder.MakeRoof();
            builder.MakeWalls();
            builder.MakeFloor();
            Console.WriteLine("MANSION END:");
            return builder.GetBuilding();
        }
        static Building MakeMansion(ABuilder builder)
        {
            Console.WriteLine("MANSION START:");
            builder.MakeRoof();
            builder.MakeWalls();
            builder.MakeFloor();
            builder.MakeRoof();
            builder.MakeWalls();
            builder.MakeFloor();
            builder.MakeRoof();
            builder.MakeWalls();
            builder.MakeFloor();
            builder.MakeRoof();
            builder.MakeWalls();
            builder.MakeFloor();
            Console.WriteLine("MANSION END:");
            return builder.GetBuilding();
        }
    }
    public class Building
    {

    }
}
