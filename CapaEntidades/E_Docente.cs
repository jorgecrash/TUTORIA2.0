using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Docente
    {
        private string _IdDocente;
        private string _Nombres;
        private string _Apellidos;
        private string _TituloAcademico;
        private string _Facultad;
        private string _EscuelaProfesional;
        private string _Categoria;

        private string search;
        public E_Docente()
        {
                
        }
        public E_Docente(string idDocente,string nombres, string apellidos, string tituloacademico,string facultad, string ep,string categoria)
        {

            _IdDocente = idDocente;
            _Nombres = nombres;
            _Apellidos = apellidos;
            _TituloAcademico = tituloacademico;
            _Facultad = facultad;
            _EscuelaProfesional = ep;
            _Categoria = categoria;
        }
        public string IdDocente { get => _IdDocente; set => _IdDocente = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string TituloAcademico { get => _TituloAcademico; set => _TituloAcademico = value; }
        public string Facultad { get => _Facultad; set => _Facultad = value; }
        public string EscuelaProfesional { get => _EscuelaProfesional; set => _EscuelaProfesional = value; }
        public string Search { get => search; set => search = value; }
        public string Categoria { get => _Categoria; set => _Categoria = value; }
    }
}
