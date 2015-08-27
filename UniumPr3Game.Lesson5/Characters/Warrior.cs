using System;

namespace UniumPr3Game.Characters
{
    class Warrior
    {
        public Warrior()
        {
            HP = _maxHP;
            Strength = 20;
        }

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
                else if (value > _maxHP)
                {
                    _HP = _maxHP;
                }
                else
                {
                    _HP = value;
                }
            }
        }
        public int Strength { get; private set; }

        public bool IsDead
        {
            get
            {
                return HP == 0;
            }
        }

        public void Blow(Warrior target)
        {
            target.HP -= Strength;
        }
        public void Blow(Mage target)
        {
            target.HP -= Strength;
        }
        public void Blow(Priest target)
        {
            target.HP -= Strength;
        }

        private int _HP;
        private const int _maxHP = 110;
    }
}
