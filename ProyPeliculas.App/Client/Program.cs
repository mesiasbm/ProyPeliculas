using System.Collections.Immutable;
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using crud.movies.Client.Services;

namespace ProyPeliculas.App.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            ConfiguracionServicios(builder.Services);
            await builder.Build().RunAsync();
        }
        private static void ConfiguracionServicios(IServiceCollection servicios) {
            servicios.addsingleton<IServiceMovie, ServiceMovie>();

        }


    }
}
