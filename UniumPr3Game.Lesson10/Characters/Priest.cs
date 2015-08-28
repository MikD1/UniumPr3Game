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

        public override string Name
        {
            get
            {
                return "Жрец";
            }
        }

        public int Mana { get; private set; }

        public override void Action(Character target)
        {
            target.HP += Mana;
        }
    }
}
