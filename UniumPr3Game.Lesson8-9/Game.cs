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
                    if (!_command1[character - 1].IsDead)
                    {
                        _command1[character - 1].Action(_command2[target - 1]);
                    }

                    currentCommand = 2;
                }
                else
                {
                    if (!_command2[character - 1].IsDead)
                    {
                        _command2[character - 1].Action(_command1[target - 1]);
                    }

                    currentCommand = 1;
                }
            }
        }

        private void PrintStatistics()
        {
            Console.WriteLine("Команда 1:");
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < _command1.Length; ++i)
            {
                Console.WriteLine(string.Format("{0}. {1} - {2}/{3} HP",
                    i + 1, _command1[i].Name, _command1[i].HP, _command1[i].MaxHP));
            }
            Console.WriteLine("=================================");

            Console.WriteLine("Команда 2:");
            Console.WriteLine("---------------------------------");
            for (int i = 0; i < _command2.Length; ++i)
            {
                Console.WriteLine(string.Format("{0}. {1} - {2}/{3} HP",
                    i + 1, _command2[i].Name, _command2[i].HP, _command2[i].MaxHP));
            }
            Console.WriteLine("=================================");
        }
        private bool IsEnd()
        {
            for (int i = 0; i < _command1.Length; ++i)
            {
                if (!_command1[i].IsDead)
                {
                    break;
                }

                if (i == _command1.Length - 1)
                {
                    Console.WriteLine("Победила команда 2!");
                    return true;
                }
            }

            for (int i = 0; i < _command2.Length; ++i)
            {
                if (!_command2[i].IsDead)
                {
                    break;
                }

                if (i == _command2.Length - 1)
                {
                    Console.WriteLine("Победила команда 2!");
                    return true;
                }
            }

            return false;
        }

        private readonly Character[] _command1 = new Character[] { new Warrior(), new Mage(), new Priest() };
        private readonly Character[] _command2 = new Character[] { new Warrior(), new Mage(), new Priest() };
    }
}
