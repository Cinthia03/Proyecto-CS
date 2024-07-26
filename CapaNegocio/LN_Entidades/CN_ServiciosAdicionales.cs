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
    /// Clase que representa un servicio adicional disponible en el sistema.
    /// </summary>
    public class CN_ServiciosAdicionales
    {
        private Interface_Negocio objIntServiciosAdicionales = new Interface_Negocio();
        private int id;
        string nombre;
        float precio;

        /// <summary>
        /// Constructor predeterminado de la clase CN_ServiciosAdicionales.
        /// Inicializa las propiedades con sus valores por defecto.
        /// </summary>
        public CN_ServiciosAdicionales()
        {
            id = 0;
            nombre = string.Empty;
            precio = 0;
        }

        /// <summary>
        /// Constructor de la clase CN_ServiciosAdicionales que permite inicializar todas las propiedades.
        /// </summary>
        public CN_ServiciosAdicionales(int id, string nombre, float precio)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
        }

        /// <summary>
        /// ID del servicio adicional.
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Nombre del servicio adicional.
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /// <summary>
        /// Precio del servicio adicional.
        /// </summary>
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }


        /// <summary>
        /// Obtiene un listado de servicios adicionales desde la capa de datos.
        /// </summary>
        public DataTable getListadoServiciosAdicionales()
        {
            try
            {
                return objIntServiciosAdicionales.getListaServiciosAdicionales();
            }
            catch (Exception e)
            {
                // En caso de error, se lanza una excepción con un mensaje descriptivo.
                throw new Exception("Error al obtener listado de servicios adicionales -> " + e.Message);
            }
        }

        /// <summary>
        /// Guarda un nuevo servicio adicional en la base de datos.
        /// </summary>
        public bool GuardarServiciosAdicionales(CN_ServiciosAdicionales serviciosAdicionales)
        {
            try
            {
                // Se crea una lista de parámetros para pasar a la capa de datos.
                List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
                lista.Add(new CD_Parameter_SP("@nombre", serviciosAdicionales.Nombre, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@precio", serviciosAdicionales.Precio, SqlDbType.Float));

                // Se llama al método en la capa de datos para guardar el servicio adicional.
                return objIntServiciosAdicionales.CreaServiciosAdicionales(lista);
            }
            catch (Exception e)
            {
                // En caso de error, se lanza una excepción con un mensaje descriptivo.
                throw new Exception("Error al Guardar Datos de Servicios Adicionales -> " + e.Message);
            }

        }

        /// <summary>
        /// Actualiza un servicio adicional existente en la base de datos.
        /// </summary>
        public bool ActualizarServiciosAdicionales(CN_ServiciosAdicionales serviciosAdicionales)
        {
            try
            {
                // Se crea una lista de parámetros para pasar a la capa de datos.
                List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
                lista.Add(new CD_Parameter_SP("@id", serviciosAdicionales.Id, SqlDbType.Int));
                lista.Add(new CD_Parameter_SP("@nombre", serviciosAdicionales.Nombre, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@precio", serviciosAdicionales.Precio, SqlDbType.Float));

                // Se llama al método en la capa de datos para actualizar el servicio adicional.
                return objIntServiciosAdicionales.ActualizarServiciosAdicionales(lista);

            }
            catch (Exception e)
            {
                // En caso de error, se lanza una excepción con un mensaje descriptivo.
                throw new Exception("Error al Actualizar Datos de Servicios Adicionales -> " + e.Message);
            }

        }

        /// <summary>
        /// Elimina un servicio adicional de la base de datos.
        /// </summary>
        public bool EliminarServiciosAdicionales(CN_ServiciosAdicionales serviciosAdicionales)
        {
            try
            {
                // Se crea una lista de parámetros para pasar a la capa de datos.
                List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
                lista.Add(new CD_Parameter_SP("@IdServicio", serviciosAdicionales.Id, SqlDbType.Int));

                // Se llama al método en la capa de datos para eliminar el servicio adicional.
                return objIntServiciosAdicionales.EliminaServiciosAdicionales(lista);
            }
            catch (Exception e)
            {
                // En caso de error, se lanza una excepción con un mensaje descriptivo.
                throw new Exception("Error al Eliminar Datos de Servicios -> " + e.Message);
            }
        }
    }
}
