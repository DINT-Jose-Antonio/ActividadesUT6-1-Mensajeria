using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Actividades_UT6__1____Comandos
{

        class NavigationService
        {
            private static UserControl listadoPersonas = new ListadoPersonasUserControl();

            public UserControl ObtenerNuevaPersona() => new NuevaPersonaUserControl();

            public UserControl ObtenerListadoPersonas() => listadoPersonas;

            public bool? AbrirDialogoNacionalidad() => new AñadirNacionalidad().ShowDialog();

            public UserControl ObtenerConsultaPersona() => new vistas.ConsultaPersonaUserControl();
        }
    }
