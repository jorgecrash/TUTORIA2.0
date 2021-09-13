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
    public class D_Estudiante
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);
      
        public DataTable ListStudents()
        {
            DataTable table = new DataTable();
            SqlDataReader readRows;
            SqlCommand cmd = new SqlCommand("SP_LISTARESTUDIANTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            readRows = cmd.ExecuteReader();
            table.Load(readRows);

            readRows.Close();
            conexion.Close();

            return table;
        }
        public DataTable SearchStudents(E_Estudiante estudiante)
        {
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand("SP_BUSCARESTUDIANTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@BUSCAR", estudiante.Search);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);

            conexion.Close();
            return tabla;
        }

        public void DeleteStudent(string CodEstudiante)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARESTUDIANTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDESTUDIANTE", CodEstudiante);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void CreateStudent(E_Estudiante estudiante)
        {

            SqlCommand cmd = new SqlCommand("SP_INSERTARESTUDIANTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();
            //cmd.Parameters.AddWithValue("@IDESTUDIANTE", estudiante.CodEstudiante);
            cmd.Parameters.AddWithValue("@NOMBRES", estudiante.Nombres);
            cmd.Parameters.AddWithValue("@APELLIDOS", estudiante.Apellidos);
            cmd.Parameters.AddWithValue("@SEMESTREACTIVO", estudiante.SemestreActivo);
           
            cmd.Parameters.AddWithValue("@ESCUELAPROFESIONAL", estudiante.EscuelaProfesional);
            cmd.Parameters.AddWithValue("@CODIGOEP", estudiante.CodEP);
            cmd.Parameters.AddWithValue("@AINGRESO", estudiante.AIngreso);

            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void UpdateStudent(E_Estudiante estudiante)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARESTUDIANTE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@IDESTUDIANTE", estudiante.CodEstudiante);
            cmd.Parameters.AddWithValue("@NOMBRES", estudiante.Nombres);
            cmd.Parameters.AddWithValue("@APELLIDOS", estudiante.Apellidos);
            cmd.Parameters.AddWithValue("@SEMESTREACTIVO", estudiante.SemestreActivo);
            cmd.Parameters.AddWithValue("@ESCUELAPROFESIONAL", estudiante.EscuelaProfesional);
            cmd.Parameters.AddWithValue("@CODIGOEP", estudiante.CodEP);
            cmd.Parameters.AddWithValue("@AINGRESO", estudiante.AIngreso);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

    }
}
