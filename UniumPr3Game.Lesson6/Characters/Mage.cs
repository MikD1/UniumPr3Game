using System;

namespace UniumPr3Game.Characters
{
    class Mage : Character
    {
        public Mage()
        {
            MaxHP = 90;
            HP = MaxHP;
            Mana = 30;
        }

        public int Mana { get; private set; }

        public void Fireball(Character target)
        {
            target.HP -= Mana;
        }
    }
}
