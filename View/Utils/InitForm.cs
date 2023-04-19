using Microsoft.Extensions.DependencyInjection;
using View.Forms;

namespace View.Utils;

public static class InitForm
{
    public static Form GetView()
    {
        return ServicesReq.ServiceProvider.GetRequiredService<FrmMain>();
    }
}
