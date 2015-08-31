using System;
using UniumPr3Game.Core.Characters.Skills;

namespace UniumPr3Game.Core.Characters
{
    internal class Priest : Character
    {
        public Priest()
            : base(new Skill[] { new Kick(), new Heal() })
        {
            MaxHP = 90;
            HP = MaxHP;
        }

        public override string Name
        {
            get
            {
                return "Жрец";
            }
        }
    }
}
