using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var woodFactory = new WoodFactory();
            var stoneFactory = new StoneFactory();
            var glassFactory = new GlassFactory();
            var plutoniumFactory = new PlutoniumFactory();
            var iceFactory = new IceFactory();

            MakeHouse(woodFactory);
            Console.WriteLine("~~~~~~~~~~~~~~~");
            MakeHouse(stoneFactory);
            Console.WriteLine("~~~~~~~~~~~~~~~");
            MakeHouse(glassFactory);
            Console.WriteLine("~~~~~~~~~~~~~~~");
            MakeHouse(plutoniumFactory);
            Console.WriteLine("~~~~~~~~~~~~~~~");
            MakeHouse(iceFactory);

            //Halt
            Console.Read();
        }
        static void MakeHouse(IFactory factory)
        {
            factory.MakeFloor(50);
            factory.MakeWall(2, 4);
            factory.MakeDoor(3);
        }
        static void MakeHouse(AFactory factory)
        {
            factory.MakeFloor(50);
            factory.MakeWall(2, 4);
            factory.MakeDoor(3);
        }
    }
}
