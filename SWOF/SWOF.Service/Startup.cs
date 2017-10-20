using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SWOF.Service.Services.Interfaces;
using SWOF.Service.Services;
using SWOF.Service.Repositories.Interface;
using SWOF.Service.Repositories;
using SWOF.Service.Infrastructure.Interface;
using SWOF.Service.Infrastructure;

namespace SWOF.Service
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
            //Configuration
            services.AddSingleton<IConfiguration>(Configuration);
            //Services
            services.AddSingleton<IScheduleService, ScheduleService>();
            services.AddSingleton<IShiftService, ShiftService>();
            services.AddSingleton<IEngineerService, EngineerService>();
            //Repository
            services.AddSingleton<IEngineerRepository, EngineerRepository>();
            //Connections
            services.AddSingleton<IConnection, ConnectionFactory>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
