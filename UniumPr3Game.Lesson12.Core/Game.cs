using UniumPr3Game.Core.Characters;
using UniumPr3Game.Core.Characters.Skills;

namespace UniumPr3Game.Core
{
    public sealed class Game
    {
        public Game(IUserInteraction userInteraction)
        {
            _userInteraction = userInteraction;

            CreateTeams();
        }

        public void Start()
        {
            Team activeTeam = _teams[0];
            Team passiveTeam = _teams[1];

            while (!IsEnd())
            {
                _userInteraction.ShowStatistics(_teams);

                int characterIndex = _userInteraction.SelectCharacter(activeTeam.Name);
                Character character = activeTeam.Members[characterIndex - 1];

                _userInteraction.ShowSkills(character);

                int skillIndex = _userInteraction.SelectSkill();
                Skill skill = character.Skills[skillIndex - 1];

                int targetIndex = _userInteraction.SelectTarget();
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

        private bool IsEnd()
        {
            foreach (Team team in _teams)
            {
                if (team.IsDead())
                {
                    _userInteraction.ShowLosingTeam(team.Name);
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
        private readonly IUserInteraction _userInteraction;
    }
}
