using System;

namespace UniumPr3Game.Characters
{
    class Warrior : Character
    {
        public Warrior()
        {
            MaxHP = 110;
            HP = MaxHP;
            Strength = 20;
        }

        public override string Name
        {
            get
            {
                return "Воин";
            }
        }

        public int Strength { get; private set; }

        public override void Action(Character target)
        {
            target.HP -= Strength;
        }
    }
}
