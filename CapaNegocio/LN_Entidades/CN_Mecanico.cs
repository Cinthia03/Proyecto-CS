using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.ExecuteSQL;
using CapaDatos.Interface;

namespace CapaNegocio.LN_Entidades
{
    /// <summary>
    /// Clase que representa la entidad Mecánico en la capa de negocio.
    /// </summary>
    public class CN_Mecanico
    {
        //private ExecuteSQL objCapaDatos = new ExecuteSQL();

        private Interface_Negocio objIntMecanico = new Interface_Negocio();
        private int id;
        private string nombre;
        private string cedula;
        private string celular;
        private string correo;

        /// <summary>
        /// Constructor predeterminado de la clase CN_Mecanico.
        /// </summary>
        public CN_Mecanico()
        {
            id = 0;
            nombre = string.Empty;
            cedula = string.Empty;
            celular = string.Empty;
            correo = string.Empty;
        }

        /// <summary>
        /// Constructor parametrizado de la clase CN_Mecanico.
        /// </summary>
        public CN_Mecanico(int id, string nombre, string cedula, string celular, string correo)
        {
            this.id = id;
            this.nombre = nombre;
            this.cedula = cedula;
            this.celular = celular;
            this.correo = correo;
        }

        /// <summary>
        /// ID del mecánico.
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Nombre del mecánico.
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        /// <summary>
        /// Número de cédula del mecánico.
        /// </summary>
        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        /// <summary>
        /// Número de celular del mecánico.
        /// </summary>
        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        /// <summary>
        /// Correo electrónico del mecánico.
        /// </summary>
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }


        /// <summary>
        /// Obtiene un listado de mecánicos desde la capa de datos.
        /// </summary>
        public DataTable getListadoMecanico()
        {
            try
            {
                // Intenta obtener el listado de mecánicos desde la capa de datos
                return objIntMecanico.getListaMecanico();
            }
            catch (Exception e)
            {
                // Si ocurre un error, se lanza una excepción con un mensaje descriptivo
                throw new Exception("Error al obtener listado de mecanico -> " + e.Message);
            }
        }

        /// <summary>
        /// Guarda un nuevo mecánico en la base de datos.
        /// </summary>
        public bool GuardarMecanico(CN_Mecanico mecanico)
        {
            try
            {
                // Crea una lista de parámetros para enviar a la capa de datos
                List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
                lista.Add(new CD_Parameter_SP("@nombre", mecanico.Nombre, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@cedula", mecanico.Cedula, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@celular", mecanico.Celular, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@correo", mecanico.Correo, SqlDbType.Text));

                // Intenta guardar el mecánico en la capa de datos
                return objIntMecanico.CreaMecanico(lista);

            }
            catch (Exception e)
            {
                // Si ocurre un error, se lanza una excepción con un mensaje descriptivo
                throw new Exception("Error al Guardar Datos de Mecanico -> " + e.Message);
            }

        }

        /// <summary>
        /// Actualiza la información de un mecánico en la base de datos.
        /// </summary>
        public bool ActualizarMecanico(CN_Mecanico mecanico)
        {
            try
            {
                // Crea una lista de parámetros para enviar a la capa de datos
                List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
                lista.Add(new CD_Parameter_SP("@id", mecanico.Id, SqlDbType.Int));
                lista.Add(new CD_Parameter_SP("@nombre", mecanico.Nombre, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@cedula", mecanico.Cedula, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@celular", mecanico.Celular, SqlDbType.Text));
                lista.Add(new CD_Parameter_SP("@correo", mecanico.Correo, SqlDbType.Text));

                // Intenta actualizar la información del mecánico en la capa de datos
                return objIntMecanico.ActualizarMecanico(lista);

            }
            catch (Exception e)
            {
                // Si ocurre un error, se lanza una excepción con un mensaje descriptivo
                throw new Exception("Error al Actualizar Datos de Mecanico -> " + e.Message);
            }

        }

        /// <summary>
        /// Elimina un mecánico de la base de datos.
        /// </summary>
        public bool EliminarMecanico(CN_Mecanico mecanico)
        {
            try
            {
                // Crea una lista de parámetros para enviar a la capa de datos
                List<CD_Parameter_SP> lista = new List<CD_Parameter_SP>();
                lista.Add(new CD_Parameter_SP("@IdMecanico", mecanico.Id, SqlDbType.Int));

                // Intenta eliminar al mecánico de la capa de datos
                return objIntMecanico.EliminaMecanico(lista);
            }
            catch (Exception e)
            {
                // Si ocurre un error, se lanza una excepción con un mensaje descriptivo
                throw new Exception("Error al Eliminar Datos de Mecanico -> " + e.Message);
            }
        }
    }
}
