using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solv_the_assignment_OOP4
{
    //Implement these interfaces in classes Circle and Rectangle.
    internal class Circle: ICircle
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Area => Math.PI * Radius * Radius;
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle with Radius: {Radius}, Area: {Area}");
        }
    }
}
