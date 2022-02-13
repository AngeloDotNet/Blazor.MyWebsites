using Blazor.MyWebsites.Server.Models.Enums;
using Blazor.MyWebsites.Server.Models.Services.Application;
using Blazor.PersonalWebSites.Server.Models.Services.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Blazor.MyWebsites.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        private readonly string _policyName = "CorsPolicy";

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddRazorPages();

            services.AddCors(opt =>
            {
                opt.AddPolicy(name: _policyName, builder =>
                {
                    builder.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            });

            var persistence = Persistence.EfCore;
            switch (persistence)
            {
                case Persistence.EfCore:
                    services.AddDbContextPool<MyAppDbContext>(optionBuilder =>
                    {
                        string connectionString = Configuration.GetSection("ConnectionStrings").GetValue<string>("Default");
                        optionBuilder.UseSqlite(connectionString);
                    });

                    break;
            }

            services.AddSwaggerGen(config =>
            {
                config.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Blazor.MyWebSites",
                    Version = "v1",
                    // Description = "API example that returns the current time",
                    // TermsOfService = new Uri("https://example.com/terms"), 

                    // Contact = new OpenApiContact
                    // {
                    //     Name = "Nominativo contatto",
                    //     Email = "Email contatto",
                    //     Url = new Uri("https://twitter.com/username-contatto"),
                    // },

                    // License = new OpenApiLicense
                    // {
                    //     Name = "Nome licenza API",
                    //     Url = new Uri("https://example.com/license"),
                    // }
                });
            });

            services.AddTransient<IWebSitesService, EfCoreWebSitesService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebAssemblyDebugging();

                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Blazor.PersonalWebSites v1"));
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseCors(_policyName);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
