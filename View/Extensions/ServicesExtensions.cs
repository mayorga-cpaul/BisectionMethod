using Microsoft.Extensions.DependencyInjection;
using NumericMethod.Services.Interfaces;
using NumericMethod.Services.Util;
using View.Components;
using View.Forms;

namespace View.Extensions;

public static class ServicesExtensions
{
    public static ServiceCollection AddServices(this ServiceCollection services)
    {
        services.AddScoped<IAproximateMethods, AproximateMethods>();
        services.AddScoped<FrmMain>();
        return services;
    }
}
