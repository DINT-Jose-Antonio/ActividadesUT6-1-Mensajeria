using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades_UT6__1____Comandos
{
    internal class ListadoPersonasUserControlVM : ObservableObject
    {
        private readonly PersonasService servicioPersonas;
        private ObservableCollection<Personas> listaPersonas;
        private Personas personaSeleccionada;

        public ObservableCollection<Personas> ListaPersonas
        {
            get => listaPersonas;
            set => SetProperty(ref listaPersonas, value);
        }

        public Personas PersonaSeleccionada
        {
            get => personaSeleccionada;
            set => SetProperty(ref personaSeleccionada, value);
        }

        public ListadoPersonasUserControlVM()
        {
            this.servicioPersonas = new PersonasService();
            this.ListaPersonas = this.servicioPersonas.ObtenerPersonas();
            WeakReferenceMessenger.Default.Register(this, (MessageHandler<object, NuevaPersonaMessage>)((r, m) => ListaPersonas.Add(m.Value)));
            WeakReferenceMessenger.Default.Register(this, (MessageHandler<ListadoPersonasUserControlVM, PersonaSeleccionadaMessage>)((r, m) =>
            {
                if (m.HasReceivedResponse)
                    return;
                m.Reply(PersonaSeleccionada);
            }));
        }
    }
}
