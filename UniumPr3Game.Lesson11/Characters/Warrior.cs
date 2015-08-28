using System;
using UniumPr3Game.Characters.Skills;

namespace UniumPr3Game.Characters
{
    class Warrior : Character
    {
        public Warrior()
            : base(new Skill[] { new Kick(), new Blow() })
        {
            MaxHP = 110;
            HP = MaxHP;
        }

        public override string Name
        {
            get
            {
                return "Воин";
            }
        }
    }
}
