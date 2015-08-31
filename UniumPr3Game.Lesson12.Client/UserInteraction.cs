using System;
using UniumPr3Game.Core;
using UniumPr3Game.Core.Characters;
using UniumPr3Game.Core.Characters.Skills;

namespace UniumPr3Game.Client
{
    internal class UserInteraction : IUserInteraction
    {
        public void ShowStatistics(Team[] teams)
        {
            foreach (Team team in teams)
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
        public void ShowSkills(Character character)
        {
            for (int i = 0; i < character.Skills.Length; ++i)
            {
                Skill skill = character.Skills[i];
                Console.WriteLine(string.Format("{0}. {1} - {2} ({3})",
                    i + 1, skill.Title, skill.Rate, skill.Energy));
            }
        }
        public void ShowLosingTeam(string team)
        {
            Console.WriteLine("Проиграла команда {0}!", team);
        }

        public int SelectCharacter(string team)
        {
            Console.Write(string.Format("Ход команды {0}. Выбери персонажа (1-3): ", team));
            return int.Parse(Console.ReadLine());
        }
        public int SelectSkill()
        {
            Console.Write("Выбери способность (1-2): ");
            return int.Parse(Console.ReadLine());
        }
        public int SelectTarget()
        {
            Console.Write("Выбери цель (1-3): ");
            return int.Parse(Console.ReadLine());
        }
    }
}
