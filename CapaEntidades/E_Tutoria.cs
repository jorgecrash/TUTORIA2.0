using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Tutoria
    {
        private string _IdTutoria;
        private string _IdDocente;
        private string _Horario;

        private string search;
        private string _bucarDocenteTutoria;

        public string IdTutoria { get => _IdTutoria; set => _IdTutoria = value; }
        public string IdDocente { get => _IdDocente; set => _IdDocente = value; }
        public string Horario { get => _Horario; set => _Horario = value; }
        public string Search { get => search; set => search = value; }
        public string BucarDocenteTutoria { get => _bucarDocenteTutoria; set => _bucarDocenteTutoria = value; }
    }
}
