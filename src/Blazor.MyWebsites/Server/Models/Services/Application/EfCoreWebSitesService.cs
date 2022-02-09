using Blazor.MyWebsites.Shared.Models.Entities;
using Blazor.MyWebsites.Shared.Models.ViewModels;
using Blazor.PersonalWebSites.Server.Models.Services.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.MyWebsites.Server.Models.Services.Application
{
    public class EfCoreWebSitesService : IWebSitesService
    {
        private readonly MyAppDbContext dbContext;

        public EfCoreWebSitesService(MyAppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<SkillPersonale>> GetCompetenzePersonali()
        {
            IQueryable<CompetenzaPersonale> baseQuery = dbContext.CompetenzePersonali;

            IQueryable<CompetenzaPersonale> queryLinq = baseQuery
                .AsNoTracking();

            List<SkillPersonale> skills = await queryLinq
                .Select(x => SkillPersonale.FromEntity(x))
                .ToListAsync();

            return skills.ToList();
        }

        public async Task<List<SkillTecnica>> GetCompetenzeTecniche()
        {
            IQueryable<CompetenzaTecnica> baseQuery = dbContext.CompetenzeTecniche;

            IQueryable<CompetenzaTecnica> queryLinq = baseQuery
                .AsNoTracking();

            List<SkillTecnica> skills = await queryLinq
                .Select(x => SkillTecnica.FromEntity(x))
                .ToListAsync();

            return skills.ToList();
        }

        public async Task<List<OnlineCourse>> GetCorsiOnline()
        {
            IQueryable<CorsoOnline> baseQuery = dbContext.CorsiOnline;

            IQueryable<CorsoOnline> queryLinq = baseQuery
                .AsNoTracking();

            List<OnlineCourse> skills = await queryLinq
                .Select(x => OnlineCourse.FromEntity(x))
                .ToListAsync();

            return skills.ToList();
        }

        public async Task<List<ProfessionalExperience>> GetEsperienzeProfessionali()
        {
            IQueryable<EsperienzaProfessionale> baseQuery = dbContext.EsperienzeProfessionali;

            IQueryable<EsperienzaProfessionale> queryLinq = baseQuery
                .AsNoTracking();

            List<ProfessionalExperience> experiences = await queryLinq
                .Select(x => ProfessionalExperience.FromEntity(x))
                .ToListAsync();

            return experiences.ToList();
        }
    }
}