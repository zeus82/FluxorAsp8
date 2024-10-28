using Fluxor;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorAppDotNet8.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddFluxor(options => options.ScanAssemblies(typeof(Program).Assembly));
            await builder.Build().RunAsync();
        }
    }
}
