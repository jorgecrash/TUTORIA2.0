using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Estudiante
    {
       // private int _IdEstudiante;
        private string _CodEstudiante;
        private string _Nombres;
        private string _Apellidos;
        private string _SemestreActivo;
       // private string _Estudiante;
        private string _EscuelaProfesional;
        private string _CodEP;
        private string _AIngreso;
        private string search;
        //public int IdEstudiante { get => _IdEstudiante; set => _IdEstudiante = value; }
        public string CodEstudiante { get => _CodEstudiante; set => _CodEstudiante = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string SemestreActivo { get => _SemestreActivo; set => _SemestreActivo = value; }
      //  public string Estudiante { get => _Estudiante; set => _Estudiante = value; }
        public string EscuelaProfesional { get => _EscuelaProfesional; set => _EscuelaProfesional = value; }
        public string CodEP { get => _CodEP; set => _CodEP = value; }
        public string AIngreso { get => _AIngreso; set => _AIngreso = value; }
        public string Search { get => search; set => search = value; }
    }
}
