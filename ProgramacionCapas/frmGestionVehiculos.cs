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
    // Clase que representa el formulario de gestión de vehículos
    public partial class frmGestionVehiculos : Form
    {
        // Objeto para acceder a la lógica de negocio de clientes y vehículos
        CN_Vehiculo obj_cn_vehiculo = new CN_Vehiculo();
        CN_Cliente obj_cn_cliente = new CN_Cliente();
        
        // Variable para indicar si se está creando un nuevo registro
        private bool is_nuevo = false;
        private int nextId;

        /// <summary>
        /// Constructor de la clase `frmGestionVehiculo`.
        /// Inicializa los componentes del formulario.
        /// </summary>
        public frmGestionVehiculos()
        {
            InitializeComponent();
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadDgvClientes();
        }

        /// <summary>
        /// Maneja el evento Load del formulario.
        /// Carga los datos en el DataGridView.
        /// </summary>
        private void frmGestionVehiculos_Load(object sender, EventArgs e)
        {
            LoadDgvVehiculo();
        }

        /// <summary>
        /// Establece los controles del formulario a sus valores predeterminados.
        /// </summary>
        private void setearControles()
        {
            int countRows = dgvVehiculo.RowCount;
            if (countRows > 0)
                nextId = int.Parse(dgvVehiculo.Rows[countRows - 1].Cells["ID"].Value.ToString()) + 1;
            else
                nextId = 1;
            txtId.Text = nextId.ToString();
            txtVehiculo.Text = string.Empty;
            txtKilometraje.Text = string.Empty;
            txtPlaca.Text = string.Empty;
            cmbCliente.Text = string.Empty;
        }

        /// <summary>
        /// Maneja el evento Click del botón "Nuevo".
        /// Prepara el formulario para ingresar un nuevo registro.
        /// </summary>
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            is_nuevo = true;
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
                if (is_nuevo)
                {
                    // Asigna los valores de los controles a las propiedades del objeto de negocio
                    obj_cn_vehiculo.Vehiculo = txtVehiculo.Text;
                    obj_cn_vehiculo.Kilometraje = txtKilometraje.Text;
                    obj_cn_vehiculo.Placa = txtPlaca.Text;
                    obj_cn_vehiculo.Cliente = cmbCliente.Text;
                    
                    // Intenta guardar el nuevo registro
                    if (obj_cn_vehiculo.GuardarVehiculo(obj_cn_vehiculo))
                        MessageBox.Show("Registro Guardado");
                    else
                        throw new AccesoException("Registro No pudo Grabarse");
                    
                    // Recarga el DataGridView y actualiza los botones
                    LoadDgvVehiculo();
                    btnGrabar.Enabled = false;
                    btnNuevo.Enabled = true;
                    is_nuevo = false;
                }
                else
                {
                    // Si es una actualización, asigna los valores de los controles a las propiedades del objeto de negocio
                    obj_cn_vehiculo.Id = Convert.ToInt16(txtId.Text);
                    obj_cn_vehiculo.Vehiculo = txtVehiculo.Text;
                    obj_cn_vehiculo.Kilometraje = txtKilometraje.Text;
                    obj_cn_vehiculo.Placa = txtPlaca.Text;
                    obj_cn_vehiculo.Cliente = cmbCliente.Text;

                    // Intenta actualizar el registro
                    if (obj_cn_vehiculo.ActualizarVehiculo(obj_cn_vehiculo))
                    {
                        MessageBox.Show("Registro Actualizado con Exito");
                        LoadDgvVehiculo();
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
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Carga la lista de vehículos en el DataGridView.
        /// </summary>
        private void LoadDgvVehiculo()
        {
            try
            {
                dgvVehiculo.DataSource = obj_cn_vehiculo.getListadoVehiculo();
                dgvVehiculo.AllowUserToAddRows = false;
                for (int i = 0; i < dgvVehiculo.ColumnCount; i++)
                {
                    dgvVehiculo.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception ex)
            {
                throw new AccesoException(ex.Message);
            }
            dgvVehiculo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVehiculo.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        /// <summary>
        /// Maneja el evento Click de una celda en el DataGridView.
        /// Muestra los detalles del registro seleccionado en los controles del formulario.
        /// </summary>
        private void dgvVehiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var fila = e.RowIndex;
            if (fila >= 0)
            {
                txtId.Text = dgvVehiculo.Rows[fila].Cells["ID"].Value.ToString();
                txtVehiculo.Text = dgvVehiculo.Rows[fila].Cells["VEHICULO"].Value.ToString();
                txtKilometraje.Text = dgvVehiculo.Rows[fila].Cells["KILOMETRAJE"].Value.ToString();
                txtPlaca.Text = dgvVehiculo.Rows[fila].Cells["PLACA"].Value.ToString();
                cmbCliente.Text = dgvVehiculo.Rows[fila].Cells["CLIENTE"].Value.ToString();

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
                obj_cn_vehiculo.Id = Convert.ToInt16(txtId.Text);
                if (obj_cn_vehiculo.EliminarVehiculo(obj_cn_vehiculo))
                {
                    MessageBox.Show("Registro Eliminado con Exito");
                    LoadDgvVehiculo();
                }
                else
                    MessageBox.Show("No se Pudo Eliminar el Registro");
                btnGrabar.Enabled = false;
                btnEliminar.Enabled = false;
                btnNuevo.Enabled = true;
            }
            catch (Exception ex)
            {
                throw new AccesoException(ex.Message);
            }
        }

        /// <summary>
        /// Obtener el nombre del cliente en un combo box
        /// </summary>
        private void LoadDgvClientes()
        {
            try
            {
                DataTable dtCliente = obj_cn_cliente.getListadoCliente();
                cmbCliente.DataSource = dtCliente;
                cmbCliente.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
                throw new AccesoException("Error al cargar Mecanico: " + ex.Message);
            }
        }

    }
}
