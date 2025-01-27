using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign
{
    internal interface IShape
    {
        public decimal Area { get; }
        public void DisplayShapeInfo();
    }
    interface ICircle : IShape { }
    interface IRectangular : IShape { }
    class Circle : ICircle
    {
        public decimal R { get; set; }
        public decimal Area
        {
            get { return R * R * 3.14M; }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Radius {R} Area {Area}");
        }
    }
    class Rectangular : IRectangular
    {
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal Area
        {
            get
            {
                return Width * Height;
            }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Width :  {Width} , Height : {Height} Area {Area}");

        }
    }

}
