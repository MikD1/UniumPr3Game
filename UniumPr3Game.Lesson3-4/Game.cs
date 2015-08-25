using System;
using UniumPr3Game.Characters;

/*
 * Доработки, которые можно дать ребятам для самостоятельного выполнения:
 * 
 * Проверка пользовательского ввода (выбор персонажей и целей).
 * Можно корректно обрабатывать ошибки и просить повторить ввод.
 * 
 * Не показывать в таблице статистики мертвых персонажей и не давать выбирать их в качестве целей.
*/

namespace UniumPr3Game
{
    class Game
    {
        public void Start()
        {
            int currentCommand = 1;
            while (!IsEnd())
            {
                PrintStatistics();

                Console.Write(string.Format("Ход команды {0}. Выбери персонажа (1-3): ", currentCommand));
                int character = int.Parse(Console.ReadLine());

                Console.Write("Выбери цель (1-3): ");
                int target = int.Parse(Console.ReadLine());

                if (currentCommand == 1)
                {
                    Action1(character, target);
                    currentCommand = 2;
                }
                else
                {
                    Action2(character, target);
                    currentCommand = 1;
                }
            }
        }

        public void PrintStatistics()
        {
            Console.WriteLine("Команда 1:");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(string.Format("1. Воин - {0} HP", Warrior1.HP));
            Console.WriteLine(string.Format("2. Маг - {0} HP", Mage1.HP));
            Console.WriteLine(string.Format("3. Жрец - {0} HP", Priest1.HP));
            Console.WriteLine("=================================");
            Console.WriteLine("Команда 2:");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(string.Format("1. Воин - {0} HP", Warrior2.HP));
            Console.WriteLine(string.Format("2. Маг - {0} HP", Mage2.HP));
            Console.WriteLine(string.Format("3. Жрец - {0} HP", Priest2.HP));
            Console.WriteLine("=================================");
        }

        public bool IsEnd()
        {
            if (Warrior1.HP <= 0 && Mage1.HP <= 0 && Priest1.HP <= 0)
            {
                Console.WriteLine("Победила команда 2!");
                return true;
            }

            if (Warrior2.HP <= 0 && Mage2.HP <= 0 && Priest2.HP <= 0)
            {
                Console.WriteLine("Победила команда 1!");
                return true;
            }

            return false;
        }

        public void Action1(int character, int target)
        {
            switch (character)
            {
                case 1:
                    if (Warrior1.IsDead)
                    {
                        return;
                    }

                    switch (target)
                    {
                        case 1:
                            Warrior1.Blow(Warrior2);
                            break;
                        case 2:
                            Warrior1.Blow(Mage2);
                            break;
                        case 3:
                            Warrior1.Blow(Priest2);
                            break;
                    }
                    break;

                case 2:
                    if (Mage1.IsDead)
                    {
                        return;
                    }

                    switch (target)
                    {
                        case 1:
                            Mage1.Fireball(Warrior2);
                            break;
                        case 2:
                            Mage1.Fireball(Mage2);
                            break;
                        case 3:
                            Mage1.Fireball(Priest2);
                            break;
                    }
                    break;

                case 3:
                    if (Priest1.IsDead)
                    {
                        return;
                    }

                    switch (target)
                    {
                        case 1:
                            Priest1.Heal(Warrior1);
                            break;
                        case 2:
                            Priest1.Heal(Mage1);
                            break;
                        case 3:
                            Priest1.Heal(Priest1);
                            break;
                    }
                    break;
            }
        }

        public void Action2(int character, int target)
        {
            switch (character)
            {
                case 1:
                    if (Warrior2.IsDead)
                    {
                        return;
                    }

                    switch (target)
                    {
                        case 1:
                            Warrior2.Blow(Warrior1);
                            break;
                        case 2:
                            Warrior2.Blow(Mage1);
                            break;
                        case 3:
                            Warrior2.Blow(Priest1);
                            break;
                    }
                    break;
                case 2:
                    if (Mage2.IsDead)
                    {
                        return;
                    }

                    switch (target)
                    {
                        case 1:
                            Mage2.Fireball(Warrior1);
                            break;
                        case 2:
                            Mage2.Fireball(Mage1);
                            break;
                        case 3:
                            Mage2.Fireball(Priest1);
                            break;
                    }
                    break;
                case 3:
                    if (Priest2.IsDead)
                    {
                        return;
                    }

                    switch (target)
                    {
                        case 1:
                            Priest2.Heal(Warrior2);
                            break;
                        case 2:
                            Priest2.Heal(Mage2);
                            break;
                        case 3:
                            Priest2.Heal(Priest2);
                            break;
                    }
                    break;
            }
        }

        public Warrior Warrior1 = new Warrior();
        public Mage Mage1 = new Mage();
        public Priest Priest1 = new Priest();
        public Warrior Warrior2 = new Warrior();
        public Mage Mage2 = new Mage();
        public Priest Priest2 = new Priest();
    }
}
