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
    public class N_Registro
    {
        D_Registro data = new D_Registro();
        E_Registro entities = new E_Registro();

        public DataTable ListingTutorados()
        {
            return data.ListTutorados();
        }
        public DataTable ListingLISTAREGISTROESTUDIANTETUTORIA()
        {
            return data.LISTAREGISTROESTUDIANTETUTORIA();
        }
        public DataTable ListingLISTAREGISTRODOCENTETUTORIA()
        {
            return data.LISTAREGISTRODOCENTETUTORIA();
        }
        public DataTable SearchingTutorados(string search)
        {
            entities.Search = search;
            return data.SearchTutorados(entities);
        }
        public DataTable SearchingREGISTRO_TUTOR(string search)
        {
            entities.Search = search;
            return data.SearchREGISTRO_TUTOR(entities);
        }
        public DataTable SearchingREGISTRO_ESTUDIANTE(string search)
        {
            entities.Search = search;
            return data.SearchREGISTRO_ESTUDIANTE(entities);
        }

        public void CreatingTutorado(E_Registro product)
        {
            data.CreateTutorado(product);
        }

        public void UpdatingTutorado(E_Registro product)
        {
            data.UpdateTutorado(product);
        }

        public void DeletingTutorado(string Id)
        {
            data.DeleteTutorado(Id);
        }
    }
}
