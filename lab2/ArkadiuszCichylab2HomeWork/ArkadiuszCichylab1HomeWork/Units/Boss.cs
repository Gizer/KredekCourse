using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ArkadiuszCichyLab2Homework.Units
{
    /// <summary>
    /// Boss class. Describes boss unit
    /// </summary>
    internal class Boss : Unit
    {
        /// <summary>
        /// Getter and Setter for boss color. There are three colors that can be choosen
        /// </summary>
        public int Color { get; protected set; }

        /// <summary>
        /// Ctor with default values
        /// </summary>
        /// <param name="hp"></param>
        /// <param name="mp"></param>
        /// <param name="attack"></param>
        /// <param name="defense"></param>
        /// <param name="attackDistance"></param>
        public Boss(int hp = 100, int mp = 0, int attack = 5, int defense = 2, int attackDistance = 200)
        {
            this.MaxHealthPoints = hp;
            this.HealthPoints = hp;
            this.MaxManaPoints = mp;
            this.ManaPoints = mp;
            this.AttackValue = attack;
            this.AttackDistance = attackDistance;
            this.DefenseValue = defense;
            this.MoveDistance = 0;
            this.Level = 0;
            this.Color = 1;
            this.image = new Bitmap("Resources/img/units/BossStand1.png");
        }

        /// <summary>
        /// Ctor for boss. Boss stats will depend on how many fights player win. It also randomizes boss color
        /// </summary>
        /// <param name="fightLevel"></param>
        /// <param name="randomColor"></param>
        public Boss(int fightLevel, int randomColor)
        {
            this.MaxHealthPoints = 10 + 20 * fightLevel;
            this.HealthPoints = this.MaxHealthPoints;
            this.MaxManaPoints = this.ManaPoints = 0;
            this.AttackValue = 4 + (int)(1.5F * fightLevel);
            this.AttackDistance = 200;
            this.DefenseValue = 2 + fightLevel;
            this.MoveDistance = 0;
            this.Level = 0;
            this.Color = randomColor;
            this.image = new Bitmap($"Resources/img/units/BossStand{this.Color}.png");
        }

        public override string ToString()
        {
            return "Boss";
        }

        /// <summary>
        /// Since boss will not be slectable, there are only 3 states
        /// </summary>
        /// <param name="state"></param>
        public override void ChangeState(sbyte state)
        {
            switch (state)
            {
                case -1:
                    this.image = new Bitmap($"Resources/img/units/BossHurt{this.Color}.png");
                    break;

                case 0:
                    this.image = new Bitmap($"Resources/img/units/BossStand{this.Color}.png");
                    break;

                case 1:
                    this.image = new Bitmap($"Resources/img/units/BossShot{this.Color}.png");
                    break;
            }
        }

        public override void LevelUp()
        {
            ++this.Level;
        }
    }
}