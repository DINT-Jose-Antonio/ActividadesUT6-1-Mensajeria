using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades_UT6__1____Comandos
{
    internal class ConsultaPersonaUserControlVM : ObservableRecipient
    {
        private Personas personaSeleccionada;

        public Personas PersonaSeleccionada
        {
            get => this.personaSeleccionada;
            set => this.SetProperty<Personas>(ref personaSeleccionada, value);
        }

        public ConsultaPersonaUserControlVM() => this.PersonaSeleccionada = WeakReferenceMessenger.Default.Send<PersonaSeleccionadaMessage>();
    }
}
