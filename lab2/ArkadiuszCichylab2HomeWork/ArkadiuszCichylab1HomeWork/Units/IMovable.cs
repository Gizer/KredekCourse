using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArkadiuszCichyLab2Homework
{
    /// <summary>
    /// IMovable, requires from class to implement Move method
    /// </summary>
    internal interface IMovable
    {
        /// <summary>
        /// Enables ability to move
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void Move(int x, int y);
    }
}