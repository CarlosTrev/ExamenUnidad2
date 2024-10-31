using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Apriliados
{
    public class connect
    {
        string cadenaConexion = @"Data Source= MSI\SQLEXPRESS;
                Integrated Security=true;Initial Catalog=Northwind";
        private SqlConnection Conexion()
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
            DataSet es = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(comando, Conexion());
            try
            {
                da.Fill(es);
                return es;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
    }
}
