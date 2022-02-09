using Blazor.MyWebsites.Shared.Models.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.MyWebsites.Server.Models.Services.Application
{
    public interface IWebSitesService
    {
        Task<List<SkillPersonale>> GetCompetenzePersonali();
        Task<List<SkillTecnica>> GetCompetenzeTecniche();
        Task<List<OnlineCourse>> GetCorsiOnline();
        Task<List<ProfessionalExperience>> GetEsperienzeProfessionali();
    }
}