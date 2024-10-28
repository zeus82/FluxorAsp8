using Fluxor;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorAppDotNet8.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            var currentAssembly = typeof(Program).Assembly;
            builder.Services.AddFluxor(options => options.ScanAssemblies(currentAssembly));
            await builder.Build().RunAsync();
        }
    }
}
