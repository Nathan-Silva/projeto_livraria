using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using projeto_livraria.Data;
using Microsoft.AspNetCore.Http;
using projeto_livraria.Models;
using Repositories;
using projeto_livraria.Repositories;
using Microsoft.AspNetCore.Identity;

namespace AppWeb
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

            // using Microsoft.EntityFrameworkCore;
            services.AddDbContext<LivrariaContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("ConexaoSQLServer")));
            
            services.AddControllersWithViews();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddIdentity<IdentityUser,  IdentityRole>()
                .AddEntityFrameworkStores<LivrariaContext>()
                .AddDefaultTokenProviders();

            // adicionar um novo objeto para cada usuario
            services.AddScoped(cp => CarrinhoCompra.GetCarrinho(cp));

            services.AddTransient<ILivrosRepository, LivroRepository>();
            services.AddTransient<IVendaRepository, VendaRepository>();

            
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, LivrariaContext context)
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
            app.UseSession();
            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "AdminArea",
                    pattern: "{area:exists}/{controller=Admin}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            InicializaDB.Initialize(context);
        }
    }
}
