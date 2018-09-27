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
using OrdenacaoDados.ORDENACOES;
using OrdenacaoDados.UTILITARIOS;
using OrdenacaoDadosContrato.CONTRATO;

namespace OrdenacaoDadosAPI
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
            services.AddCors();
            services.AddMvc();
            services.AddSingleton<IBubleSort, BubleSort>();
            services.AddSingleton<ISelectionSort, SelectionSort>();
            services.AddSingleton<IInsertionSort, InsertionSort>();
            services.AddSingleton<IConverterValores, ConversaoValores>();
            services.AddSingleton<IFiles, ConversaoValores>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder => builder.WithOrigins("http://localhost:63342")
                                            .AllowAnyHeader()
                                            .AllowAnyMethod()
                                            .AllowAnyOrigin());

            app.UseMvc();
        }
    }
}
