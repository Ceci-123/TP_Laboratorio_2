using System;
using System.Data.SqlClient;

namespace Entidades
{
    public static class VacunacionDao
    {
        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static VacunacionDao()
        {
            cadenaConexion = @"Data Source=.;Initial Catalog=INSTITUTOZOONOSIS;Integrated Security=True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }

        public static void EnviarData(int id, DateTime fecha, int cantidadVacunaPerro, int cantidadVacunaGato)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"INSERT INTO VacunasAntirrabicas VALUES (@ID,@Fecha,@AntiPerro,@AntiGato)";
                comando.Parameters.AddWithValue("@ID", id);
                comando.Parameters.AddWithValue("@Fecha", fecha);
                comando.Parameters.AddWithValue("@AntiPerro", cantidadVacunaPerro);
                comando.Parameters.AddWithValue("@AntiGato", cantidadVacunaGato);
                int rows = comando.ExecuteNonQuery();

            }
            catch (System.Data.SqlClient.SqlException)
            {
                throw;
            }
            catch (Exception)
            {

            }
            finally
            {
                conexion.Close();
            }
        }

        public static int ConsultaAntirrabica(bool esPerro)
        {
            int retorno = 0;
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                if (esPerro)
                {
                    comando.CommandText = $"SELECT SUM(ANTIRRABICAPERROS) AS SUMA FROM [INSTITUTOZOONOSIS].[dbo].[VacunasAntirrabicas] WHERE id_veterinaria = 1";
                }
                else
                {
                    comando.CommandText = $"SELECT SUM(ANTIRRABICAGATOS) AS SUMA FROM [INSTITUTOZOONOSIS].[dbo].[VacunasAntirrabicas] WHERE id_veterinaria = 1";
                }

                using (SqlDataReader dataReader = comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        retorno = (Convert.ToInt32(dataReader["SUMA"]));
                    }
                }

            }
            catch (System.Data.SqlClient.SqlException)
            {
                throw;
            }
            catch (Exception)
            {

            }
            finally
            {
                conexion.Close();
            }
            return retorno;

        }


    }
}
