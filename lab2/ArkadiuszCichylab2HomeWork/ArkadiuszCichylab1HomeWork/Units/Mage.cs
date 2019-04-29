using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArkadiuszCichyLab2Homework.Units
{
    /// <summary>
    /// Mage class. Describes mage unit
    /// </summary>
    internal class Mage : Unit, IMovable
    {
        /// <summary>
        /// Ammount of mana required for attack (Getter and Setter)
        /// </summary>
        public int ManaAttackThreshold { get; protected set; }

        /// <summary>
        /// Ctor with default values
        /// </summary>
        /// <param name="hp"></param>
        /// <param name="mp"></param>
        /// <param name="attval"></param>
        /// <param name="defval"></param>
        /// <param name="movDist"></param>
        /// <param name="attDist"></param>
        /// <param name="level"></param>
        public Mage(int hp = 30, int mp = 20, int attval = 3, int defval = 1,
            int movDist = 2, int attDist = 4, int level = 1)
        {
            this.Level = level;
            this.MaxHealthPoints = hp + (int)(0.5 * this.Level);
            this.HealthPoints = this.MaxHealthPoints;
            this.MaxManaPoints = mp + (2 * this.Level);
            this.ManaPoints = this.MaxManaPoints;
            this.AttackValue = attval + (int)(1.5F * this.Level);
            this.DefenseValue = defval + (int)(1.5F * this.Level);
            this.MoveDistance = movDist;
            this.AttackDistance = attDist;
            this.ManaAttackThreshold = 4;
            this.image = new Bitmap("Resources/img/units/MageStand.png");
        }

        /// <summary>
        /// Changing image of unit
        /// </summary>
        /// <param name="state">-1 = Hurt, 0 = Stand, 1 = Attack, 2 = Selected</param>
        public override void ChangeState(sbyte state)
        {
            switch (state)
            {
                case -1:
                    this.image = new Bitmap("Resources/img/units/MageHurt.png");
                    break;

                case 0:
                    this.image = new Bitmap("Resources/img/units/MageStand.png");
                    break;

                case 1:
                    this.image = new Bitmap("Resources/img/units/MageShot.png");
                    Attack();
                    break;

                case 2:
                    this.image = new Bitmap("Resources/img/units/MageSelected.png");
                    break;
            }
        }

        /// <summary>
        /// Update mage's mana
        /// </summary>
        private void Attack()
        {
            this.ManaPoints -= this.ManaAttackThreshold;
        }

        /// <summary>
        /// Level up mage
        /// </summary>
        public override void LevelUp()
        {
            ++this.Level;
            this.MaxHealthPoints = this.MaxHealthPoints + (int)(1.5 * this.Level);
            this.HealthPoints = this.MaxHealthPoints;
            this.MaxManaPoints = this.MaxManaPoints + (3 * this.Level);
            this.ManaPoints = this.MaxManaPoints;
            this.AttackValue = this.AttackValue + (int)(1.5F * this.Level);
            this.DefenseValue = this.DefenseValue + (int)(1.5F * this.Level);
            MessageBox.Show("Gratulacje! " + this.ToString() +
                " osiągnął poziom " + this.Level.ToString());
        }

        public override string ToString()
        {
            return "Mage";
        }

        /// <summary>
        /// Mage have diffrent info than other units
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            return $"Nazwa: {ToString()}\r\nHP: {HealthPoints}\r\nMana: {ManaPoints}\r\n" +
                $"Atak: {AttackValue}\r\nObrona: {DefenseValue}\r\n" +
                $"Poziom: {Level}";
        }
    }
}