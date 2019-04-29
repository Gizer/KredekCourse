using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace ArkadiuszCichyLab2Homework.Units
{
    /// <summary>
    /// Archer class. Describes archer unit
    /// </summary>
    public class Archer : Unit, IMovable
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
        public Archer(int hp = 30, int mp = 0, int attack = 3, int defense = 1,
            int moveDistance = 2, int level = 1, int attackDistance = 5)
        {
            this.Level = level;
            this.MaxHealthPoints = hp + (2 * this.Level);
            this.HealthPoints = hp + (2 * this.Level);
            this.ManaPoints = mp;
            this.MaxManaPoints = mp;
            this.AttackValue = attack + (int)(1.5F * this.Level);
            this.DefenseValue = defense + (int)(1.5F * this.Level);
            this.MoveDistance = moveDistance;
            this.AttackDistance = attackDistance;
            this.image = new Bitmap("Resources/img/units/ArcherStand.png");
            //MessageBox.Show("Otrzymano Łucznika");
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
                    this.image = new Bitmap("Resources/img/units/ArcherHurt.png");
                    break;

                case 0:
                    this.image = new Bitmap("Resources/img/units/ArcherStand.png");
                    break;

                case 1:
                    this.image = new Bitmap("Resources/img/units/ArcherShot.png");
                    break;

                case 2:
                    this.image = new Bitmap("Resources/img/units/ArcherSelected.png");
                    break;
            }
        }

        /// <summary>
        /// Level up unit. If archer gets experienced enough, he becoms MasterArcher
        /// </summary>
        public override void LevelUp()
        {
            if (this.Level != 4)
            {
                ++this.Level;
                this.MaxHealthPoints = this.MaxHealthPoints + (3 * this.Level);
                this.HealthPoints = this.MaxHealthPoints;
                this.AttackValue = this.AttackValue + (int)(1.5F * this.Level);
                this.DefenseValue = this.DefenseValue + (int)(1.5F * this.Level);
                MessageBox.Show("Gratulacje! " + this.ToString() +
                    " osiągnął poziom " + this.Level.ToString());
            }
            else
            {
                MessageBox.Show("Twój łucznik awansował na poziom mistrzowski\r\n" +
                    "Otrzymujesz jednostkę Mistrzowski Łucznik");
                ArkadiuszCichylab1HomeWork.FormMain.getMasterArcher = true;
                //ArkadiuszCichylab1HomeWork.FormMain.UpgradeArcher(this);
            }
        }

        public override string ToString()
        {
            return "Archer";
        }

        ~Archer()
        {
            //MessageBox.Show("Utracono łucznika");
        }
    }
}