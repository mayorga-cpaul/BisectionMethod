using Microsoft.Extensions.DependencyInjection;
using View.Extensions;
using View.Forms;
using View.Utils;

namespace View
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            services.AddServices();

            ApplicationConfiguration.Initialize();

            using (var serivceScope = services.BuildServiceProvider())
            {
                ServicesReq.ServiceProvider = serivceScope;
                var main = serivceScope.GetRequiredService<FrmMain>();
                Application.Run(main);
            }

        }
    }
}