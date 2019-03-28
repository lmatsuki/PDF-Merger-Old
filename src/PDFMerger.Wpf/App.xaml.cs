using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PDFMerger.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            StartupUri = new Uri(@"Windows\MainWindow.xaml", UriKind.Relative);

            base.OnStartup(e);
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {

        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {

        }
    }
}
