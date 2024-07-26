using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.ConexionDB;
using System.Data;
using CapaDatos.Interface;
using System.Globalization;

namespace CapaDatos.ExecuteSQL
{
    public class ExecuteSQL
    {
        /// <summary>
        /// Clase para ejecutar consultas SQL en la base de datos utilizando procedimientos almacenados.
        /// </summary>
        /// 
        private ConexionDB.ConexionDB conn = new ConexionDB.ConexionDB();
        //metodo para ejecutar INSERT, UPDATE y DELETE

        /// <summary>
        /// Ejecuta un procedimiento almacenado que no devuelve resultados (INSERT, UPDATE o DELETE).
        /// </summary>
        public bool ExecuteSPNonQuery(string nombre_sp, List<CD_Parameter_SP> lista_parametros)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombre_sp;
            //Añadir los parametros
            if (lista_parametros.Count > 0)
            {
                foreach (var parametro in lista_parametros)
                    comando.Parameters.Add(parametro.NombreParametro, parametro.TipoDato).Value = parametro.ValorParametro;
            }
            comando.Connection = conn.AbrirConexion();
            var resultado = comando.ExecuteNonQuery();
            conn.CerrarConexion();
            if (resultado > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Ejecuta un procedimiento almacenado que devuelve un conjunto de resultados (SELECT).
        /// </summary>
        public DataTable ExecuteSPQuery(string nombre_sp, List<CD_Parameter_SP> lista_parametros)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombre_sp;
            //añadimos los parametros si los hay
            if (lista_parametros.Count > 0)
            {
                foreach (var parametro in lista_parametros)
                    comando.Parameters.Add(parametro.NombreParametro, parametro.TipoDato).Value = parametro.ValorParametro;
            }

            comando.Connection = conn.AbrirConexion();

            SqlDataReader reader = comando.ExecuteReader();

            using (var tabla = new DataTable())
            {
                tabla.Load(reader);
                reader.DisposeAsync();
                conn.CerrarConexion();
                return tabla;
            }
        }

    }
}