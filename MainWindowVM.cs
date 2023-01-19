using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Actividades_UT6__1____Comandos
{
    public class MainWindowVM : ObservableObject
    {
        private NavigationService navegacion;
        private UserControl contenidoVentana;

        public RelayCommand AbrirNuevaPersonaCommand { get; }

        public RelayCommand AbrirListadoPersonasCommand { get; }

        public RelayCommand AbrirConsultaPersonaCommand { get; }

        public UserControl ContenidoVentana
        {
            get
            {
                return contenidoVentana;
            }

            set
            {
                SetProperty(ref contenidoVentana, value);
            }
        }

        public MainWindowVM()
        {
            navegacion = new NavigationService();
            AbrirListadoPersonasCommand = new RelayCommand(AbrirListadoPersonas);
            AbrirNuevaPersonaCommand = new RelayCommand(AbrirNuevaPersona);
            AbrirConsultaPersonaCommand = new RelayCommand(AbrirConsultaPersona);
        }

        private void AbrirNuevaPersona()
        {
            ContenidoVentana = navegacion.ObtenerNuevaPersona();
        }

        private void AbrirListadoPersonas()
        {
            ContenidoVentana = navegacion.ObtenerListadoPersonas();
        }

        private void AbrirConsultaPersona() => ContenidoVentana = navegacion.ObtenerConsultaPersona();
    }
}
