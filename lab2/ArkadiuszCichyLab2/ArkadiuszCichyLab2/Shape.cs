using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkadiuszCichyLab2
{
    /// <summary>
    /// Abstract class Shape
    /// </summary>
    public abstract class Shape
    {
        // size of shape
        protected float size;

        /// <summary>
        /// Abstract method
        /// </summary>
        /// <returns></returns>
        public abstract float Area();

        public virtual string Perimeter()
        {
            System.Windows.Forms.MessageBox.Show("Tutaj klasa bazowa");
            return "Bazowa";
        }
    }
}