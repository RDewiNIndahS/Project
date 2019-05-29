using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjectGetPost.Models;
using ProjectGetPost.Services;
using Microsoft.EntityFrameworkCore;

namespace ProjectGetPost
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<DbContex>(x => x.UseSqlServer(Configuration["ConnectionString"]));
            services.AddScoped<IAPP_MINIMUM_DE, APP_MINIMUM_DESERVICE>();
            services.AddScoped<IAPP_SPOUSE, APP_SPOUSEService>();
            services.AddScoped<IAPP_OTHERCOLDETAILS, APP_OTHERCOLDETAILService>();
            services.AddScoped<IRFDETAILCOLLATERAL, RFDETAILCOLLATERALService>();
            services.AddScoped<IRFCOLTYPE, RFCOLTYPEService>();
            services.AddScoped<ICOLLATERAL, COLLATERALService>();
            services.AddScoped<IAPP_COLMESIN, APP_COLMESINService>();
            services.AddScoped<IAPP_COLKENDARAAN, APP_COLKENDARAANService>();
            services.AddScoped<IAPP_COLTANAHBANGUNAN, APP_COLTANAHBANGUNANService>();
            services.AddScoped<IAPP_COLSURATBERHARGA, APP_COLSURATBERHARGAService>();
            var appSettingSection = Configuration.GetSection("AppSettings");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
