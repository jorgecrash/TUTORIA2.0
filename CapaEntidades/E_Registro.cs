using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Registro
    {
        private string _IdTutoria;
        private string _IdEstudiante;

        private string search;

        public string IdTutoria { get => _IdTutoria; set => _IdTutoria = value; }
        public string IdEstudiante { get => _IdEstudiante; set => _IdEstudiante = value; }
        public string Search { get => search; set => search = value; }
    }
}
