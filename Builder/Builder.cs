using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class LazyBuilder : ABuilder
    {
        private Building _bldg = new Building();

        public override Building GetBuilding()
        {
            return _bldg;
        }

        public override void MakeFloor()
        {
            Console.WriteLine("Dirt floor...good enough");
            
        }

        public override void MakeRoof()
        {
            Console.WriteLine("Dirt roof...good enough");
        }

        public override void MakeWalls()
        {
            Console.WriteLine("Dirt walls...good enough");
        }

        public override void MakeWindows()
        {
            Console.WriteLine("Nah..no windows");
        }
    }
    class ShadyBuilder : ABuilder
    {
        public override Building GetBuilding()
        {
            return null;
        }

        public override void MakeFloor()
        {
            Console.WriteLine("nah");
        }

        public override void MakeRoof()
        {
            Console.WriteLine("nah");
        }

        public override void MakeWalls()
        {
            Console.WriteLine("nah");
        }

        public override void MakeWindows()
        {
            Console.WriteLine("nah");
        }
    }
    class GoodBuilder : IBuilder
    {
        private Building _bldg;
        public Building GetBuilding()
        {
            return new Building();
        }

        public void MakeFloor()
        {
            Console.WriteLine("Here is a great floor");
            Console.WriteLine("Taking my time on this great floor");
        }

        public void MakeRoof()
        {
            Console.WriteLine("Here is a great roof");
            Console.WriteLine("Taking my time on this great roof");
            Console.WriteLine("allll the shingles");
            Console.WriteLine("and nails");
        }

        public void MakeWalls()
        {
            Console.WriteLine("Here is a great wall");
        }

        public void MakeWindows()
        {
            Console.WriteLine("super shiny windows!");
        }
    }
}
