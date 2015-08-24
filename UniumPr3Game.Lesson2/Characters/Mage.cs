using System;

namespace UniumPr3Game.Lesson2.Characters
{
    class Mage
    {
        public int HP = 90;
        public int Mana = 30;

        public void Fireball(Warrior target)
        {
            target.HP -= Mana;
        }
        public void Fireball(Mage target)
        {
            target.HP -= Mana;
        }
        public void Fireball(Priest target)
        {
            target.HP -= Mana;
        }
    }
}
