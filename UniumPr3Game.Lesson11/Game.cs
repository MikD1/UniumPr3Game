using System;
using UniumPr3Game.Characters;
using UniumPr3Game.Characters.Skills;

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
                int characterIndex = int.Parse(Console.ReadLine());
                Character character = activeTeam.Members[characterIndex - 1];

                Console.WriteLine("");
                PrintSkills(character);
                Console.Write("Выбери способность (1-2): ");
                int skillIndex = int.Parse(Console.ReadLine());
                Skill skill = character.Skills[skillIndex - 1];

                Console.Write("Выбери цель (1-3): ");
                int targetIndex = int.Parse(Console.ReadLine());
                Character target = passiveTeam.Members[targetIndex - 1];

                if (!character.IsDead)
                {
                    skill.Action(character, target);
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
                    Character character = team.Members[i];
                    Console.WriteLine(string.Format("{0}. {1} - {2}/{3} HP - {4}/100 Энергии",
                        i + 1, character.Name, character.HP, character.MaxHP, character.Energy));
                }
                Console.WriteLine("=================================");
            }
        }
        private void PrintSkills(Character character)
        {
            for (int i = 0; i < character.Skills.Length; ++i)
            {
                Skill skill = character.Skills[i];
                Console.WriteLine(string.Format("{0}. {1} - {2} ({3})",
                    i + 1, skill.Title, skill.Rate, skill.Energy));
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
