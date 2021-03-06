using Bank.Repositories;
using Bank.Services;
using Bank.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Bank
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BankContext>(opt => opt.UseInMemoryDatabase("Bank"));

            services.AddControllers().AddJsonOptions(options => {
                options.JsonSerializerOptions.IgnoreNullValues = true;
            });          
            
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IEventService, EventService>();
            services.AddScoped<IResetService, ResetService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
