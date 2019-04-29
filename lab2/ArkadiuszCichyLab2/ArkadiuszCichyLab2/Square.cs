using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkadiuszCichyLab2
{
    /// <summary>
    /// Class Square inheritating from Shape
    /// </summary>
    public class Square : Shape, IResizable
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="size"></param>
        public Square(float size = 1)
        {
            this.size = size;
        }

        /// <summary>
        /// Calculating and returning area
        /// </summary>
        /// <returns></returns>
        public override float Area()
        {
            return size * size;
        }

        /// <summary>
        /// Using Kinga's code for taking inputs
        /// </summary>
        public void ChangeSize()
        {
            string input = Prompt.ShowDialog("Zmien dlugosc boku", "Podaj dlugosc boku");
            size = float.Parse(input);
        }

        /// <summary>
        /// Override ToString to show proper class name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Kwadrat";
        }
    }
}