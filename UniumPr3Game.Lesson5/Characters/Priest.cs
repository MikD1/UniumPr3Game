using System;

namespace UniumPr3Game.Characters
{
    class Priest
    {
        public Priest()
        {
            HP = _maxHP;
            Mana = 15;
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
        public int Mana { get; private set; }

        public bool IsDead
        {
            get
            {
                return HP == 0;
            }
        }

        public void Heal(Warrior target)
        {
            target.HP += Mana;
        }
        public void Heal(Mage target)
        {
            target.HP += Mana;
        }
        public void Heal(Priest target)
        {
            target.HP += Mana;
        }

        private int _HP;
        private const int _maxHP = 90;
    }
}
