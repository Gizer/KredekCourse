using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkadiuszCichyLab2
{
    /// <summary>
    /// Public class Circle inheriting from Shape
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Constructor for the class Circle. When size not given, size = 1
        /// </summary>
        /// <param name="size"></param>
        public Circle(float size = 1)
        {
            this.size = size;
        }

        /// <summary>
        /// Calculate and return circle area
        /// </summary>
        /// <returns></returns>
        public override float Area()
        {
            float area = 3.14159F * size * size;
            return area;
            // throw new NotImplementedException();
        }

        /// <summary>
        /// Overriding ToString() to show proper class name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Koło";
        }

        /// <summary>
        /// Permimeter of the circle
        /// </summary>
        /// <returns>Perimeter</returns>
        public override string Perimeter()
        {
            base.Perimeter();
            float area = 3.1415F * 2 * size;
            return area.ToString();
        }
    }
}