using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades_UT6__1____Comandos
{
    public class AñadirNacionalidadVM : ObservableObject
    {
            private string nacionalidad;

            public string Nacionalidad
            {
                get => nacionalidad;
                set => SetProperty(ref nacionalidad, value);
            }

            public void Aceptar()
            {
            }
        }

    }
