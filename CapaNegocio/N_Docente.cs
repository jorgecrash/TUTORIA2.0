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
    public class N_Docente
    {
        D_Docente data = new D_Docente();
        E_Docente entities = new E_Docente();

        public DataTable ListingDocente()
        {
            return data.ListDocente();
        }
        public DataTable SearchingDocente(string search)
        {
            entities.Search = search;
            return data.SearchDocente(entities);
        }

        public void CreatingDocente(E_Docente product)
        {
            data.CreateDocente(product);
        }

        public void UpdatingDocente(E_Docente product)
        {
            data.UpdateDocente(product);
        }

        public void DeletingDocente(string id)
        {
          data.DeleteDocente(id);
          
        }
    }
}
