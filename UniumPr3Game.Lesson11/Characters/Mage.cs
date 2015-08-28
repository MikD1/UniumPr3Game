using System;
using UniumPr3Game.Characters.Skills;

namespace UniumPr3Game.Characters
{
    class Mage : Character
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
