using Microsoft.Extensions.DependencyInjection;
using Soenneker.Cloudflare.Downloader.Registrars;
using Soenneker.Kiota.Util.Registrars;
using Soenneker.Managers.Runners.Registrars;
using Soenneker.OpenApi.Fixer.Registrars;
using Soenneker.Wikimedia.Runners.OpenApiClient.Utils;
using Soenneker.Wikimedia.Runners.OpenApiClient.Utils.Abstract;

namespace Soenneker.Wikimedia.Runners.OpenApiClient;

/// <summary>
/// Console type startup
/// </summary>
public static class Startup
{
    // This method gets called by the runtime. Use this method to add services to the container.
    public static void ConfigureServices(IServiceCollection services)
    {
        services.SetupIoC();
    }

    public static IServiceCollection SetupIoC(this IServiceCollection services)
    {
        services.AddHostedService<ConsoleHostedService>()
                .AddScoped<IFileOperationsUtil, FileOperationsUtil>()
                .AddRunnersManagerAsScoped()
                .AddKiotaUtilAsScoped()
                .AddCloudflareDownloaderAsScoped()
                .AddOpenApiFixerAsScoped();

        return services;
    }
}