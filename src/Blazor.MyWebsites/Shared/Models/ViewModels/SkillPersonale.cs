using Blazor.MyWebsites.Shared.Models.Entities;

namespace Blazor.MyWebsites.Shared.Models.ViewModels
{
    public class SkillPersonale
    {
        public int Id { get; set; }
        public string AreaTecnica { get; set; }
        public string Competenza { get; set; }

        public static SkillPersonale FromEntity(CompetenzaPersonale skill)
        {
            return new SkillPersonale
            {
                Id = skill.Id,
                AreaTecnica = skill.AreaTecnica,
                Competenza = skill.Competenza
            };
        }
    }
}
