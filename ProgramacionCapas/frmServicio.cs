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
    /// Clase que representa el formulario para la seleccion de servicios.

    public partial class frmServicio : Form
    {
        CN_ServiciosAdicionales obj_cn_inventario_servicio = new CN_ServiciosAdicionales();
        private bool is_nuevo = false;
        private int idNew = 1, posicion = 0;

        /// <summary>
        /// Constructor de la clase frmServicio.
        /// Inicializa los componentes del formulario.
        /// </summary>
        public frmServicio()
        {
            InitializeComponent();
            cmbServicios.DropDownStyle = ComboBoxStyle.DropDownList;
            dgvServicios.AllowUserToAddRows = false;
            for (int i = 0; i < dgvServicios.ColumnCount; i++)
            {
                dgvServicios.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            };
            llenarListaServicios();
        }
        
        private void llenarListaServicios()
        {
            foreach (DataRow row in obj_cn_inventario_servicio.getListadoServiciosAdicionales().Rows)
            {
                cmbServicios.Items.Add(row[1].ToString());
            }

        }

        /// <summary>
        /// Obtiene el servicio seleccionado.
        /// </summary>
        public string ObtenerSeleccionServicios(int i)
        {
            string? v = dgvServicios.Rows[i].Cells[1].Value.ToString();
            if (v != null)
                return v;
            else
                return "";
        }

        /// <summary>
        /// Obtiene el total de los servicios seleccionados.
        /// </summary>
        public string ObtenerSeleccionesTotal()
        {
            string total = txtTot.Text;
            return total;
        }
        
        public int getCountRows()
        {
            return dgvServicios.RowCount;
        }

        

        /// <summary>
        /// Configura los controles para añadir un nuevo servicio.
        /// </summary>
        public void setearControles()
        {

            txtId.Text = idNew.ToString();
            cmbServicios.Text = string.Empty;
            txtPrecio.Text = string.Empty;
        }

        /// <summary>
        /// Maneja el evento Click del botón "Nuevo".
        /// </summary>
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            is_nuevo = true;
            setearControles();
            btnGrabar.Enabled = true;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnEnviar.Enabled = true;
            cmbServicios.Enabled = true;
        }

        /// <summary>
        /// Maneja el evento Click del botón "Grabar".
        /// </summary>
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que las cadenas sean números válidos
                if (!float.TryParse(txtPrecio.Text, out float precio))
                {
                    throw new AccesoException("El precio debe tener números válidos.");
                }

                // Calcular el total
                float total = precio;

                // Mostrar el total en el campo correspondiente
                txtTot.Text = total.ToString("F2");

                if (is_nuevo)
                {
                    // Añadir un nuevo servicio a la tabla
                    string nombre;
                    nombre = cmbServicios.Text;
                    precio = Convert.ToSingle(txtPrecio.Text);
                    total = Convert.ToSingle(txtTot.Text);

                    dgvServicios.Rows.Add(idNew + "", nombre, precio);
                    idNew = idNew + 1;
                    btnGrabar.Enabled = false;
                    btnNuevo.Enabled = true;
                    is_nuevo = false;
                    cmbServicios.Enabled = false;
                }
                else
                {
                    // Actualizar un repuesto existente en la tabla
                    string nombre;
                    nombre = cmbServicios.Text;
                    precio = Convert.ToSingle(txtPrecio.Text);
                    total = Convert.ToSingle(txtTot.Text);

                    dgvServicios[1, posicion].Value = cmbServicios.Text;
                    dgvServicios[2, posicion].Value = txtPrecio.Text;

                    btnGrabar.Enabled = false;
                    btnNuevo.Enabled = true;
                    is_nuevo = false;
                }
                ObtenerTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Maneja el evento Click del botón "Enviar".
        /// Obtiene el total seleccionado y cierra el formulario.
        /// </summary>
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string TotalSeleccionados = ObtenerSeleccionesTotal();
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Maneja el evento Click del botón "Eliminar".
        /// Elimina el servicio seleccionado del DataGridView dgvServicios.
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvServicios.SelectedRows)
            {
                dgvServicios.Rows.RemoveAt(row.Index);
            }
            posicion -= 1;
            ObtenerTotal();
        }

        /// <summary>
        /// Calcula y muestra el total de los servicios en el DataGridView dgvServicios.
        /// </summary>
        private void ObtenerTotal()
        {
            // OBTENER TOTAL DE SERVICIOS
            float total = 0;

            foreach (DataGridViewRow row in dgvServicios.Rows)
            {
                if (row.Cells[2].Value != null && float.TryParse(row.Cells[2].Value.ToString(), out float valorCelda))
                {
                    total += valorCelda;
                }
                else
                {
                    // Manejar el caso en el que el valor no es numérico (podría ser nulo o no numérico)
                    Console.WriteLine($"La celda en la fila {row.Index} no contiene un valor numérico.");
                }
            }
            txtTot.Text = total.ToString("F2");
        }

        /// <summary>
        /// Maneja el evento SelectedIndexChanged del ComboBox cmbServicios.
        /// Asigna el precio correspondiente al servicio seleccionado.
        /// </summary>
        private void cmbServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = 0;
            double precio = 0;
            indice = cmbServicios.SelectedIndex;
            precio = double.Parse(obj_cn_inventario_servicio.getListadoServiciosAdicionales().Rows[indice][2].ToString());
            txtPrecio.Text = precio.ToString();
        }

        /// <summary>
        /// Maneja el evento CellClick del DataGridView dgvServicios.
        /// Muestra los detalles del servicios seleccionado en los controles correspondientes.
        /// </summary>
        private void dgvServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                posicion = dgvServicios.CurrentRow.Index;
                cmbServicios.Text = dgvServicios[1, posicion].Value.ToString();
                txtPrecio.Text = dgvServicios[2, posicion].Value.ToString();

                btnNuevo.Enabled = true;
                btnGrabar.Enabled = true;
                btnEliminar.Enabled = true;
                cmbServicios.Enabled = true;
            } 
        }
    }
}
