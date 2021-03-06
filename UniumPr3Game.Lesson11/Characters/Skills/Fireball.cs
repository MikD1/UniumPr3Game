﻿using System;

namespace UniumPr3Game.Characters.Skills
{
    class Fireball : Skill
    {
        public override string Title
        {
            get
            {
                return "Огненный шар";
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
                target.HP -= _rate;
                self.Energy -= Energy;
            }
        }

        private const int _rate = 30;
        private const int _energy = 50;
    }
}
