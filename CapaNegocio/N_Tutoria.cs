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
    public class N_Tutoria
    {
        D_Tutoria data = new D_Tutoria();
        E_Tutoria entities = new E_Tutoria();

        public DataTable ListingTutorias()
        {
            return data.ListTutorias();
        }
        public DataTable SearchingTutorias(string search)
        {
            entities.Search = search;
            return data.SearchTutorias(entities);
        }
        public DataTable BuscarDocenteTutorias(string search)
        {
            entities.BucarDocenteTutoria = search;
            return data.BuscarTutoriasDocente(entities);
        }
        public void CreatingTutoria(E_Tutoria product)
        {
            data.CreateTutoria(product);
        }

        public void UpdatingTutoria(E_Tutoria product)
        {
            data.UpdateTutoria(product);
        }

        public void DeletingTutoria(string Id)
        {
            data.DeleteTutoria(Id);
        }
        public DataTable ListingDocenteTutorias()
        {
            return data.ListDocenteTutoria();
        }
    }
}
