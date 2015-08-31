using System;
using UniumPr3Game.Core.Characters;

namespace UniumPr3Game.Core
{
    public interface IUserInteraction
    {
        void ShowStatistics(Team[] teams);
        void ShowSkills(Character character);
        void ShowLosingTeam(string team);

        int SelectCharacter(string team);
        int SelectSkill();
        int SelectTarget();
    }
}
