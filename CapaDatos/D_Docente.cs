using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using CapaEntidades;
using System.Data;


namespace CapaDatos
{
    public class D_Docente
    {
        public D_Docente()
        {

        }
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public DataTable ListDocente()
        {
            DataTable table = new DataTable();
            SqlDataReader readRows;
            SqlCommand cmd = new SqlCommand("SP_LISTARDOCENTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            readRows = cmd.ExecuteReader();
            table.Load(readRows);

            readRows.Close();
            conexion.Close();

            return table;
        }
        public DataTable SearchDocente(E_Docente docente)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_BUSCARDOCENTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", docente.Search);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;
        }

        public void DeleteDocente(string id)
        {
            int a;
            SqlCommand cmd = new SqlCommand("SP_ELIMINARDOCENTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDDOCENTE", id);
            
            int i=  cmd.ExecuteNonQuery();

            conexion.Close();
            
        }

        public void CreateDocente(E_Docente docente)
        {

            SqlCommand cmd = new SqlCommand("SP_INSERTARDOCENTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            //cmd.Parameters.AddWithValue("@IDDOCENTE", docente.IdDocente);
            cmd.Parameters.AddWithValue("@NOMBRES", docente.Nombres);
            cmd.Parameters.AddWithValue("@APELLIDOS", docente.Apellidos);
            cmd.Parameters.AddWithValue("@TITULO", docente.TituloAcademico);
            cmd.Parameters.AddWithValue("@FACULTAD", docente.Facultad);
            cmd.Parameters.AddWithValue("@EPROFESIONAL", docente.EscuelaProfesional);
            cmd.Parameters.AddWithValue("@CATEGORIA", docente.Categoria);

            cmd.ExecuteNonQuery();
       
            conexion.Close();
            
        }

        public void UpdateDocente(E_Docente docente)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARDOCENTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDDOCENTE", docente.IdDocente);
            cmd.Parameters.AddWithValue("@NOMBRES", docente.Nombres);
            cmd.Parameters.AddWithValue("@APELLIDOS", docente.Apellidos);
            cmd.Parameters.AddWithValue("@TITULO", docente.TituloAcademico);
            cmd.Parameters.AddWithValue("@FACULTAD", docente.Facultad);
            cmd.Parameters.AddWithValue("@EPROFESIONAL", docente.EscuelaProfesional);
            cmd.Parameters.AddWithValue("@CATEGORIA", docente.Categoria);


            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
