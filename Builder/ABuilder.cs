using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public abstract class ABuilder
    {
        public virtual void MakeFloor() { }
        public virtual void MakeWalls() { }
        public virtual void MakeWindows() { }
        public virtual void MakeRoof() { }
        public abstract Building GetBuilding();

    }
    //Interface works too
    public interface IBuilder
    {
        void MakeFloor();
        void MakeWalls();
        void MakeWindows();
        void MakeRoof();
        Building GetBuilding();

    }
}
