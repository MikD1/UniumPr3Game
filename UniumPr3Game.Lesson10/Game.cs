using System;
using UniumPr3Game.Characters;

/*
 * Тут можно предложить ребятам сделать произвольное количество команд.
 * В начале игры нужно выбрать количество команд.
 * Соответственно нужно изменить логику этого класса.
 * 
 * Так же можно реализовать произвольное количество и тип персонажей в команде.
*/

namespace UniumPr3Game
{
    class Game
    {
        public Game()
        {
            CreateTeams();
        }

        public void Start()
        {
            Team activeTeam = _teams[0];
            Team passiveTeam = _teams[1];

            while (!IsEnd())
            {
                PrintStatistics();

                Console.Write(string.Format("Ход команды {0}. Выбери персонажа (1-3): ", activeTeam.Name));
                int character = int.Parse(Console.ReadLine());

                Console.Write("Выбери цель (1-3): ");
                int target = int.Parse(Console.ReadLine());

                if (!activeTeam.Members[character - 1].IsDead)
                {
                    activeTeam.Members[character - 1].Action(passiveTeam.Members[target - 1]);
                }

                Team tmp = activeTeam;
                activeTeam = passiveTeam;
                passiveTeam = tmp;
            }
        }

        private void PrintStatistics()
        {
            foreach (Team team in _teams)
            {
                Console.WriteLine(string.Format("Команда {0}:", team.Name));
                Console.WriteLine("---------------------------------");
                for (int i = 0; i < team.Members.Length; ++i)
                {
                    Console.WriteLine(string.Format("{0}. {1} - {2}/{3} HP",
                        i + 1, team.Members[i].Name, team.Members[i].HP, team.Members[i].MaxHP));
                }
                Console.WriteLine("=================================");
            }
        }
        private bool IsEnd()
        {
            foreach (Team team in _teams)
            {
                if (team.IsDead())
                {
                    Console.WriteLine("Проиграла команда {0}!", team.Name);
                    return true;
                }
            }

            return false;
        }

        private void CreateTeams()
        {
            _teams = new Team[2];
            _teams[0] = new Team("Dream Team", new Character[] { new Warrior(), new Mage(), new Priest() });
            _teams[1] = new Team("Team Dream", new Character[] { new Warrior(), new Mage(), new Priest() });
        }

        private Team[] _teams;
    }
}
