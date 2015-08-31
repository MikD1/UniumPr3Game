using System;
using UniumPr3Game.Core.Characters.Skills;

namespace UniumPr3Game.Core.Characters
{
    internal class Warrior : Character
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
