using UniumPr3Game.Characters.Skills;

namespace UniumPr3Game.Characters
{
    abstract class Character
    {
        public Character(Skill[] skills)
        {
            _maxEnergy = 100;
            Energy = 100;

            _skills = skills;
        }

        public abstract string Name { get; }

        public int HP
        {
            get
            {
                return _HP;
            }
            set
            {
                if (value < 0)
                {
                    _HP = 0;
                }
                else if (value > MaxHP)
                {
                    _HP = MaxHP;
                }
                else
                {
                    _HP = value;
                }
            }
        }
        public int MaxHP
        {
            get
            {
                return _maxHP;
            }
            protected set
            {
                if (value < 0)
                {
                    _maxHP = 0;
                }
                else
                {
                    _maxHP = value;
                }

                if (HP > value)
                {
                    HP = value;
                }
            }
        }

        public int Energy
        {
            get
            {
                return _energy;
            }
            set
            {
                if (value < 0)
                {
                    _energy = 0;
                }
                else if (value > _maxEnergy)
                {
                    _energy = _maxEnergy;
                }
                else
                {
                    _energy = value;
                }
            }
        }

        public bool IsDead
        {
            get
            {
                return HP == 0;
            }
        }

        public Skill[] Skills
        {
            get
            {
                return _skills;
            }
        }

        private int _HP;
        private int _maxHP;
        private int _energy;
        private int _maxEnergy;
        private readonly Skill[] _skills;
    }
}
