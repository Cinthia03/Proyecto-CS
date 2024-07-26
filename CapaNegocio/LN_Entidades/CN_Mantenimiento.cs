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
    /// Clase que representa la entidad Mantenimiento en la capa de negocio.
    /// </summary>
    public class CN_Mantenimiento
    {
        private Interface_Negocio objIntMantenimiento = new Interface_Negocio();
        int id;
        DateTime fecha;
        string nombreCliente;
        string nombre_vehiculo;
        string kilometraje_vehiculo;
        string placa_vehiculo;
        string nombreMecanico;
        string trabajos;
        string tipoMantenimiento,repuesto;
        float totalMantenimiento;
        string nombreServicios;
        float totalServicios;
        float subtotal;
        float totalPagar;

        /// <summary>
        /// Constructor sin parámetros de la clase `CN_Mantenimiento`.
        /// </summary>
        public CN_Mantenimiento()
        {
            // Inicialización de variables
            id = 0;
            nombreCliente = string.Empty;
            nombre_vehiculo = string.Empty;
            Kilometraje_vehiculo = string.Empty;
            placa_vehiculo = string.Empty;
            nombreMecanico = string.Empty; 
            trabajos = string.Empty;
            tipoMantenimiento = string.Empty;
            repuesto = string.Empty;
            //totalTipoMat = 0;
            totalMantenimiento = 0;
            nombreServicios = string.Empty;
            totalServicios = 0;
            subtotal = 0;
            totalPagar = 0;      
        }

        /// <summary>
        /// Constructor con parámetros de la clase `CN_Mantenimiento`.
        /// </summary>
        public CN_Mantenimiento(int id, DateTime fecha, string nombreCliente, string nombre_vehiculo, string kilometraje_vehiculo, string placa_vehiculo, string nombreMecanico, string trabajos, string tipoMantenimiento, string repuesto, float totalMantenimiento, string nombreServicios, float totalServicios, float subtotal, float totalPagar)
        {
            // Asignación de valores
            this.id = id;
            this.fecha = fecha;
            this.nombreCliente = nombreCliente;
            this.nombre_vehiculo = nombre_vehiculo;
            this.kilometraje_vehiculo = kilometraje_vehiculo;
            this.placa_vehiculo = placa_vehiculo;
            this.nombreMecanico = nombreMecanico;
            this.trabajos = trabajos;
            this.tipoMantenimiento = tipoMantenimiento;
            this.repuesto = repuesto;
            this.totalMantenimiento= totalMantenimiento;
            this.nombreServicios = nombreServicios;
            this.totalServicios = totalServicios;
            this.subtotal = subtotal;
            this.totalPagar = totalPagar;
        }

        /// <summary>
        /// Propiedad para acceder al identificador del mantenimiento.
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Propiedad para acceder a la fecha del mantenimiento.
        /// </summary>
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        /// <summary>
        /// Propiedad para acceder al nombre del cliente asociado al mantenimiento.
        /// </summary>
        public string NombreCliente
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }

        /// <summary>
        /// Propiedad para acceder al vehículo asociado al mantenimiento.
        /// </summary>
        public string Nombre_vehiculo
        {
            get { return nombre_vehiculo; }
            set { nombre_vehiculo = value; }
        }
        public string Kilometraje_vehiculo
        {
            get { return kilometraje_vehiculo; }
            set { kilometraje_vehiculo = value; }
        }
        public string Placa_vehiculo
        {
            get { return placa_vehiculo; }
            set { placa_vehiculo = value; }
        }

        /// <summary>
        /// Propiedad para acceder al nombre del mecánico asignado al mantenimiento.
        /// </summary>
        public string NombreMecanico
        {
            get { return nombreMecanico; }
            set { nombreMecanico = value; }
        }

        /// <summary>
        /// Propiedad para acceder a los trabajos realizados en el mantenimiento.
        /// </summary>
        public string Trabajos
        {
            get { return trabajos; }
            set { trabajos = value; }
        }

        /// <summary>
        /// Propiedad para acceder al tipo de mantenimiento realizado.
        /// </summary>
        public string TipoMantenimiento
        {
            get { return tipoMantenimiento; }
            set { tipoMantenimiento = value; }
        }

        /// <summary>
        /// Propiedad para acceder a los repuestos asociados al mantenimiento.
        /// </summary>
        public string Repuesto
        {
            get { return repuesto; }
            set { repuesto = value; }
        }

        /// <summary>
        /// Propiedad para acceder al total del mantenimiento.
        /// </summary>
        public float TotalMantenimiento
        {
            get { return totalMantenimiento; }
            set { totalMantenimiento = value; }
        }

        /// <summary>
        /// Propiedad para acceder al nombre de los servicios asociados al mantenimiento.
        /// </summary>
        public string NombreServicios
        {
            get { return nombreServicios; }
            set { nombreServicios = value; }
        }     

        /// <summary>
        /// Propiedad para acceder al total de los servicios asociados al mantenimiento.
        /// </summary>
        public float TotalServicios
        {
            get { return totalServicios; }
            set { totalServicios = value; }
        }

        /// <summary>
        /// Propiedad para acceder al subtotal del mantenimiento.
        /// </summary>
        public float Subtotal
        {
            get { return subtotal; }
            set { subtotal = value; }
        }

        /// <summary>
        /// Propiedad para acceder al total a pagar por el mantenimiento.
        /// </summary>
        public float TotalPagar
        {
            get { return totalPagar; }
            set { totalPagar = value; }
        }
     


        /// <summary>
        /// Obtiene un listado de mantenimientos desde la capa de datos.
        /// </summary
        public DataTable getListadoMantenimiento()
        {      
            try
            {
                // Llama al método de la capa de datos para obtener el listado de mantenimientos
                return objIntMantenimiento.getListaMantenimiento();
            }
            catch (Exception e)
            {
                // Si ocurre una excepción, se lanza una nueva excepción con un mensaje descriptivo
                throw new Exception("Error al obtener listado de Mantenimiento -> " + e.Message);
            }
        }

        /// <summary>
        /// Guarda un mantenimiento en la base de datos.
        /// </summary>
        public bool GuardarMantenimiento()
        {
            try
            {
                // Se crea una lista de parámetros para enviar a la capa de datos
                List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
                lista.Add(new CD_Parameter_SP("@fecha", this.Fecha, SqlDbType.Date));
                lista.Add(new CD_Parameter_SP("@nombre_cliente", this.NombreCliente, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@nombre_vehiculo", this.Nombre_vehiculo, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@kilometraje_vehiculo", this.Kilometraje_vehiculo, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@placa_vehiculo", this.Placa_vehiculo, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@nombre_mecanico", this.NombreMecanico, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@trabajos", this.Trabajos, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@tipo_Mantenimiento", this.TipoMantenimiento, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@repuesto", this.Repuesto, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@total_mantenimiento", this.totalMantenimiento, SqlDbType.Float));
                lista.Add(new CD_Parameter_SP("@nombre_servicios", this.NombreServicios, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@Total_servicios", this.TotalServicios, SqlDbType.Float));          
                lista.Add(new CD_Parameter_SP("@subtotal_factura", this.Subtotal, SqlDbType.Float));
                lista.Add(new CD_Parameter_SP("@total_factura", this.TotalPagar, SqlDbType.Float));

                // Llama al método de la capa de datos para guardar el mantenimiento
                return objIntMantenimiento.CreaMantenimiento(lista);
            }
            catch (Exception e)
            {
                // Si ocurre una excepción, se lanza una nueva excepción con un mensaje descriptivo
                throw new Exception("Error al Guardar Datos de Mantenimiento -> " + e.Message);
            }
        }

        /// <summary>
        /// Actualiza un mantenimiento en la base de datos.
        /// </summary>
        public bool ActualizarMantenimiento()
        {
            try
            {
                // Se crea una lista de parámetros para enviar a la capa de datos
                List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
                lista.Add(new CD_Parameter_SP("@id", this.Id, SqlDbType.Int));
                lista.Add(new CD_Parameter_SP("@fecha", this.Fecha, SqlDbType.Date));
                lista.Add(new CD_Parameter_SP("@nombre_cliente", this.NombreCliente, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@nombre_vehiculo", this.Nombre_vehiculo, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@kilometraje_vehiculo", this.Kilometraje_vehiculo, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@placa_vehiculo", this.Placa_vehiculo, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@nombre_mecanico", this.NombreMecanico, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@trabajos", this.Trabajos, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@tipo_Mantenimiento", this.TipoMantenimiento, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@repuesto", this.Repuesto, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@total_mantenimiento", this.totalMantenimiento, SqlDbType.Float));
                lista.Add(new CD_Parameter_SP("@nombre_servicios", this.NombreServicios, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@Total_servicios", this.TotalServicios, SqlDbType.Float));
                lista.Add(new CD_Parameter_SP("@subtotal_factura", this.Subtotal, SqlDbType.Float));
                lista.Add(new CD_Parameter_SP("@total_factura", this.TotalPagar, SqlDbType.Float));

                // Llama al método de la capa de datos para actualizar el mantenimiento
                return objIntMantenimiento.ActualizarMantenimiento(lista);
            }
            catch (Exception e)
            {
                // Si ocurre una excepción, se lanza una nueva excepción con un mensaje descriptivo
                throw new Exception("Error al Guardar Datos de Mantenimiento -> " + e.Message);
            }
        }

        /// <summary>
        /// Elimina un mantenimiento de la base de datos.
        /// </summary>
        public bool EliminarMantenimiento()
        {
            try
            {
                // Se crea una lista de parámetros para enviar a la capa de datos
                List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
                lista.Add(new CD_Parameter_SP("@IdMantenimiento", this.Id, SqlDbType.Int));

                // Llama al método de la capa de datos para eliminar el mantenimiento
                return objIntMantenimiento.EliminaMantenimiento(lista);
            }
            catch (Exception e)
            {
                // Si ocurre una excepción, se lanza una nueva excepción con un mensaje descriptivo
                throw new Exception("Error al Eliminar Datos del Mantenimiento -> " + e.Message);
            }
        }
    }

}
