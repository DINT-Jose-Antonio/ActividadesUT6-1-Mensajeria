using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades_UT6__1____Comandos
{
    public class NuevaPersonaMessage : ValueChangedMessage<Personas>
    {
        public NuevaPersonaMessage(Personas nuevaPersona) : base(nuevaPersona)
        {
        }
    }
}
