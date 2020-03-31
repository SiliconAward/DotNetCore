using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SiliconAward.DataAccess.Data;
using SiliconAward.DataAccess.SqlClient;
using SiliconAward.Service.CustomLogServices;
using SiliconAward.Service.SqlClient;
using Microsoft.EntityFrameworkCore;
using SiliconAward.DataAccess.Entities.Identities;
using SiliconAward.Service.UserServices;
using NToastNotify;
using SiliconAward.DataAccess.Repositories.CustomLogRepositories;
using Newtonsoft.Json.Serialization;

namespace SiliconAward
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

            services.AddIdentityCore<AspNetUsers>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
            // Add the Kendo UI services to the services container.
            services.AddKendo();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddMvc().AddNToastNotifyNoty(new NotyOptions
            {
                ProgressBar = true,
                Timeout = 5000,
                Theme = "metroui"
            })
                .AddNewtonsoftJson(
                options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());

            services.AddControllersWithViews().AddRazorRuntimeCompilation();


            services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("DbContext"),
        b => b.MigrationsAssembly("SiliconAward")));

            RegisterDI(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseCookiePolicy();
            app.UseNToastNotify();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=User}/{action=Register}/{id?}");
            });
        }

        public void RegisterDI(IServiceCollection services)
        {
            services.AddTransient<ISqlClient, SqlClient>();
            services.AddTransient<IWrapper, Wrapper>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ICustomLogService, CustomLogService>();
            services.AddTransient<ICustomLogRepository, CustomLogRepository>();

        }
    }
}
