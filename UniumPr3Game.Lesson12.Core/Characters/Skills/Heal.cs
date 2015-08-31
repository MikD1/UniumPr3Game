using System;

namespace UniumPr3Game.Core.Characters.Skills
{
    internal class Heal : Skill
    {
        public override string Title
        {
            get
            {
                return "Лечение";
            }
        }

        public override int Rate
        {
            get
            {
                return _rate;
            }
        }
        public override int Energy
        {
            get
            {
                return _energy;
            }
        }

        public override void Action(Character self, Character target)
        {
            if (self.Energy >= Energy)
            {
                target.HP += _rate;
                self.Energy -= Energy;
            }
        }

        private const int _rate = 15;
        private const int _energy = 25;
    }
}
