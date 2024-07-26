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
    /// Clase que representa la entidad Vehiculo en la capa de negocio.
    /// </summary>
    public class CN_Vehiculo
    {
        private Interface_Negocio objIntVehiculo = new Interface_Negocio();
        private int id;
        private string vehiculo;
        private string kilometraje;
        private string placa;
        private string cliente;

        /// <summary>
        /// Constructor sin parámetros de la clase `CN_Vehiculo`.
        /// </summary>
        public CN_Vehiculo()
        {
            id = 0;
            vehiculo = string.Empty;
            kilometraje = string.Empty;
            placa = string.Empty;   
            cliente = string.Empty;
        }

        /// <summary>
        /// Constructor con parámetros de la clase `CN_Vehiculo`.
        /// </summary>
        public CN_Vehiculo(int id, string vehiculo, string kilometraje, string placa, string cliente)
        {
            this.id = id;
            this.vehiculo = vehiculo;
            this.kilometraje = kilometraje;
            this.placa = placa;
            this.cliente = cliente;
        }

        /// <summary>
        /// Propiedad para acceder el ID del vehiculo.
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Propiedad para acceder el nombre del vehiculo.
        /// </summary>
        public string Vehiculo
        {
            get { return vehiculo; }
            set { vehiculo = value; }
        }

        /// <summary>
        /// Propiedad para acceder el kilometraje del vehiculo.
        /// </summary>
        public string Kilometraje
        {
            get { return kilometraje; }
            set { kilometraje = value; }
        }

        /// <summary>
        /// Propiedad para acceder la placa del vehiculo.
        /// </summary>
        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        /// <summary>
        /// Propiedad para acceder el nombre del vehiculo.
        /// </summary>
        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }


        /// <summary>
        /// Obtiene un listado de vehículos desde la capa de datos.
        /// </summary>
        public DataTable getListadoVehiculo()
        {
            try
            {
                return objIntVehiculo.getListaVehiculo();
            }
            catch (Exception e)
            {
                // Si ocurre una excepción, se lanza una nueva excepción con un mensaje descriptivo
                throw new Exception("Error al obtener listado de vehiculos -> " + e.Message);
            }
        }

        /// <summary>
        /// Guarda un vehículo en la base de datos.
        /// </summary>
        public bool GuardarVehiculo(CN_Vehiculo vehiculo)
        {
            try
            {
                // Se crea una lista de parámetros para enviar a la capa de datos
                List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
                lista.Add(new CD_Parameter_SP("@vehiculo", vehiculo.Vehiculo, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@kilometraje", vehiculo.Kilometraje, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@placa", vehiculo.Placa, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@cliente", vehiculo.Cliente, SqlDbType.Text));
                
                // Se llama al método de la capa de datos para guardar el vehículo
                return objIntVehiculo.CreaVehiculo(lista);

            }
            catch (Exception e)
            {
                // Si ocurre una excepción, se lanza una nueva excepción con un mensaje descriptivo
                throw new Exception("Error al Guardar Datos de vehiculo -> " + e.Message);
            }

        }

        /// <summary>
        /// Actualiza un vehículo en la base de datos.
        /// </summary>
        public bool ActualizarVehiculo(CN_Vehiculo vehiculo)
        {
            try
            {
                // Se crea una lista de parámetros para enviar a la capa de datos
                List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
                lista.Add(new CD_Parameter_SP("@id", vehiculo.Id, SqlDbType.Int));
                lista.Add(new CD_Parameter_SP("@vehiculo", vehiculo.Vehiculo, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@kilometraje", vehiculo.Kilometraje, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@placa", vehiculo.Placa, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@cliente", vehiculo.Cliente, SqlDbType.Text));
                
                // Se llama al método de la capa de datos para guardar el vehículo
                return objIntVehiculo.ActualizarVehiculo(lista);

            }
            catch (Exception e)
            {
                // Si ocurre una excepción, se lanza una nueva excepción con un mensaje descriptivo
                throw new Exception("Error al Actualizar Datos de vehiculo -> " + e.Message);
            }

        }

        /// <summary>
        /// Elimina un vehículo de la base de datos.
        /// </summary>
        public bool EliminarVehiculo(CN_Vehiculo vehiculo)
        {
            try
            {
                // Se crea una lista de parámetros para enviar a la capa de datos
                List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
                lista.Add(new CD_Parameter_SP("@idVehiculo", vehiculo.Id, SqlDbType.Int));

                // Se llama al método de la capa de datos para eliminar el vehículo
                return objIntVehiculo.EliminaVehiculo(lista);
            }
            catch (Exception e)
            {
                // Si ocurre una excepción, se lanza una nueva excepción con un mensaje descriptivo
                throw new Exception("Error al Eliminar Datos de Vehiculo -> " + e.Message);
            }
        }


    }
}
