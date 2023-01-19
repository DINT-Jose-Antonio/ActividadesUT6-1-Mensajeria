using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace Actividades_UT6__1____Comandos
{
    public class NuevaPersonaUserControlVM : ObservableObject
    {
        private readonly NavigationService navegacion;
        private Personas nuevaPersona;
        private ObservableCollection<string> listaNacionalidades;

        public Personas NuevaPersona
        {
            get => nuevaPersona;
            set => SetProperty(ref nuevaPersona, value);
        }

        public ObservableCollection<string> ListaNacionalidades
        {
            get => listaNacionalidades;
            set => SetProperty(ref listaNacionalidades, value);
        }

        public RelayCommand NuevaNacionalidadCommand { get; }

        public NuevaPersonaUserControlVM()
        {
            navegacion = new NavigationService();
            NuevaPersona = new Personas();
            ObservableCollection<string> observableCollection = new ObservableCollection<string>();
            observableCollection.Add("Italiana");
            observableCollection.Add("Española");
            observableCollection.Add("Francesa");
            ListaNacionalidades = observableCollection;
            NuevaNacionalidadCommand = new RelayCommand(AñadirNacionalidad);
        }

        private void AñadirNacionalidad() => navegacion.AbrirDialogoNacionalidad();
    }
}
