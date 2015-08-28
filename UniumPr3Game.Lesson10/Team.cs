using System;
using UniumPr3Game.Characters;

namespace UniumPr3Game
{
    class Team
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
