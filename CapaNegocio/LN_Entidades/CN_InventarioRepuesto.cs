using CapaDatos.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.LN_Entidades
{
    /// <summary>
    /// Clase que representa la entidad InventarioRepuesto en la capa de negocio.
    /// </summary>
    public class CN_InventarioRepuesto
    {
        private Interface_Negocio objIntInventarioRepuesto = new Interface_Negocio();
        int id;
        string nombre_repuesto;
        float precio;

        /// <summary>
        /// Constructor sin parámetros de la clase `CN_InventarioRepuesto`.
        /// </summary>
        public CN_InventarioRepuesto()
        {
            id = 0;
            nombre_repuesto = string.Empty;
            precio = 0;
        }

        /// <summary>
        /// Constructor con parámetros de la clase `CN_InventarioRepuesto`.
        /// </summary>
        public CN_InventarioRepuesto(int id, string nombre_repuesto, float precio)
        {
            this.id = id;
            this.nombre_repuesto = nombre_repuesto;
            this.precio = precio;
        }

        /// <summary>
        /// Propiedad para acceder al identificador del repuesto en el inventario.
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Propiedad para acceder al nombre del repuesto.
        /// </summary>
        public string Nombre_repuesto
        {
            get { return nombre_repuesto; }
            set { nombre_repuesto = value; }
        }

        /// <summary>
        /// Propiedad para acceder al precio del repuesto.
        /// </summary>
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }



        /// <summary>
        /// Obtiene un listado del inventario de repuestos desde la capa de datos.
        /// </summary>
        public DataTable getListadoInventarioRepuesto()
        {
            try
            {
                // Llama al método de la capa de datos para obtener el listado del inventario de repuestos
                return objIntInventarioRepuesto.getListaInventarioRepuesto();
            }
            catch (Exception e)
            {
                // Si ocurre una excepción, se lanza una nueva excepción con un mensaje descriptivo
                throw new Exception("Error al obtener listado de inventario de repuestos -> " + e.Message);
            }
        }

        /// <summary>
        /// Guarda un nuevo repuesto en el inventario en la base de datos.
        /// </summary>
        public bool GuardarInventarioRepuesto(CN_InventarioRepuesto InventarioRepuesto)
        {

            try
            {
                // Se crea una lista de parámetros para enviar a la capa de datos
                List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
                lista.Add(new CD_Parameter_SP("@nombre_repuesto", InventarioRepuesto.Nombre_repuesto, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@precio", InventarioRepuesto.Precio, SqlDbType.Float));

                // Se llama al método de la capa de datos para guardar el repuesto en el inventario
                return objIntInventarioRepuesto.CreaInventarioRepuesto(lista);

            }
            catch (Exception e)
            {
                // Si ocurre una excepción, se lanza una nueva excepción con un mensaje descriptivo
                throw new Exception("Error al Guardar Datos de inventario de repuestos -> " + e.Message);
            }

        }

        /// <summary>
        /// Actualiza un repuesto en el inventario en la base de datos.
        /// </summary>
        public bool ActualizarInventarioRepuesto(CN_InventarioRepuesto InventarioRepuesto)
        {
            try
            {
                // Se crea una lista de parámetros para enviar a la capa de datos
                List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
                lista.Add(new CD_Parameter_SP("@id", InventarioRepuesto.Id, SqlDbType.Int));
                lista.Add(new CD_Parameter_SP("@nombre_repuesto", InventarioRepuesto.Nombre_repuesto, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@precio", InventarioRepuesto.Precio, SqlDbType.Float));
                
                // Se llama al método de la capa de datos para actualizar el repuesto en el inventario
                return objIntInventarioRepuesto.ActualizarInventarioRepuesto(lista);

            }
            catch (Exception e)
            {
                // Si ocurre una excepción, se lanza una nueva excepción con un mensaje descriptivo
                throw new Exception("Error al Actualizar Datos de inventario de repuestos -> " + e.Message);
            }

        }

        /// <summary>
        /// Elimina un repuesto del inventario en la base de datos.
        /// </summary>
        public bool EliminarInventarioRepuesto(CN_InventarioRepuesto InventarioRepuesto)
        {
            try
            {
                // Se crea una lista de parámetros para enviar a la capa de datos
                List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
                lista.Add(new CD_Parameter_SP("@IdInventarioRepuesto", InventarioRepuesto.Id, SqlDbType.Int));

                // Se llama al método de la capa de datos para eliminar el repuesto del inventario
                return objIntInventarioRepuesto.EliminaInventarioRepuesto(lista);
            }
            catch (Exception e)
            {
                // Si ocurre una excepción, se lanza una nueva excepción con un mensaje descriptivo
                throw new Exception("Error al Eliminar Datos de inventario de repuestos  -> " + e.Message);
            }
        }


    }
}


