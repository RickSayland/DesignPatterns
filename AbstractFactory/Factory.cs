using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class WoodFactory : IFactory
    {
        public void MakeDoor(int count)
        {
            Console.WriteLine("{0} WOOD doors made!", count);
        }

        public void MakeFloor(int area)
        {
            Console.WriteLine("{0} sized WOOD floor", area);
        }

        public void MakeWall(int length, int width)
        {
            Console.WriteLine("{0}x{1} WOOD wall made!", length, width);
        }
    }
    public class StoneFactory : IFactory
    {
        public void MakeDoor(int count)
        {
            Console.WriteLine("{0} STONE doors made!", count);
        }

        public void MakeFloor(int area)
        {
            Console.WriteLine("{0} sized STONE floor", area);
        }

        public void MakeWall(int length, int width)
        {
            Console.WriteLine("{0}x{1} STONE wall made!", length, width);
        }
    }
    public class GlassFactory : IFactory
    {
        public void MakeDoor(int count)
        {
            Console.WriteLine("{0} GLASS doors made!", count);
        }

        public void MakeFloor(int area)
        {
            Console.WriteLine("{0} sized GLASS floor", area);
        }

        public void MakeWall(int length, int width)
        {
            Console.WriteLine("{0}x{1} GLASS wall made!", length, width);
        }
    }
}
