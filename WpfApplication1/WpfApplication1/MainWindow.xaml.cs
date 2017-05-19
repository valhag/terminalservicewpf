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
using System.Windows.Navigation;
using System.Windows.Shapes;

//Properties.Settings.Default.Reset()
//C:\Program Files(x86)\Skype\Phone\Skype.exe
//C:\Program Files\Notepad++\notepad++.exe

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        public class reg
        {
            public bool bandera;
            public string ruta;
        }


        private void setearsettings()
        {
            Properties.Settings.Default.ComercialHabilitado = "0";
            Properties.Settings.Default.ComercialRuta = "";
            Properties.Settings.Default.ContabilidadHabilitado = "0";
            Properties.Settings.Default.ContabilidadRuta = "";
            Properties.Settings.Default.FEHabilitado = "0";
            Properties.Settings.Default.FERuta = "";

            Properties.Settings.Default.NominasRuta = "";
            Properties.Settings.Default.NominasHabilitado = "0";
            Properties.Settings.Default.BancosRuta = "";
            Properties.Settings.Default.BancosHabilitado = "0";

            Properties.Settings.Default.XMLRuta = "";
            Properties.Settings.Default.XMLHabilitado = "0";

            Properties.Settings.Default.AdminpaqRuta = "";
            Properties.Settings.Default.AdminpaqHabilitado = "0";
            Properties.Settings.Default.ProduccionRuta = "";
            Properties.Settings.Default.ProduccionHabilitado = "0";




            if (chkComercial.IsChecked == true)
            {

                Properties.Settings.Default.ComercialHabilitado = "1";
                if (TxtComercial.Text == string.Empty)
                {
                    MessageBox.Show("Comercial esta habilitado pero no tiene ruta del exe, configuralo e intentalo de nuevo");
                    return;
                }
                Properties.Settings.Default.ComercialRuta = TxtComercial.Text;
            }

            if (chkContabilidad.IsChecked == true)
            {
                Properties.Settings.Default.ContabilidadHabilitado = "1";
                if (TxtContabilidad.Text == string.Empty)
                {
                    MessageBox.Show("Contabilidad esta habilitado pero no tiene ruta del exe, configuralo e intentalo de nuevo");
                    return;
                }
                Properties.Settings.Default.ContabilidadRuta = TxtContabilidad.Text;
            }

            if (chkFE.IsChecked == true)
            {
                Properties.Settings.Default.FEHabilitado = "1";
                if (TxtFE.Text == string.Empty)
                {
                    MessageBox.Show("Factura Electronica esta habilitado pero no tiene ruta del exe, configuralo e intentalo de nuevo");
                    return;
                }
                Properties.Settings.Default.FERuta = TxtFE.Text;
            }

            if (chkBancos.IsChecked == true)
            {
                Properties.Settings.Default.BancosHabilitado = "1";
                if (TxtBancos.Text == string.Empty)
                {
                    MessageBox.Show("Bancos esta habilitado pero no tiene ruta del exe, configuralo e intentalo de nuevo");
                    return;
                }
                Properties.Settings.Default.BancosRuta = TxtBancos.Text;
            }

            if (chkAdminpaq.IsChecked == true)
            {
                Properties.Settings.Default.AdminpaqHabilitado = "1";
                if (TxtAdminpaq.Text == string.Empty)
                {
                    MessageBox.Show("Adminpaq esta habilitado pero no tiene ruta del exe, configuralo e intentalo de nuevo");
                    return;
                }
                Properties.Settings.Default.AdminpaqRuta = TxtAdminpaq.Text;
            }

            if (chkNominas.IsChecked == true)
            {
                Properties.Settings.Default.NominasHabilitado = "1";
                if (TxtNominas.Text == string.Empty)
                {
                    MessageBox.Show("Nominas esta habilitado pero no tiene ruta del exe, configuralo e intentalo de nuevo");
                    return;
                }
                Properties.Settings.Default.NominasRuta = TxtNominas.Text;
            }
            if (chkProduccion.IsChecked == true)
            {
                Properties.Settings.Default.ProduccionHabilitado = "1";
                if (TxtProduccion.Text == string.Empty)
                {
                    MessageBox.Show("Produccion esta habilitado pero no tiene ruta del exe, configuralo e intentalo de nuevo");
                    return;
                }
                Properties.Settings.Default.ProduccionRuta = TxtProduccion.Text;
            }

            if (chkXMLEnlinea.IsChecked == true)
            {
                Properties.Settings.Default.XMLHabilitado = "1";
                if (TxtXMLEnlinea.Text == string.Empty)
                {
                    MessageBox.Show("XML EN LINEA esta habilitado pero no tiene ruta del exe, configuralo e intentalo de nuevo");
                    return;
                }
                Properties.Settings.Default.XMLRuta = TxtXMLEnlinea.Text;
            }
        }
        private void button_Click_1(object sender, RoutedEventArgs e)
        {

            // VALIDAR QUE cualquier checbox habilitado tenga ruta asignada

            setearsettings();
            


        

            

            Window1 x = new Window1();
            x.mCambiaTitulo("Empresa");
            x.Show();
            
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.unodostres = "unodostres";
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            this.Title = "Generador";
        }
    }
}
