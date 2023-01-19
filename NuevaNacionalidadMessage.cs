using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades_UT6__1____Comandos
{
    public class NuevaNacionalidadMessage : ValueChangedMessage<string>
    {
        public NuevaNacionalidadMessage(string nuevaNacionalidad) : base(nuevaNacionalidad)
        {
        }
    }
}
