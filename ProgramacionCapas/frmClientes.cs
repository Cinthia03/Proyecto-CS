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
    // Clase que representa el formulario de clientes

    public partial class frmClientes : Form
    {
        // Objeto para acceder a la lógica de negocio de clientes y vehículos
        CN_Vehiculo obj_cn_vehiculo = new CN_Vehiculo();
        int filaSeleccionada = -1;

        /// <summary>
        /// Constructor de la clase `frmClientes`.
        /// Inicializa los componentes del formulario y carga los datos en el DataGridView.
        /// </summary>
        public frmClientes()
        {
            InitializeComponent();
            LoadDgvClientes();
        }

        /// <summary>
        /// Carga la lista de clientes y vehículos en el DataGridView.
        /// </summary>
        private void LoadDgvClientes()
        {
            try
            {
                dgvCargaClientes.DataSource = obj_cn_vehiculo.getListadoVehiculo();
                dgvCargaClientes.AllowUserToAddRows = false;
                for (int i = 0; i < dgvCargaClientes.ColumnCount; i++)
                {
                    dgvCargaClientes.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvCargaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCargaClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        /// <summary>
        /// Maneja el evento de doble clic en una celda del DataGridView.
        /// Obtiene el nombre y el vehículo del cliente seleccionado, cierra el formulario y establece el resultado del diálogo como OK.
        /// </summary>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
            ObtenerNombre();
            ObtenerVehiculo();
            ObtenerKilometraje();
            ObtenerPlaca();
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Obtiene el nombre del cliente seleccionado en el DataGridView.
        /// </summary>
        /// <returns>Nombre del cliente o "N/A" si no hay ninguna fila seleccionada.</returns>
        public string ObtenerNombre()
        {
            if (filaSeleccionada >= 0)
            {
                string nombre = dgvCargaClientes.Rows[filaSeleccionada].Cells["CLIENTE"].Value.ToString();
                return nombre;
            }
            else
            {
                return "N/A";
            }
        }

        /// <summary>
        /// Obtiene el vehículo del cliente seleccionado en el DataGridView.
        /// </summary>
        /// <returns>Nombre del vehículo o "N/A" si no hay ninguna fila seleccionada.</returns>
        public string ObtenerVehiculo()
        {
            if (filaSeleccionada >= 0)
            {
                string nombre = dgvCargaClientes.Rows[filaSeleccionada].Cells["VEHICULO"].Value.ToString();
                return nombre;
            }
            else
            {
                return "N/A";
            }
        }

        public string ObtenerKilometraje()
        {
            if (filaSeleccionada >= 0)
            {
                string nombre = dgvCargaClientes.Rows[filaSeleccionada].Cells["KILOMETRAJE"].Value.ToString();
                return nombre;
            }
            else
            {
                return "N/A";
            }
        }

        public string ObtenerPlaca()
        {
            if (filaSeleccionada >= 0)
            {
                string nombre = dgvCargaClientes.Rows[filaSeleccionada].Cells["PLACA"].Value.ToString();
                return nombre;
            }
            else
            {
                return "N/A";
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            LoadDgvClientes();
        }
    }
}
