using System;

namespace UniumPr3Game.Characters
{
    class Priest
    {
        public int HP = 90;
        public int Mana = 15;

        public bool IsDead
        {
            get
            {
                return HP <= 0;
            }
        }

        public void Heal(Warrior target)
        {
            target.HP += Mana;
        }
        public void Heal(Mage target)
        {
            target.HP += Mana;
        }
        public void Heal(Priest target)
        {
            target.HP += Mana;
        }
    }
}
