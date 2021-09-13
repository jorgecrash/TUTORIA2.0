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
    public class D_Tutoria
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public DataTable ListTutorias()
        {
            DataTable table = new DataTable();
            SqlDataReader readRows;
            SqlCommand cmd = new SqlCommand("SP_LISTARTUTORIA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            readRows = cmd.ExecuteReader();
            table.Load(readRows);

            readRows.Close();
            conexion.Close();

            return table;
        }
        public DataTable SearchTutorias(E_Tutoria tutoria)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_BUSCARTUTORIA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", tutoria.Search);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;
        }
        public void DeleteTutoria(string Id)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARTUTORIA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDTUTORIA", Id);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void CreateTutoria(E_Tutoria tutoria)
        {

            SqlCommand cmd = new SqlCommand("SP_INSERTARTUTORIA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDTUTORIA", tutoria.IdTutoria);
            cmd.Parameters.AddWithValue("@IDDOCENTE", tutoria.IdDocente);
            cmd.Parameters.AddWithValue("@HORARIO", tutoria.Horario);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void UpdateTutoria(E_Tutoria tutoria)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARTUTORIA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDTUTORIA", tutoria.IdTutoria);
            cmd.Parameters.AddWithValue("@IDDOCENTE", tutoria.IdDocente);
            cmd.Parameters.AddWithValue("@HORARIO", tutoria.Horario);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        public DataTable ListDocenteTutoria()
        {
            DataTable table = new DataTable();
            SqlDataReader readRows;
            SqlCommand cmd = new SqlCommand("SP_ListarDocenteTutoria", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            readRows = cmd.ExecuteReader();
            table.Load(readRows);

            readRows.Close();
            conexion.Close();

            return table;
        }
        public DataTable BuscarTutoriasDocente(E_Tutoria tutoria)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_BuscarDocenteTutoria", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@BUSCAR", tutoria.BucarDocenteTutoria);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            conexion.Close();
            return tabla;
        }
    }
}
