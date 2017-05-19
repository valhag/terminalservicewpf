using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Diagnostics;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }
        
        public void mCambiaTitulo(string uno)
        {
            this.Title = uno;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            btnComercial.IsEnabled = false;
            btnComercial.Content = "Opcion No disponible";
            btnContabilidad.IsEnabled = false;
            btnContabilidad.Content = "Opcion No disponible";
            btnFE.IsEnabled = false;
            btnFE.Content = "Opcion No disponible";
            btnXML.IsEnabled = false;
            btnXML.Content = "Opcion No disponible";
            btnNominas.IsEnabled = false;
            btnNominas.Content = "Opcion No disponible";
            btnBancos.IsEnabled = false;
            btnBancos.Content = "Opcion No disponible";
            btnAdminpaq.IsEnabled = false;
            btnAdminpaq.Content = "Opcion No disponible";
            btnProduccion.IsEnabled = false;
            btnProduccion.Content = "Opcion No disponible";

            if (Properties.Settings.Default.ComercialHabilitado == "1")
            {
                btnComercial.IsEnabled = true;
                btnComercial.Content = "";
            }
            if (Properties.Settings.Default.ContabilidadHabilitado == "1")
            {
                btnContabilidad.IsEnabled = true;
                btnContabilidad.Content = "";
            }
            if (Properties.Settings.Default.FEHabilitado == "1")
            {
                btnFE.IsEnabled = true;
                btnFE.Content = "";
            }
            if (Properties.Settings.Default.BancosHabilitado == "1")
            {
                btnBancos.IsEnabled = true;
                btnBancos.Content = "";
            }
            if (Properties.Settings.Default.NominasHabilitado == "1")
            {
                btnNominas.IsEnabled = true;
                btnNominas.Content = "";
            }
            if (Properties.Settings.Default.XMLHabilitado == "1")
            {
                btnXML.IsEnabled = true;
                btnXML.Content = "";
            }
            if (Properties.Settings.Default.ProduccionHabilitado == "1")
            { 
                btnProduccion.IsEnabled = true;
                btnProduccion.Content = "";
            }
            if (Properties.Settings.Default.AdminpaqHabilitado == "1")
            {
                btnAdminpaq.IsEnabled = true;
                btnAdminpaq.Content = "";
            }

            this.Title = "Selector Sistemas Contpaqi";

        }

        private void btnBancos_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(Properties.Settings.Default.BancosRuta);
        }

        private void btnContabilidad_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(Properties.Settings.Default.ContabilidadRuta);
        }

        private void btnFE_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(Properties.Settings.Default.FERuta);
        }

        private void btnXML_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(Properties.Settings.Default.XMLRuta);
        }

        private void btnComercial_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(Properties.Settings.Default.ComercialRuta);
        }

        private void btnNominas_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(Properties.Settings.Default.NominasRuta);
        }

        private void btnAdminpaq_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(Properties.Settings.Default.AdminpaqRuta);
        }

        private void btnProduccion_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(Properties.Settings.Default.ProduccionRuta);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            Process p = new Process();
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.FileName = "batch.bat";
            p.Start();
            //System.Diagnostics.Process.Start("batch.bat");
            string output = p.StandardOutput.ReadToEnd();

            int pos = output.IndexOf("Current RDP Session ID:", 0);
            string casi = output.Substring(pos+24);
            int pos1 = casi.IndexOf(Environment.NewLine, 0);
            string numero = casi.Substring(0, pos1-1);


//            Current RDP Session ID: 2

            p.WaitForExit();

            string strCmdText;
            strCmdText = "logoff "+ numero;
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);


        }
    }
}
