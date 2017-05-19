using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication1
{
    class Class1
    {
            [STAThread]
            static void Main()
            {
                App app = new App();
                if (Properties.Settings.Default.unodostres == "Administrador")
                    app.MainWindow = new MainWindow();
                else
                    app.MainWindow = new Window1();

                app.MainWindow.Show();
                app.Run();
        }
    }
}
