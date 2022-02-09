using Blazor.MyWebsites.Server.Models.Services.Application;
using Blazor.MyWebsites.Shared.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.PersonalWebSites.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WebSitesController : Controller
    {
        private readonly IWebSitesService webSitesService;

        public WebSitesController(IWebSitesService webSitesService)
        {
            this.webSitesService = webSitesService;
        }

        [HttpGet("LoadCompetenzePersonali")]
        public async Task<List<SkillPersonale>> GetAllCompetenzePersonali()
        {
            List<SkillPersonale> list = await webSitesService.GetCompetenzePersonali();
            return list;
        }

        [HttpGet("LoadCompetenzeTecniche")]
        public async Task<List<SkillTecnica>> GetAllCompetenzeTecniche()
        {
            List<SkillTecnica> list = await webSitesService.GetCompetenzeTecniche();
            return list;
        }

        [HttpGet("LoadCorsiOnline")]
        public async Task<List<OnlineCourse>> GetAllCorsiOnline()
        {
            List<OnlineCourse> list = await webSitesService.GetCorsiOnline();
            return list;
        }

        [HttpGet("LoadEsperienzeProfessionali")]
        public async Task<List<ProfessionalExperience>> GetAllEsperienzeProfessionali()
        {
            List<ProfessionalExperience> list = await webSitesService.GetEsperienzeProfessionali();
            return list;
        }
    }
}