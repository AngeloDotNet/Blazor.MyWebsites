using Blazor.MyWebsites.Shared.Models.Entities;

namespace Blazor.MyWebsites.Shared.Models.ViewModels
{
    public class SkillTecnica
    {
        public int Id { get; set; }
        public string AreaTecnica { get; set; }
        public string Competenza { get; set; }

        public static SkillTecnica FromEntity(CompetenzaTecnica skill)
        {
            return new SkillTecnica
            {
                Id = skill.Id,
                AreaTecnica = skill.AreaTecnica,
                Competenza = skill.Competenza
            };
        }
    }
}
