using System;
using UniumPr3Game.Core.Characters.Skills;

namespace UniumPr3Game.Core.Characters
{
    internal class Mage : Character
    {
        public Mage()
            : base(new Skill[] { new Kick(), new Fireball() })
        {
            MaxHP = 90;
            HP = MaxHP;
        }

        public override string Name
        {
            get
            {
                return "Маг";
            }
        }
    }
}
