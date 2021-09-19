
using CapaEntidades; 
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion
{
    public class ServiciosDocente
    {
        SqlConnection conexion = new SqlConnection("Server=tcp:unsaac-server.database.windows.net,1433;Initial Catalog=dbTUTORIA;Persist Security Info=False;User ID=adminxd;Password=5uLh3g5xd7BUWz;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public virtual bool eliminar_docente(string codigo)
        {
            int i;
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SP_ELIMINARDOCENTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDDOCENTE", codigo);
            i = cmd.ExecuteNonQuery();
            conexion.Close();
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //SERVISE  DOCENTE EDITAR
        public virtual bool Editar_Docente(string codigo, string Nombres, string Apellido, string Titulo, string Faculad, string EProfesional, string Categoria)
        {
            int i;
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SP_EDITARDOCENTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDDOCENTE", codigo);
            i = cmd.ExecuteNonQuery();
            cmd.Parameters.AddWithValue("@NOMBRES", Nombres);
            cmd.Parameters.AddWithValue("@APELLIDOS", Apellido);
            cmd.Parameters.AddWithValue("@TITULO", Titulo);
            cmd.Parameters.AddWithValue("@FACULTAD", Faculad);
            cmd.Parameters.AddWithValue("@EPROFESIONAL", EProfesional);
            cmd.Parameters.AddWithValue("@EPROFESIONAL", Categoria);
            conexion.Close();
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        /*
        public int SearchDocente(E_Docente docente)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_BUSCARDOCENTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", docente.Search);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla.Rows.Count;
        }*/
    }
}
