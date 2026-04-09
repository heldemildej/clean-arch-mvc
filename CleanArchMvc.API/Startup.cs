using CleanArchMvc.Application.Products.Handlers;
using CleanArchMvc.Infra.IoC;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Reflection;

namespace CleanArchMvc.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Configura serviços da aplicação
        public void ConfigureServices(IServiceCollection services)
        {
            // Adiciona Controllers
            services.AddControllers();

            // Adiciona Swagger para documentação da API
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "CleanArchMvc.API",
                    Version = "v1"
                });
            });

            // Registra serviços da nossa camada Infrastructure (IoC)
            services.AddInfrastructure(Configuration);

            // Registra MediatR para Commands e Queries
            services.AddMediatR(typeof(ProductCreateCommandHandler).Assembly);
        }

        // Configura o pipeline HTTP
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                // Swagger habilitado apenas em desenvolvimento
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "CleanArchMvc.API v1");
                });
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}