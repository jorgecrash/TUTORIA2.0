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
    public class N_Ficha
    {
        D_Ficha data = new D_Ficha();
        E_Ficha entities = new E_Ficha();

        public DataTable ListingHistorialEstudiante(string search)
        {
            entities.Search = search;
            return data.ListHistorialEstudiante(entities);
        }
        public DataTable ListingFichas(string search)
        {
            entities.Search = search;
            return data.ListFichas(entities);
        }
        public DataTable ListingEstudianteTutoria(string search)
        {
            entities.Search = search;
            return data.ListEstudianteTutoria(entities);
        }
        public DataTable SearchingFichas(string search)
        {
            entities.Search = search;
            return data.SearchFichas(entities);
        }
        public DataTable SearchingEstudiante_Tutoria(string search,string usuario)
        {
            entities.Usuario = usuario;
            entities.Search = search;
           
            return data.SearchEstudiante_Tutoria(entities);
        }

        public void CreatingFicha(E_Ficha product)
        {
            data.CreateFicha(product);
        }

        public void UpdatingFicha(E_Ficha product)
        {
            data.UpdateFicha(product);
        }

        public void DeletingFicha(string Id)
        {
            data.DeleteFicha(Id);
        }
    }
}
