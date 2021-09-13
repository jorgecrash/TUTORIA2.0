using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Ficha
    {
        private string _IdFichaTutoria;
        private string _IdTutoria;
        private string _IdEstudiante;
        private string _NroCelular;
        private string _Direccion;
        private string _Email;
        private string _PersonaReferencia;
        private string _CelularReferencia;
        private string _Fecha;
        private string _TipoTutoria;
        private string _Descripcion;
        private string search;
        private string _usuario;

        public string IdFichaTutoria { get => _IdFichaTutoria; set => _IdFichaTutoria = value; }
        public string IdTutoria { get => _IdTutoria; set => _IdTutoria = value; }
        public string IdEstudiante { get => _IdEstudiante; set => _IdEstudiante = value; }
        public string NroCelular { get => _NroCelular; set => _NroCelular = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string PersonaReferencia { get => _PersonaReferencia; set => _PersonaReferencia = value; }
        public string CelularReferencia { get => _CelularReferencia; set => _CelularReferencia = value; }
        public string Fecha { get => _Fecha; set => _Fecha = value; }
        public string TipoTutoria { get => _TipoTutoria; set => _TipoTutoria = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string Search { get => search; set => search = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
    }
}
