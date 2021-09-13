using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class N_Estudiante
    {
        D_Estudiante data = new D_Estudiante();
        E_Estudiante entities = new E_Estudiante();

        public DataTable ListingStudents()
        {
            return data.ListStudents();
        }
        public DataTable SearchingStudents(string search)
        {
            entities.Search = search;
            return data.SearchStudents(entities);
        }

        public void CreatingStudents(E_Estudiante product)
        {
            data.CreateStudent(product);
        }

        public void UpdatingStudents(E_Estudiante product)
        {
            data.UpdateStudent(product);
        }

        public void DeletingStudents(string CodEstudiante)
        {
            data.DeleteStudent(CodEstudiante);
        }
    }
}
