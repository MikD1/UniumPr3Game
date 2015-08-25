using System;

namespace UniumPr3Game.Characters
{
    class Mage
    {
        public int HP = 90;
        public int Mana = 30;

        public bool IsDead
        {
            get
            {
                return HP <= 0;
            }
        }

        public void Fireball(Warrior target)
        {
            target.HP -= Mana;
        }
        public void Fireball(Mage target)
        {
            target.HP -= Mana;
        }
        public void Fireball(Priest target)
        {
            target.HP -= Mana;
        }
    }
}
