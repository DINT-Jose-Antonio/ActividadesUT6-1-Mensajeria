using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades_UT6__1____Comandos
{
    class PersonasService
    {
        public ObservableCollection<Personas> ObtenerPersonas()
        {
            ObservableCollection<Personas> observableCollection = new ObservableCollection<Personas>();
            observableCollection.Add(new Personas("Pietro", 30, "Italiana"));
            observableCollection.Add(new Personas("Julia", 25, "Española"));
            observableCollection.Add(new Personas("Sophie", 35, "Francesa"));
            return observableCollection;
        }
    }
}
