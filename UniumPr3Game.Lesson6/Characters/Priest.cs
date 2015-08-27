using System;

namespace UniumPr3Game.Characters
{
    class Priest : Character
    {
        public Priest()
        {
            MaxHP = 90;
            HP = MaxHP;
            Mana = 15;
        }

        public int Mana { get; private set; }

        public void Heal(Character target)
        {
            target.HP += Mana;
        }
    }
}
