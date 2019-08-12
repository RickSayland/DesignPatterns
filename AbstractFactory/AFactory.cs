using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class AFactory
    {
        public abstract void MakeDoor(int count);

        public abstract void MakeWall(int length, int width);

        public abstract void MakeFloor(int area);

    }
}
