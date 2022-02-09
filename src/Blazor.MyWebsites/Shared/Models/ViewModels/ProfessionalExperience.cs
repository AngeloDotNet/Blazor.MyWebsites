using Blazor.MyWebsites.Shared.Models.Entities;

namespace Blazor.MyWebsites.Shared.Models.ViewModels
{
    public partial class ProfessionalExperience
    {
        public int Id { get; set; }
        public string Esperienza { get; set; }
        public string Periodo { get; set; }
        public string Azienda { get; set; }
        public string Luogo { get; set; }

        public static ProfessionalExperience FromEntity(EsperienzaProfessionale skill)
        {
            return new ProfessionalExperience
            {
                Id = skill.Id,
                Esperienza = skill.Esperienza,
                Periodo = skill.Periodo,
                Azienda = skill.Azienda,
                Luogo = skill.Luogo
            };
        }
    }
}