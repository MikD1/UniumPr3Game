using System;
using UniumPr3Game.Core.Characters;

namespace UniumPr3Game.Core
{
    public sealed class Team
    {
        public Team(string name, Character[] members)
        {
            Name = name;
            Members = members;
        }

        public string Name { get; private set; }
        public Character[] Members { get; private set; }

        public bool IsDead()
        {
            foreach (Character character in Members)
            {
                if (!character.IsDead)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
