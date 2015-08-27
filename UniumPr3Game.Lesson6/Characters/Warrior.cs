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

        public int Strength { get; private set; }

        public void Blow(Character target)
        {
            target.HP -= Strength;
        }
    }
}
