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
    public class D_Ficha
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
        public string indiceñ;

        public DataTable ListEstudianteTutoria(E_Ficha ficha)
        {

            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_LISTAR_ESTUDIANTE_TUTORIA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@USUARIO", ficha.Search);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;
        }
        public DataTable ListHistorialEstudiante(E_Ficha ficha)
        {

            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_HISTORIAL_ESTUDIANTE_TUTORIA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDESTUDIANTE", ficha.Search);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;
        }
        public DataTable ListFichas(E_Ficha ficha)
        {

            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_LISTARFICHA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@USUARIO", ficha.Search);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;
        }
        public DataTable SearchFichas(E_Ficha ficha)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_BUSCARFICHA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", ficha.Search);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;
        }
        public DataTable SearchEstudiante_Tutoria(E_Ficha ficha)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_BUSCAR_ESTUDIANTE_TUTORIA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            
            cmd.Parameters.AddWithValue("@BUSCAR", ficha.Search);
            cmd.Parameters.AddWithValue("@USUARIO", ficha.Usuario);


            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;
        }

        public void DeleteFicha(string Id)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARFICHA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDFICHATUTORIA", Id);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void CreateFicha(E_Ficha ficha)
        {

            SqlCommand cmd = new SqlCommand("SP_INSERTARFICHA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            cmd.Parameters.AddWithValue("@IDFICHATUTORIA", ficha.IdFichaTutoria);
            cmd.Parameters.AddWithValue("@IDTUTORIA", ficha.IdTutoria);
            cmd.Parameters.AddWithValue("@IDESTUDIANTE", ficha.IdEstudiante);
            cmd.Parameters.AddWithValue("@NROCELULAR", ficha.NroCelular);
            cmd.Parameters.AddWithValue("@DIRECCION", ficha.Direccion);
            cmd.Parameters.AddWithValue("@EMAIL", ficha.Email);
            cmd.Parameters.AddWithValue("@PERSONAREFERENCIA", ficha.PersonaReferencia);
            cmd.Parameters.AddWithValue("@CELULARREFERENCIA", ficha.CelularReferencia);
            cmd.Parameters.AddWithValue("@FECHA", ficha.Fecha);
            cmd.Parameters.AddWithValue("@TIPOTUTORIA", ficha.TipoTutoria);
            cmd.Parameters.AddWithValue("@DESCRIPCION", ficha.Descripcion);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void UpdateFicha(E_Ficha ficha)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARFICHA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDFICHATUTORIA", ficha.IdFichaTutoria);
            cmd.Parameters.AddWithValue("@IDTUTORIA", ficha.IdTutoria);
            cmd.Parameters.AddWithValue("@IDESTUDIANTE", ficha.IdEstudiante);
            cmd.Parameters.AddWithValue("@NROCELULAR", ficha.NroCelular);
            cmd.Parameters.AddWithValue("@DIRECCION", ficha.Direccion);
            cmd.Parameters.AddWithValue("@EMAIL", ficha.Email);
            cmd.Parameters.AddWithValue("@PERSONAREFERENCIA", ficha.PersonaReferencia);
            cmd.Parameters.AddWithValue("@CELULARREFERENCIA", ficha.CelularReferencia);
            cmd.Parameters.AddWithValue("@FECHA", ficha.Fecha);
            cmd.Parameters.AddWithValue("@TIPOTUTORIA", ficha.TipoTutoria);
            cmd.Parameters.AddWithValue("@DESCRIPCION", ficha.Descripcion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
        //nuevo

        public string Nuevo()
        {
            string codigo;
            SqlCommand cmd = new SqlCommand("NuevoFichaTutoria", conexion);
            cmd.CommandType= CommandType.StoredProcedure;
            conexion.Open();
            cmd.CommandTimeout = 30;
            SqlCommandBuilder.DeriveParameters(cmd);
            cmd.ExecuteNonQuery();
            conexion.Close();
            return (string)cmd.Parameters["@RETURN_VALUE"].Value;
        }

    }
}
