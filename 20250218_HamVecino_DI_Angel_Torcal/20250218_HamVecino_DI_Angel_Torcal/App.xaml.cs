using System.Windows;

namespace _20250218_HamVecino_DI_Angel_Torcal
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            // Establecer la cultura española
            System.Threading.Thread.CurrentThread.CurrentCulture =
                System.Globalization.CultureInfo.CreateSpecificCulture("es-ES");
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                System.Globalization.CultureInfo.CreateSpecificCulture("es-ES");
        }
    }
}
