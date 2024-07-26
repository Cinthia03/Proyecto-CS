using CapaException;
using CapaNegocio.LN_Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    // Clase que representa el formulario de gestión de clientes 
    public partial class frmGestionCliente : Form
    {
        // Objeto para acceder a la lógica de negocio de clientes 
        CN_Cliente obj_cn_cliente = new CN_Cliente();
        private bool isNew = false;
        private int nextId;

        /// <summary>
        /// Constructor de la clase `frmGestionCliente`.
        /// Inicializa los componentes del formulario.
        /// </summary>
        public frmGestionCliente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Maneja el evento Load del formulario.
        /// Carga los datos en el DataGridView.
        /// </summary>
        private void frmCliente_Vehiculo_Load(object sender, EventArgs e)
        {
            LoadDgvCliente();
        }

        /// <summary>
        /// Establece los controles del formulario a sus valores predeterminados.
        /// </summary>
        private void setearControles()
        {
            if (dgvClienteVehiculo.RowCount > 0)
                nextId = int.Parse(dgvClienteVehiculo.Rows[dgvClienteVehiculo.RowCount - 1].Cells["ID"].Value.ToString()) + 1;
            else
                nextId = 1;
            txtId.Text = nextId.ToString();
            txtNombre.Text = string.Empty;
            txtEdad.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtCorreos.Text = string.Empty;
            txtContactoEmergencia.Text = string.Empty;
        }

        /// <summary>
        /// Maneja el evento Click del botón "Nuevo".
        /// Prepara el formulario para ingresar un nuevo registro.
        /// </summary>
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            isNew = true;
            setearControles();
            btnGrabar.Enabled = true;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            
        }

        /// <summary>
        /// Maneja el evento Click del botón "Grabar".
        /// Guarda un nuevo registro o actualiza uno existente.
        /// </summary>
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                // Si es un nuevo registro
                if (isNew)
                {
                    // Asigna los valores de los controles a las propiedades del objeto de negocio
                    obj_cn_cliente.Nombre = txtNombre.Text;
                    obj_cn_cliente.Edad = Convert.ToInt16(txtEdad.Text);
                    obj_cn_cliente.Cedula = txtCedula.Text;
                    obj_cn_cliente.Celular = txtCelular.Text;
                    obj_cn_cliente.Correo = txtCorreos.Text;
                    obj_cn_cliente.Contacto_emergencia = txtContactoEmergencia.Text;

                    // Intenta guardar el nuevo registro
                    if (obj_cn_cliente.GuardarCliente(obj_cn_cliente))
                        MessageBox.Show("Registro Guardado");
                    else
                        throw new AccesoException("Registro No pudo Grabarse");

                    // Recarga el DataGridView y actualiza los botones
                    LoadDgvCliente();
                    btnGrabar.Enabled = false;
                    btnNuevo.Enabled = true;
                    isNew = false;
                }
                else
                {
                    // Si es una actualización, asigna los valores de los controles a las propiedades del objeto de negocio
                    obj_cn_cliente.Id = Convert.ToInt16(txtId.Text);
                    obj_cn_cliente.Nombre = txtNombre.Text;
                    obj_cn_cliente.Edad = Convert.ToInt16(txtEdad.Text);
                    obj_cn_cliente.Cedula = txtCedula.Text;
                    obj_cn_cliente.Celular = txtCelular.Text;
                    obj_cn_cliente.Correo = txtCorreos.Text;
                    obj_cn_cliente.Contacto_emergencia = txtContactoEmergencia.Text;

                    // Intenta actualizar el registro
                    if (obj_cn_cliente.ActualizarCliente(obj_cn_cliente))
                    {
                        MessageBox.Show("Registro Actualizado con Exito");
                        LoadDgvCliente();
                    }
                    else
                        throw new AccesoException("Registro NO pudo ser Actualizado");

                    // Actualiza los botones
                    btnGrabar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnNuevo.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                // Muestra cualquier error ocurrido durante la operación
                throw new AccesoException(ex.Message);
            }
        }

        /// <summary>
        /// Carga la lista de clientes y vehículos en el DataGridView.
        /// </summary>
        private void LoadDgvCliente()
        {
            try
            {
                dgvClienteVehiculo.DataSource = obj_cn_cliente.getListadoCliente();
                dgvClienteVehiculo.AllowUserToAddRows = false;
                for (int i = 0; i < dgvClienteVehiculo.ColumnCount; i++) {
                    dgvClienteVehiculo.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable; 
                }
            }
            catch (Exception ex)
            {
                throw new AccesoException(ex.Message);
            }
            dgvClienteVehiculo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClienteVehiculo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        /// <summary>
        /// Maneja el evento Click de una celda en el DataGridView.
        /// Muestra los detalles del registro seleccionado en los controles del formulario.
        /// </summary>
        private void dgvClienteVehiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var fila = e.RowIndex;
            if (fila >= 0)
            {
                txtId.Text = dgvClienteVehiculo.Rows[fila].Cells["ID"].Value.ToString();
                txtNombre.Text = dgvClienteVehiculo.Rows[fila].Cells["NOMBRE"].Value.ToString();
                txtEdad.Text = dgvClienteVehiculo.Rows[fila].Cells["EDAD"].Value.ToString();
                txtCedula.Text = dgvClienteVehiculo.Rows[fila].Cells["CEDULA"].Value.ToString();
                txtCelular.Text = dgvClienteVehiculo.Rows[fila].Cells["CELULAR"].Value.ToString();
                txtCorreos.Text = dgvClienteVehiculo.Rows[fila].Cells["CORREO"].Value.ToString();
                txtContactoEmergencia.Text = dgvClienteVehiculo.Rows[fila].Cells["CONTACTO_EMERGENCIA"].Value.ToString();

                btnNuevo.Enabled = true;
                btnGrabar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        /// <summary>
        /// Maneja el evento Click del botón "Eliminar".
        /// Elimina el registro seleccionado.
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                obj_cn_cliente.Id = Convert.ToInt16(txtId.Text);
                if (obj_cn_cliente.EliminarCliente(obj_cn_cliente))
                {
                    MessageBox.Show("Registro Eliminado con Exito");
                    LoadDgvCliente();
                }
                else
                    throw new AccesoException("No se Pudo Eliminar el Registro");
                btnGrabar.Enabled = false;
                btnEliminar.Enabled = false;
                btnNuevo.Enabled = true;
            }
            catch (Exception ex)
            {
                throw new AccesoException(ex.Message);
            }
        }
    }
}
