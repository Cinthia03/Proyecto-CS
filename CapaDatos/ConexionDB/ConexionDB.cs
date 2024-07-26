using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos.ConexionDB
{
    /// <summary>
    /// Clase para manejar la conexión a la base de datos SQL Server.
    /// </summary>

    public class ConexionDB
    {
        private SqlConnection conexion = new SqlConnection("server=DESKTOP-QKEO7JD\\MSSQLSERVER07; database=SQLFinal; Integrated Security=true");

        /// <summary>
        /// Abre la conexión a la base de datos si está cerrada.
        /// </summary>
        /// <returns>La conexión abierta.</returns>

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();

            return conexion;
        }
        
        /// <summary>
        /// Cierra la conexión a la base de datos si está abierta.
        /// </summary>
        /// <returns>La conexión cerrada.</returns>

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();

            return conexion;
        }
       
    }
}
