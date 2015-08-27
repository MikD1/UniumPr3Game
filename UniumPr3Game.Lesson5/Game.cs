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

        private void PrintStatistics()
        {
            Console.WriteLine("Команда 1:");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(string.Format("1. Воин - {0} HP", _warrior1.HP));
            Console.WriteLine(string.Format("2. Маг - {0} HP", _mage1.HP));
            Console.WriteLine(string.Format("3. Жрец - {0} HP", _priest1.HP));
            Console.WriteLine("=================================");
            Console.WriteLine("Команда 2:");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(string.Format("1. Воин - {0} HP", _warrior2.HP));
            Console.WriteLine(string.Format("2. Маг - {0} HP", _mage2.HP));
            Console.WriteLine(string.Format("3. Жрец - {0} HP", _priest2.HP));
            Console.WriteLine("=================================");
        }
        private bool IsEnd()
        {
            if (_warrior1.HP <= 0 && _mage1.HP <= 0 && _priest1.HP <= 0)
            {
                Console.WriteLine("Победила команда 2!");
                return true;
            }

            if (_warrior2.HP <= 0 && _mage2.HP <= 0 && _priest2.HP <= 0)
            {
                Console.WriteLine("Победила команда 1!");
                return true;
            }

            return false;
        }

        private void Action1(int character, int target)
        {
            switch (character)
            {
                case 1:
                    if (_warrior1.IsDead)
                    {
                        return;
                    }

                    switch (target)
                    {
                        case 1:
                            _warrior1.Blow(_warrior2);
                            break;
                        case 2:
                            _warrior1.Blow(_mage2);
                            break;
                        case 3:
                            _warrior1.Blow(_priest2);
                            break;
                    }
                    break;

                case 2:
                    if (_mage1.IsDead)
                    {
                        return;
                    }

                    switch (target)
                    {
                        case 1:
                            _mage1.Fireball(_warrior2);
                            break;
                        case 2:
                            _mage1.Fireball(_mage2);
                            break;
                        case 3:
                            _mage1.Fireball(_priest2);
                            break;
                    }
                    break;

                case 3:
                    if (_priest1.IsDead)
                    {
                        return;
                    }

                    switch (target)
                    {
                        case 1:
                            _priest1.Heal(_warrior1);
                            break;
                        case 2:
                            _priest1.Heal(_mage1);
                            break;
                        case 3:
                            _priest1.Heal(_priest1);
                            break;
                    }
                    break;
            }
        }
        private void Action2(int character, int target)
        {
            switch (character)
            {
                case 1:
                    if (_warrior2.IsDead)
                    {
                        return;
                    }

                    switch (target)
                    {
                        case 1:
                            _warrior2.Blow(_warrior1);
                            break;
                        case 2:
                            _warrior2.Blow(_mage1);
                            break;
                        case 3:
                            _warrior2.Blow(_priest1);
                            break;
                    }
                    break;
                case 2:
                    if (_mage2.IsDead)
                    {
                        return;
                    }

                    switch (target)
                    {
                        case 1:
                            _mage2.Fireball(_warrior1);
                            break;
                        case 2:
                            _mage2.Fireball(_mage1);
                            break;
                        case 3:
                            _mage2.Fireball(_priest1);
                            break;
                    }
                    break;
                case 3:
                    if (_priest2.IsDead)
                    {
                        return;
                    }

                    switch (target)
                    {
                        case 1:
                            _priest2.Heal(_warrior2);
                            break;
                        case 2:
                            _priest2.Heal(_mage2);
                            break;
                        case 3:
                            _priest2.Heal(_priest2);
                            break;
                    }
                    break;
            }
        }

        private readonly Warrior _warrior1 = new Warrior();
        private readonly Mage _mage1 = new Mage();
        private readonly Priest _priest1 = new Priest();
        private readonly Warrior _warrior2 = new Warrior();
        private readonly Mage _mage2 = new Mage();
        private readonly Priest _priest2 = new Priest();
    }
}
