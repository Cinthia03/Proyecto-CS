using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos.Interface
{
    /// <summary>
    /// Clase que representa un parámetro de un procedimiento almacenado en la base de datos.
    /// </summary>
    public class CD_Parameter_SP
    {
        private string nombre_parametro;
        private object valor_parametro;
        private SqlDbType tipo_dato;

        /// <summary>
        /// Constructor por defecto de la clase `CD_Parameter_SP`.
        /// Inicializa las propiedades con valores predeterminados.
        /// </summary>
        public CD_Parameter_SP()
        {
            nombre_parametro = string.Empty;
            valor_parametro = string.Empty;
            tipo_dato = SqlDbType.NVarChar;
        }

        /// <summary>
        /// Constructor de la clase `CD_Parameter_SP`.
        /// Permite inicializar las propiedades con valores específicos.
        /// </summary>
        public CD_Parameter_SP(string nombre_parametro, object valor_parametro, SqlDbType tipo_dato)
        {
            this.nombre_parametro = nombre_parametro;
            this.valor_parametro = valor_parametro;
            this.tipo_dato = tipo_dato;
        }

        /// <summary>
        /// Propiedad para acceder y modificar el nombre del parámetro.
        /// </summary>
        public string NombreParametro
        {
            get { return nombre_parametro;}
            set { nombre_parametro = value;}
        }

        /// <summary>
        /// Propiedad para acceder y modificar el valor del parámetro.
        /// </summary>
        public object ValorParametro
        {
            get { return valor_parametro; }
            set { valor_parametro = value;}
        }

        /// <summary>
        /// Propiedad para acceder y modificar el tipo de dato del parámetro.
        /// </summary>
        public SqlDbType TipoDato
        {
            get { return tipo_dato; }
            set { tipo_dato = value;}
        }

    }
}
