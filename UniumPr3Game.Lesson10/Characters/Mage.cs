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

        public override string Name
        {
            get
            {
                return "Маг";
            }
        }

        public int Mana { get; private set; }

        public override void Action(Character target)
        {
            target.HP -= Mana;
        }
    }
}
