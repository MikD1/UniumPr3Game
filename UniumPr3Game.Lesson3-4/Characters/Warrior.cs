using System;

namespace UniumPr3Game.Characters
{
    class Warrior
    {
        public int HP = 110;
        public int Strength = 20;

        public bool IsDead
        {
            get
            {
                return HP <= 0;
            }
        }

        public void Blow(Warrior target)
        {
            target.HP -= Strength;
        }
        public void Blow(Mage target)
        {
            target.HP -= Strength;
        }
        public void Blow(Priest target)
        {
            target.HP -= Strength;
        }
    }
}
