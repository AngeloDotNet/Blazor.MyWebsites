using Blazor.MyWebsites.Shared.Models.Entities;

namespace Blazor.MyWebsites.Shared.Models.ViewModels
{
    public partial class OnlineCourse
    {
        public int Id { get; set; }
        public string Corso { get; set; }
        public string Piattaforma { get; set; }
        public string DataRilascio { get; set; }
        public string DataScadenza { get; set; }
        public string Certificato { get; set; }

        public static OnlineCourse FromEntity(CorsoOnline skill)
        {
            return new OnlineCourse
            {
                Id = skill.Id,
                Corso = skill.Corso,
                Piattaforma = skill.Piattaforma,
                DataRilascio = skill.DataRilascio,
                DataScadenza = skill.DataScadenza,
                Certificato = skill.Certificato
            };
        }
    }
}
