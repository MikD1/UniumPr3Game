using System;

namespace UniumPr3Game.Core.Characters.Skills
{
    public abstract class Skill
    {
        public abstract string Title { get; }

        public abstract int Rate { get; }
        public abstract int Energy { get; }

        public abstract void Action(Character self, Character target);
    }
}
