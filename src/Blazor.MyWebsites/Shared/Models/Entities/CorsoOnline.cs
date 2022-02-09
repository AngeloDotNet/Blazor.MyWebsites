namespace Blazor.MyWebsites.Shared.Models.Entities
{
    public partial class CorsoOnline
    {
        public int Id { get; set; }
        public string Corso { get; set; }
        public string Piattaforma { get; set; }
        public string DataRilascio { get; set; }
        public string DataScadenza { get; set; }
        public string Certificato { get; set; }
    }
}
