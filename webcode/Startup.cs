using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webcode
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

            services.AddControllersWithViews();
            services.AddHttpContextAccessor();
            services.AddDistributedMemoryCache();
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(60);//You can set Time   
            });

            //services.AddMvc();
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
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            
            app.UseSession();

            //app.UseMvc();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Home",
                    pattern: "",
                    defaults: new { controller = "Home", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "login",
                    pattern: "login",
                    defaults: new { controller = "Home", action = "Login" });

                endpoints.MapControllerRoute(
                    name: "register",
                    pattern: "register/{rid?}",
                    defaults: new { controller = "Home", action = "Registration" });

                endpoints.MapControllerRoute(
                    name: "about",
                    pattern: "about",
                    defaults: new { controller = "Home", action = "About" });

                endpoints.MapControllerRoute(
                    name: "contact",
                    pattern: "contact",
                    defaults: new { controller = "Home", action = "Contact" });

                endpoints.MapControllerRoute(
                    name: "Products",
                    pattern: "products",
                    defaults: new { controller = "Home", action = "Products" });

                endpoints.MapControllerRoute(
                    name: "Disclaimer",
                    pattern: "disclaimer",
                    defaults: new { controller = "Home", action = "Disclaimer" });

                endpoints.MapControllerRoute(
                    name: "Terms",
                    pattern: "terms",
                    defaults: new { controller = "Home", action = "Terms" });

                endpoints.MapControllerRoute(
                    name: "Privacy",
                    pattern: "privacy",
                    defaults: new { controller = "Home", action = "Privacy" });

                endpoints.MapControllerRoute(
                    name: "success-registration",
                    pattern: "success-registration/{id?}",
                    defaults: new { controller = "Home", action = "SuccessRegistration" });

                endpoints.MapControllerRoute(
                    name: "email-verification",
                    pattern: "email-verification/{regno?}/{otpcode?}",
                    defaults: new { controller = "Home", action = "EmailVerification" });

                endpoints.MapControllerRoute(
                    name: "forget-password",
                    pattern: "forget-password",
                    defaults: new { controller = "Home", action = "ForgetPassword" });

                endpoints.MapControllerRoute(
                    name: "blog",
                    pattern: "blog",
                    defaults: new { controller = "Home", action = "Blog" });

                endpoints.MapControllerRoute(
                    name: "blog/what-is-baap-network",
                    pattern: "blog/what-is-baap-network",
                    defaults: new { controller = "Home", action = "BlogContent1" });

                endpoints.MapControllerRoute(
                    name: "blog/how-does-baap-network-work",
                    pattern: "blog/how-does-baap-network-work",
                    defaults: new { controller = "Home", action = "BlogContent2" });

                endpoints.MapControllerRoute(
                    name: "Member-Success",
                    pattern: "Member/Success/{id?}",
                    defaults: new { controller = "Member", action = "SuccessFormPost" });

                endpoints.MapControllerRoute(
                    name: "forget-password",
                    pattern: "forget-password",
                    defaults: new { controller = "Home", action = "ForgetPassword" });

                endpoints.MapControllerRoute(
                    name: "Ho-Success",
                    pattern: "Ho/Success/{id?}",
                    defaults: new { controller = "HO", action = "SuccessFormPost" });

              endpoints.MapControllerRoute(
                    name: "Lucky-draw-registration",
                    pattern: "lucky-draw-registration",
                    defaults: new { controller = "Home", action = "LuckyDrawRegistration" });

              endpoints.MapControllerRoute(
                    name: "Lucky-draw-list",
                    pattern: "lucky-draw-member",
                    defaults: new { controller = "Home", action = "OpenLuckyDraw" });

              endpoints.MapControllerRoute(
                    name: "Lucky-draw-play",
                    pattern: "play-lucky-draw",
                    defaults: new { controller = "Home", action = "PlayLuckydraw" });

              endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
