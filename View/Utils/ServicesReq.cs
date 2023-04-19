using Microsoft.Extensions.DependencyInjection;

namespace View.Utils;

internal static class ServicesReq
{
    public static ServiceProvider ServiceProvider { get; set; } = null!;
}
