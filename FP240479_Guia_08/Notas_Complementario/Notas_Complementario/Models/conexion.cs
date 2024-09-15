using System;
using System.Data.SqlClient;

namespace Notas_Complementario.Models
{
    public class Conexion
    {
        private SqlConnection conexionSQL;

        public Conexion()
        {
            // Cadena de conexión a tu base de datos
            string connectionString = "Server=tu_servidor;Database=registro_de_notas;User Id=tu_usuario;Password=tu_contraseña;";
            conexionSQL = new SqlConnection(connectionString);
        }

        // Método para abrir la conexión
        public void AbrirConexion()
        {
            try
            {
                if (conexionSQL.State == System.Data.ConnectionState.Closed)
                {
                    conexionSQL.Open();
                }
            }
            catch (SqlException ex)
            {
                // Manejo de errores específicos de SQL
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Manejo de otros errores
                Console.WriteLine("Error inesperado: " + ex.Message);
            }
        }


        // Método para cerrar la conexión
        public void CerrarConexion()
        {
            if (conexionSQL.State == System.Data.ConnectionState.Open)
            {
                conexionSQL.Close();
            }
        }

        // Método para obtener la conexión
        public SqlConnection GetConexion()
        {
            return conexionSQL;
        }
    }
}
