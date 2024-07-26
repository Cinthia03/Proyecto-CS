using CapaNegocio.LN_Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using CapaException;

namespace CapaPresentacion
{
    /// Clase que representa el formulario para la seleccion de repuestos.

    public partial class frmRepuestos : Form
    {
        //CN_Repuesto obj_cn_repuesto = new CN_Repuesto();
        CN_InventarioRepuesto obj_cn_inventario_repuesto = new CN_InventarioRepuesto();
        private bool is_nuevo = false;
        int posicion = 0;
        int idNew = 1;

        /// <summary>
        /// Constructor de la clase frmRepuestos.
        /// Inicializa los componentes del formulario.
        /// </summary>
        public frmRepuestos()
        {
            InitializeComponent();
            cmbRepuestos.DropDownStyle = ComboBoxStyle.DropDownList;
            dgvRepuestos.AllowUserToAddRows = false;
            
            for (int i = 0; i < dgvRepuestos.ColumnCount; i++)
            {
                dgvRepuestos.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            };
            llenarListaRepuestos();
        }


        private void llenarListaRepuestos() {
            foreach (DataRow row in obj_cn_inventario_repuesto.getListadoInventarioRepuesto().Rows)
            {
                cmbRepuestos.Items.Add(row[1].ToString());
            }
 
        }

        /// <summary>
        /// Configura los controles para añadir un nuevo repuesto.
        /// </summary>
        private void setearControles()
        {
            
            txtId.Text = idNew.ToString();
            cmbRepuestos.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtCantidad.Text = string.Empty;
            txtTotal.Text = string.Empty;
        }

        /// <summary>
        /// Maneja el evento Click del botón "Nuevo".
        /// </summary>
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            is_nuevo = true;
            setearControles();
            btnGrabar.Enabled = true;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            btnEnviar.Enabled = true;
            cmbRepuestos.Enabled = true;
            txtCantidad.ReadOnly = false;
            
        }

        /// <summary>
        /// Maneja el evento Click del botón "Grabar".
        /// </summary>
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que las cadenas sean números válidos
                if (!float.TryParse(txtPrecio.Text, out float precio) || !int.TryParse(txtCantidad.Text, out int cantidad))
                {
                    throw new AccesoException("El precio y la cantidad deben ser números válidos.");
                }

                // Calcular el total
                float total = precio * cantidad;

                // Mostrar el total en el campo correspondiente
                txtTotal.Text = total.ToString("F2");

                if (is_nuevo)
                {
                    // Añadir un nuevo repuesto a la tabla
                    string nombre;
                    nombre = cmbRepuestos.Text;
                    precio = Convert.ToSingle(txtPrecio.Text);
                    cantidad = Convert.ToInt32(txtCantidad.Text);
                    total = Convert.ToSingle(txtTotal.Text);

                    dgvRepuestos.Rows.Add(idNew + "", nombre, precio, cantidad, total);
                    idNew = idNew + 1;
                    btnGrabar.Enabled = false;
                    btnNuevo.Enabled = true;
                    is_nuevo = false;
                    cmbRepuestos.Enabled = false;
                    txtCantidad.ReadOnly = true;
                }
                else
                {
                    // Actualizar un repuesto existente en la tabla
                    string nombre;
                    nombre = cmbRepuestos.Text;
                    precio = Convert.ToSingle(txtPrecio.Text);
                    cantidad = Convert.ToInt32(txtCantidad.Text);
                    total = Convert.ToSingle(txtTotal.Text);

                    dgvRepuestos[1, posicion].Value = cmbRepuestos.Text;
                    dgvRepuestos[2, posicion].Value = txtPrecio.Text;
                    dgvRepuestos[3, posicion].Value = txtCantidad.Text;
                    dgvRepuestos[4, posicion].Value = txtTotal.Text;

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
        /// Maneja el evento CellClick del DataGridView dgvRepuestos.
        /// Muestra los detalles del repuesto seleccionado en los controles correspondientes.
        /// </summary>
        private void dgvRepuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                posicion = dgvRepuestos.CurrentRow.Index;
                cmbRepuestos.Text = dgvRepuestos[1, posicion].Value.ToString();
                txtPrecio.Text = dgvRepuestos[2, posicion].Value.ToString();
                txtCantidad.Text = dgvRepuestos[3, posicion].Value.ToString();
                txtTotal.Text = dgvRepuestos[4, posicion].Value.ToString();

                btnNuevo.Enabled = true;
                btnGrabar.Enabled = true;
                btnEliminar.Enabled = true;
                cmbRepuestos.Enabled = true;
                txtCantidad.ReadOnly = false;
            }
        }

        /// <summary>
        /// Maneja el evento Click del botón "Eliminar".
        /// Elimina el repuesto seleccionado del DataGridView dgvRepuestos.
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvRepuestos.SelectedRows)
            {
                dgvRepuestos.Rows.RemoveAt(row.Index);
            }
            ObtenerTotal();
        }

        /// <summary>
        /// Calcula y muestra el total de los repuestos en el DataGridView dgvRepuestos.
        /// </summary>
        private void ObtenerTotal()
        {
            // OBTENER TOTAL DE REPUESTOS CORRECTIVO
            float total = 0;

            foreach (DataGridViewRow row in dgvRepuestos.Rows)
            {
                if (row.Cells[4].Value != null && float.TryParse(row.Cells[4].Value.ToString(), out float valorCelda))
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
        /// Maneja el evento SelectedIndexChanged del ComboBox cmbRepuestos.
        /// Asigna el precio correspondiente al repuesto seleccionado.
        /// </summary>
        private void cmbRepuestos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = 0;
            double precio = 0;
            indice = cmbRepuestos.SelectedIndex;
            precio=double.Parse(obj_cn_inventario_repuesto.getListadoInventarioRepuesto().Rows[indice][2].ToString());
            txtPrecio.Text = precio.ToString();
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
        /// Obtiene el total de los repuestos seleccionados.
        /// </summary>
        public string ObtenerSeleccionesTotal()
        {
            string total = txtTot.Text;
            return total;
        }
        public int getCountRows()
        {
            return dgvRepuestos.RowCount;
        }

        /// <summary>
        /// Obtiene el repuestos seleccionado.
        /// </summary>
        public string ObtenerSeleccionRepuestos(int i)
        {
            string repuestos=(dgvRepuestos.Rows[i].Cells[1].Value.ToString());
            return repuestos;
        }
    }
}
