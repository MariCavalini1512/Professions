using Microsoft.EntityFrameworkCore;
using ProfessionsContext.Data; 

namespace Professions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            // Configura��o para usar MySQL com a string de conex�o correta
            builder.Services.AddDbContext<ProfessionsContext>(options =>

                options.UseMySql(
                    builder.Configuration
                        .GetConnectionString("ProfessionsContext"),
                    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("ProfessionsContext"))
                    )
                );
            


            var app = builder.Build();

            // Configura��o do pipeline HTTP
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}

