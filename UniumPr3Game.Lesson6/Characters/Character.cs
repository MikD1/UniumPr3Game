using System;

namespace UniumPr3Game.Characters
{
    class Character
    {
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

        public bool IsDead
        {
            get
            {
                return HP == 0;
            }
        }

        private int _HP;
        private int _maxHP;
    }
}
