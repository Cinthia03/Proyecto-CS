using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.ExecuteSQL;

namespace CapaDatos.Interface
{
    /// <summary>
    /// Clase que proporciona métodos para interactuar con la capa de datos, realizando operaciones de negocio en la base de datos.
    /// </summary>
    public class Interface_Negocio
    {
        private ExecuteSQL.ExecuteSQL obj_bd = new ExecuteSQL.ExecuteSQL();
        public Interface_Negocio() { }

        /// <summary>
        /// Obtiene una lista de clientes desde la base de datos.
        /// </summary>
        public DataTable getListaCliente()
        {
            List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
            return obj_bd.ExecuteSPQuery("SP_GET_CLIENTE", lista);
        }

        /// <summary>
        /// Obtiene una lista de los vehículos desde la base de datos.
        /// </summary>
        public DataTable getListaVehiculo()
        {
            List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
            return obj_bd.ExecuteSPQuery("SP_GET_VEHICULO", lista);
        }

        /// <summary>
        /// Obtiene una lista de mecánicos desde la base de datos.
        /// </summary>
        public DataTable getListaMecanico()
        {
            List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
            return obj_bd.ExecuteSPQuery("SP_GET_MECANICO", lista);
        }

        /// <summary>
        /// Obtiene una lista de inventario de repuestos desde la base de datos.
        /// </summary>
        public DataTable getListaInventarioRepuesto()
        {
            List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
            return obj_bd.ExecuteSPQuery("SP_GET_INVENTARIO_REPUESTO", lista);
        }

        /// <summary>
        /// Obtiene una lista de servicios adicionales desde la base de datos.
        /// </summary>
        public DataTable getListaServiciosAdicionales()
        {
            List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
            return obj_bd.ExecuteSPQuery("SP_GET_SERVICIOS", lista);
        }





        //SP CLIENTE
        /// <summary>
        /// Crea un nuevo registro de Clientes en la base de datos.
        /// </summary>
        public bool CreaCliente(List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery("SP_CREA_CLIENTE", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Crear Cliente " + ex.Message);
            }
        }

        /// <summary>
        /// Actualiza un registro existente de Clientes en la base de datos.
        /// </summary>
        public bool ActualizarCliente(List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery("SP_ACTUALIZA_CLIENTE", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Actualizar Cliente " + ex.Message);
            }
        }

        /// <summary>
        /// Elimina un registro de Clientes de la base de datos.
        /// </summary>
        public bool EliminaCliente(List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery("SP_ELIMINA_CLIENTE", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Eliminar Cliente" + ex.Message);
            }
        }


        //SP VEHICULO
        /// <summary>
        /// Crea un nuevo registro de Vehiculos en la base de datos.
        /// </summary>
        public bool CreaVehiculo(List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery("SP_CREA_VEHICULO", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Crear vehiculo " + ex.Message);
            }
        }

        /// <summary>
        /// Actualiza un registro existente de Vehiculos en la base de datos.
        /// </summary>
        public bool ActualizarVehiculo(List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery("SP_ACTUALIZA_VEHICULO", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Actualizar vehiculo " + ex.Message);
            }
        }

        /// <summary>
        /// Elimina un registro de Vehiculos de la base de datos.
        /// </summary>
        public bool EliminaVehiculo(List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery("SP_ELIMINA_VEHICULO", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Eliminar vehiculo " + ex.Message);
            }
        }


        //SP MECANICO
        /// <summary>
        /// Crea un nuevo registro de Mecanico en la base de datos.
        /// </summary>
        public bool CreaMecanico(List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery("SP_CREA_MECANICO", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Crear Mecanico " + ex.Message);
            }
        }

        /// <summary>
        /// Actualiza un registro existente de Mecanico en la base de datos.
        /// </summary>
        public bool ActualizarMecanico(List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery("SP_ACTUALIZA_MECANICO", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Actualizar Mecanico " + ex.Message);
            }
        }

        /// <summary>
        /// Elimina un registro de Mecanico de la base de datos.
        /// </summary>
        public bool EliminaMecanico(List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery("SP_ELIMINA_MECANICO", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Eliminar Mecanico " + ex.Message);
            }
        }


        //SP INVENTARIO REPUESTO
        /// <summary>
        /// Crea un nuevo registro de repuesto en el inventario en la base de datos.
        /// </summary>
        public bool CreaInventarioRepuesto(List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery("SP_CREA_INVENTARIO_REPUESTO", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Crear Inventario Repuesto " + ex.Message);
            }
        }

        /// <summary>
        /// Actualiza un registro existente de repuesto en el inventario en la base de datos.
        /// </summary>
        public bool ActualizarInventarioRepuesto(List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery("SP_ACTUALIZA_INVENTARIO_REPUESTO", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Actualizar Inventario Repuesto " + ex.Message);
            }
        }

        /// <summary>
        /// Elimina un registro de repuesto en el inventario de la base de datos.
        /// </summary>
        public bool EliminaInventarioRepuesto(List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery("SP_ELIMINA_INVENTARIO_REPUESTO", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Eliminar Inventario Repuesto  " + ex.Message);
            }
        }


        //SP SERVICIOS ADICIONALES
        /// <summary>
        /// Crea un nuevo registro de servicios adicionales en la base de datos.
        /// </summary>
        public bool CreaServiciosAdicionales(List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery("SP_CREA_SERVICIOS", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Crear Servicios adicionales " + ex.Message);
            }
        }

        /// <summary>
        /// Actualiza un registro existente de servicios adicionales en la base de datos.
        /// </summary>
        public bool ActualizarServiciosAdicionales(List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery("SP_ACTUALIZA_SERVICIOS", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Actualizar Servicios Adicionales " + ex.Message);
            }
        }

        /// <summary>
        /// Elimina un registro de servicios adicionales de la base de datos.
        /// </summary>
        public bool EliminaServiciosAdicionales(List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery("SP_ELIMINA_SERVICIOS", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Eliminar Servicios Adicionales " + ex.Message);
            }
        }



        //SP Mantenimiento
        /// <summary>
        /// Crea un nuevo registro de mantenimiento en la base de datos.
        /// </summary>
        public bool CreaMantenimiento(List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery("SP_CREA_MANTENIMIENTO", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Crear Mantenimiento " + ex.Message);
            }
        }

        /// <summary>
        /// Actualiza un registro existente de mantenimiento en la base de datos.
        /// </summary>
        public bool ActualizarMantenimiento(List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery("SP_ACTUALIZA_MANTENIMIENTO", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Actualizar el Mantenimiento " + ex.Message);
            }
        }

        /// <summary>
        /// Obtiene una lista de registros de mantenimiento desde la base de datos.
        /// </summary>
        public DataTable getListaMantenimiento()
        {
            List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
            return obj_bd.ExecuteSPQuery("SP_GET_MANTENIMIENTO", lista);
        }

        /// <summary>
        /// Elimina un registro de mantenimiento de la base de datos.
        /// </summary>
        public bool EliminaMantenimiento(List<CD_Parameter_SP> lista)
        {
            try
            {
                return obj_bd.ExecuteSPNonQuery("SP_ELIMINA_MANTENIMIENTO", lista);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Eliminar Mantenimiento " + ex.Message);
            }
        }
    }
}

