using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OtusKuberLab.Repository.Runtime;

namespace OtusKuberLab
{
    public class Startup
    {
        public Startup( IConfiguration configuration )
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices( IServiceCollection services )
        {
            services.AddControllers();
            services.AddOtusKuberLabContext();
            services.AddSwaggerGen();

            services.AddApplicationInsightsTelemetry();

            services.AddOtusKuberLabDbContext( "Data Source=DEVSQL;Initial Catalog=zakhar_otus;Persist Security Info=True;Integrated Security=SSPI" );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure( IApplicationBuilder app, IWebHostEnvironment env )
        {
            if ( env.IsDevelopment() )
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseSwagger();

            app.UseSwaggerUI();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints( endpoints =>
             {
                 endpoints.MapControllers();
             } );
        }
    }
}
