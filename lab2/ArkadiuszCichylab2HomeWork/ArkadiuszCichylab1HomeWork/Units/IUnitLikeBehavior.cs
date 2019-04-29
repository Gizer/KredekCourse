using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArkadiuszCichyLab2Homework.Units
{
    // IUnitLikeBehavior, requires from class to have methods to work as proper unit
    internal interface IUnitLikeBehavior
    {
        /// <summary>
        /// If unit is alive
        /// </summary>
        /// <returns>True if unit is alive</returns>
        bool IsAlive();

        /// <summary>
        /// Reduce health by damage-unit's defense value
        /// </summary>
        /// <param name="damage"></param>
        /// <returns>Value of acctuall damage</returns>
        int HittedByUnit(int damage);

        /// <summary>
        /// Change unit image depending on state
        /// </summary>
        /// <param name="state"></param>
        void ChangeState(sbyte state);

        /// <summary>
        /// Heal unit
        /// </summary>
        void Heal();
    }
}