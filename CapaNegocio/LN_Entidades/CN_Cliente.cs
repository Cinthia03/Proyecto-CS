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
    /// Clase que representa la entidad Cliente en la capa de negocio.
    /// </summary>
    public class CN_Cliente
    {
        private Interface_Negocio objIntCliente = new Interface_Negocio();
        private int id;
        private string nombre;
        private int edad;
        private string cedula;
        private string celular;
        private string correo;
        private string contacto_emergencia;

        /// <summary>
        /// Constructor sin parámetros de la clase `CN_Cliente`.
        /// </summary>
        public CN_Cliente()
        {
            id = 0;
            nombre = string.Empty;
            edad = 0;
            cedula = string.Empty;
            celular = string.Empty;
            correo = string.Empty;
            contacto_emergencia = string.Empty;
        }

        /// <summary>
        /// Constructor con parámetros de la clase `CN_Cliente`.
        /// </summary>
        public CN_Cliente(int id, string nombre, int edad, string cedula, string celular, string correo, string contacto_emergencia)
        {
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
            this.cedula = cedula;
            this.celular = celular;
            this.correo = correo;
            this.contacto_emergencia = contacto_emergencia;
        }

        /// <summary>
        /// Propiedad para acceder el ID del cliente.
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Propiedad para acceder el nombre del cliente.
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /// <summary>
        /// Propiedad para acceder la edad del cliente.
        /// </summary>
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        /// <summary>
        /// Propiedad para acceder al número de cédula del cliente.
        /// </summary>
        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        /// <summary>
        /// Propiedad para acceder al número de celular del cliente.
        /// </summary>
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        /// <summary>
        /// Propiedad para acceder al correo electrónico del cliente.
        /// </summary>
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        /// <summary>
        /// Propiedad para acceder al numero de contacto de emergencia del cliente.
        /// </summary>
        public string Contacto_emergencia
        {
            get { return contacto_emergencia; }
            set { contacto_emergencia = value; }
        }



        /// <summary>
        /// Obtiene un listado de clientes desde la capa de datos.
        /// </summary>
        public DataTable getListadoCliente()
        {
            try
            {
                return objIntCliente.getListaCliente();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de cliente -> " + e.Message);
            }
        }

        /// <summary>
        /// Guarda un cliente en la base de datos.
        /// </summary>
        public bool GuardarCliente(CN_Cliente cliente)
        {

            try
            {
                // Se crea una lista de parámetros para enviar a la capa de datos
                List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
                lista.Add(new CD_Parameter_SP("@nombre", cliente.Nombre, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@edad", cliente.Edad, SqlDbType.Int));
                lista.Add(new CD_Parameter_SP("@cedula", cliente.Cedula, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@celular", cliente.Celular, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@correo", cliente.Correo, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@contacto_emergencia", cliente.Contacto_emergencia, SqlDbType.Text));
                
                // Se llama al método de la capa de datos para guardar el cliente 
                return objIntCliente.CreaCliente(lista);

            }
            catch (Exception e)
            {
                // Si ocurre una excepción, se lanza una nueva excepción con un mensaje descriptivo
                throw new Exception("Error al Guardar Datos de Cliente -> " + e.Message);
            }

        }

        /// <summary>
        /// Actualiza un cliente y vehículo en la base de datos.
        /// </summary>
        public bool ActualizarCliente(CN_Cliente cliente)
        {
            try
            {
                // Se crea una lista de parámetros para enviar a la capa de datos
                List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
                lista.Add(new CD_Parameter_SP("@id", cliente.Id, SqlDbType.Int));
                lista.Add(new CD_Parameter_SP("@nombre", cliente.Nombre, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@edad", cliente.Edad, SqlDbType.Int));
                lista.Add(new CD_Parameter_SP("@cedula", cliente.Cedula, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@celular", cliente.Celular, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@correo", cliente.Correo, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@contacto_emergencia", cliente.Contacto_emergencia, SqlDbType.Text));

                // Se llama al método de la capa de datos para actualizar el cliente
                return objIntCliente.ActualizarCliente(lista);

            }
            catch (Exception e)
            {
                // Si ocurre una excepción, se lanza una nueva excepción con un mensaje descriptivo
                throw new Exception("Error al Actualizar Datos de Cliente -> " + e.Message);
            }

        }

        /// <summary>
        /// Elimina un cliente y vehículo de la base de datos.
        /// </summary>
        public bool EliminarCliente(CN_Cliente cliente)
        {
            try
            {
                // Se crea una lista de parámetros para enviar a la capa de datos
                List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
                lista.Add(new CD_Parameter_SP("@IdCliente", cliente.Id, SqlDbType.Int));
                
                // Se llama al método de la capa de datos para eliminar el cliente 
                return objIntCliente.EliminaCliente(lista);
            }
            catch (Exception e)
            {
                // Si ocurre una excepción, se lanza una nueva excepción con un mensaje descriptivo
                throw new Exception("Error al Eliminar Datos de Cliente  -> " + e.Message);
            }
        }


    }
}
 
