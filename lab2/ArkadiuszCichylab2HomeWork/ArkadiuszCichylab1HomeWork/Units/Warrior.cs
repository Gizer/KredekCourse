using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArkadiuszCichyLab2Homework.Units
{
    /// <summary>
    /// Warrior class. Describes warrior unit
    /// </summary>
    internal class Warrior : Unit, IMovable
    {
        /// <summary>
        /// Ctor for warrior with default values
        /// </summary>
        /// <param name="hp"></param>
        /// <param name="mp"></param>
        /// <param name="attack"></param>
        /// <param name="defense"></param>
        /// <param name="moveDistance"></param>
        /// <param name="level"></param>
        /// <param name="attackDistance"></param>
        public Warrior(int hp = 50, int mp = 0, int attack = 4, int defense = 2,
            int moveDistance = 3, int level = 1, int attackDistance = 1)
        {
            this.Level = level;
            this.MaxHealthPoints = hp + (2 * this.Level);
            this.HealthPoints = this.MaxHealthPoints;
            this.MaxManaPoints = mp;
            this.ManaPoints = mp;
            this.AttackValue = attack + (int)(2.2F * this.Level);
            this.DefenseValue = defense + (int)(2.2F * this.Level);
            this.MoveDistance = moveDistance;
            this.AttackDistance = attackDistance;
            this.image = new Bitmap("Resources/img/units/WarriorStand.png");
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
                    this.image = new Bitmap("Resources/img/units/WarriorHurt.png");
                    break;

                case 0:
                    this.image = new Bitmap("Resources/img/units/WarriorStand.png");
                    break;

                case 1:
                    this.image = new Bitmap("Resources/img/units/WarriorShot.png");
                    break;

                case 2:
                    this.image = new Bitmap("Resources/img/units/WarriorSelected.png");
                    break;
            }
        }

        /// <summary>
        /// Level up unit
        /// </summary>
        public override void LevelUp()
        {
            ++this.Level;
            this.MaxHealthPoints = this.MaxHealthPoints + (3 * this.Level);
            this.HealthPoints = this.MaxHealthPoints;
            this.AttackValue = this.AttackValue + (int)(2.2F * this.Level);
            this.DefenseValue = this.DefenseValue + (int)(2.2F * this.Level);
            MessageBox.Show("Gratulacje! " + this.ToString() +
                " osiągnął poziom " + this.Level.ToString());
        }

        public override string ToString()
        {
            return "Warrior";
        }

        /// <summary>
        /// Dtor mostly for debug processes
        /// </summary>
        ~Warrior()
        {
            //MessageBox.Show("Utracono wojownika");
        }
    }
}