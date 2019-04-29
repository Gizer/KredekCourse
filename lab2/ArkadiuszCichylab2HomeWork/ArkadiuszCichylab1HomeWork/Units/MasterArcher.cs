using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace ArkadiuszCichyLab2Homework.Units
{
    /// <summary>
    /// MasterArcher class. Describes MasterArcher unit
    /// </summary>
    internal class MasterArcher : Archer
    {
        /// <summary>
        /// Ctor with default values
        /// </summary>
        /// <param name="hp"></param>
        /// <param name="mp"></param>
        /// <param name="attack"></param>
        /// <param name="defense"></param>
        /// <param name="moveDistance"></param>
        /// <param name="level"></param>
        /// <param name="attackDistance"></param>
        public MasterArcher(int hp = 100, int mp = 0, int attack = 10, int defense = 10,
            int moveDistance = 4, int level = 5, int attackDistance = 7) : base(mp, level)
        {
            this.MaxHealthPoints = hp + (2 * this.Level);
            this.HealthPoints = hp;
            this.AttackValue = attack + (int)(1.5F * this.Level);
            this.DefenseValue = defense + (int)(1.5F * this.Level);
            this.MoveDistance = moveDistance;
            this.AttackDistance = attackDistance;
            this.image = new Bitmap("Resources/img/units/MasterArcherStand.png");
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
                    this.image = new Bitmap("Resources/img/units/MasterArcherHurt.png");
                    break;

                case 0:
                    this.image = new Bitmap("Resources/img/units/MasterArcherStand.png");
                    break;

                case 1:
                    this.image = new Bitmap("Resources/img/units/MasterArcherShot.png");
                    break;

                case 2:
                    this.image = new Bitmap("Resources/img/units/MasterArcherSelected.png");
                    break;
            }
        }

        public override void LevelUp()
        {
            ++this.Level;
            this.MaxHealthPoints = this.MaxHealthPoints + (3 * this.Level);
            this.HealthPoints = this.MaxHealthPoints;
            this.AttackValue = this.AttackValue + (int)(1.5F * this.Level);
            this.DefenseValue = this.DefenseValue + (int)(1.5F * this.Level);
            MessageBox.Show("Gratulacje! " + this.ToString() +
                " osiągnął poziom " + this.Level.ToString());
        }

        public override string ToString()
        {
            return "MasterArcher";
        }

        ~MasterArcher()
        {
            //MessageBox.Show("Utracono Mistrzowskiego Łucznika");
        }
    }
}