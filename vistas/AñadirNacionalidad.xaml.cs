using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Actividades_UT6__1____Comandos
{
    /// <summary>
    /// Lógica de interacción para AñadirNacionalidad.xaml
    /// </summary>
    public partial class AñadirNacionalidad : Window
    {
        private AñadirNacionalidadVM vm;

        public AñadirNacionalidad()
        {
            InitializeComponent();
            vm = new AñadirNacionalidadVM();
            this.DataContext = vm;
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            vm.Aceptar();
            DialogResult = true;
        }
    }
}
