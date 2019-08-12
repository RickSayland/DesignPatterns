using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IFactory
    {
        void MakeDoor(int count);
        void MakeWall(int length, int width);
        void MakeFloor(int area);
    }
}
