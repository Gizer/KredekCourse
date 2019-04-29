using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ArkadiuszCichyLab2Homework.Units
{
    /// <summary>
    /// Base class for units
    /// </summary>
    public abstract class Unit : IUnitLikeBehavior, IMovable
    {
        /// <summary>
        /// Getters and Setters for unit's fields. They pretty much describe themselfs so no further comments
        /// </summary>
        public int MaxHealthPoints { get; protected set; }

        public int MaxManaPoints { get; protected set; }
        public int HealthPoints { get; protected set; }
        public int ManaPoints { get; protected set; }
        public int AttackValue { get; protected set; }
        public int DefenseValue { get; protected set; }
        public int MoveDistance { get; protected set; }
        public int AttackDistance { get; protected set; }
        public int XPosition { get; protected set; }
        public int YPosition { get; protected set; }
        public int Level { get; protected set; }
        public Bitmap image;

        /// <summary>
        /// Reduce health by damage-unit's defense value
        /// </summary>
        /// <param name="damage"></param>
        /// <returns>Value of acttuall damage</returns>
        public int HittedByUnit(int damage)
        {
            if (damage - DefenseValue > 0)
            {
                HealthPoints -= damage - DefenseValue;
                return damage - DefenseValue;
            }
            else
                return 0;
        }

        /// <summary>
        /// Level up unit
        /// </summary>
        public abstract void LevelUp();

        /// <summary>
        /// Information about unit
        /// </summary>
        /// <returns>String with all needed informations</returns>
        public virtual string GetInfo()
        {
            return $"Nazwa: {ToString()}\r\nHP: {HealthPoints}\r\nAtak: {AttackValue}\r\n" +
                $"Obrona: {DefenseValue}\r\nPoziom: {Level}";
        }

        /// <summary>
        /// Fixed name of class
        /// </summary>
        /// <returns>String with class name</returns>
        public override string ToString()
        {
            return "Unit";
        }

        /// <summary>
        /// If unit is alive
        /// </summary>
        /// <returns>True if unit is alive</returns>
        public bool IsAlive()
        {
            if (HealthPoints > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Changing image of unit
        /// </summary>
        /// <param name="state">-1 = Hurt, 0 = Stand, 1 = Attack, 2 = Selected</param>
        public abstract void ChangeState(sbyte state);

        /// <summary>
        /// Heal unit
        /// </summary>
        public void Heal()
        {
            HealthPoints = MaxHealthPoints;
            ManaPoints = MaxManaPoints;
        }

        /// <summary>
        /// Move unit to (x,y) position
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Move(int x, int y)
        {
            this.XPosition = x;
            this.YPosition = y;
        }
    }
}