using System;
using System.Data;
using System.Data.SqlClient;

namespace ExamenUnidad2
{
    public class connect
    {
        string cadenaConexion = @"Data Source= MSI\SQLEXPRESS; Integrated Security=true; Initial Catalog=Northwind2";

        public SqlConnection Conexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    
        public DataSet Ejecutar(string comando)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conexion = Conexion())
            {
                if (conexion == null) return null;
                SqlDataAdapter da = new SqlDataAdapter(comando, conexion);
                try
                {
                    da.Fill(ds);
                    return ds;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }

        public SqlDataReader EjecutarDataReader(string comando)
        {
            SqlConnection conexion = Conexion();
            if (conexion == null) return null;
            SqlCommand cmd = new SqlCommand(comando, conexion);
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                conexion.Close();
                return null;
            }
        }
        public bool EjecutarComando(SqlCommand cmd)
        {
            using (SqlConnection conexion = Conexion())
            {
                if (conexion == null) return false;
                cmd.Connection = conexion;
                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }
        public SqlDataReader EjecutarConsulta(SqlCommand cmd)
        {
            SqlConnection conexion = Conexion();
            if (conexion == null) return null;

            cmd.Connection = conexion;
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                conexion.Close();
                return null;
            }
        }


    }
}
