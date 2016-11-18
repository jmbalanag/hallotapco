using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Nancy.Owin;

namespace TapcoApiApplication
{
   public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            //    app.UseOwin(x => x.UseNancy());

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });


        }
   }
}