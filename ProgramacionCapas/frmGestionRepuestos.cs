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
    // Clase que representa el formulario de gestión del inventario de repuestos

    public partial class frmGestionRepuestos : Form
    {
        // Objeto para acceder a la lógica de negocio de inventario de repuestos
        CN_InventarioRepuesto obj_cn_inventario_repuesto = new CN_InventarioRepuesto();
        // Variable para indicar si se está creando un nuevo registro
        private bool is_nuevo = false;
        private int nextId;

        /// <summary>
        /// Constructor de la clase `frmGestionRepuesto`.
        /// Inicializa los componentes del formulario.
        /// </summary>
        public frmGestionRepuestos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Maneja el evento Load del formulario.
        /// Carga los datos en el DataGridView.
        /// </summary>
        private void frmGestionInventario_Load(object sender, EventArgs e)
        {
            LoadDgvInventarioRespuesto();
        }

        /// <summary>
        /// Establece los controles del formulario a sus valores predeterminados.
        /// </summary>
        private void setearControles()
        {
            int countRows = dgvInventarioRepuestos.RowCount;
            if (countRows > 0)
                nextId = int.Parse(dgvInventarioRepuestos.Rows[countRows - 1].Cells["ID"].Value.ToString()) + 1;
            else
                nextId = 1;
            txtId.Text = nextId.ToString();
            txtNombreRepuesto.Text = string.Empty;
            txtPrecioRepuesto.Text = string.Empty;
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
                    obj_cn_inventario_repuesto.Nombre_repuesto = txtNombreRepuesto.Text;
                    obj_cn_inventario_repuesto.Precio = Convert.ToSingle(txtPrecioRepuesto.Text);
                    
                    // Intenta guardar el nuevo registro
                    if (obj_cn_inventario_repuesto.GuardarInventarioRepuesto(obj_cn_inventario_repuesto))
                        MessageBox.Show("Registro Guardado");
                    else
                        throw new AccesoException("Registro No pudo Grabarse");

                    // Recarga el DataGridView y actualiza los botones
                    LoadDgvInventarioRespuesto();
                    btnGrabar.Enabled = false;
                    btnNuevo.Enabled = true;
                    is_nuevo = false;
                }
                else
                {
                    // Si es una actualización, asigna los valores de los controles a las propiedades del objeto de negocio
                    obj_cn_inventario_repuesto.Id = Convert.ToInt16(txtId.Text);
                    obj_cn_inventario_repuesto.Nombre_repuesto = txtNombreRepuesto.Text;
                    obj_cn_inventario_repuesto.Precio = Convert.ToSingle(txtPrecioRepuesto.Text);

                    // Intenta actualizar el registro
                    if (obj_cn_inventario_repuesto.ActualizarInventarioRepuesto(obj_cn_inventario_repuesto))
                    {
                        MessageBox.Show("Registro Actualizado con Exito");
                        LoadDgvInventarioRespuesto();
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
        /// Carga la lista de repuestos en el DataGridView.
        /// </summary>
        private void LoadDgvInventarioRespuesto()
        {
            try
            {
                dgvInventarioRepuestos.DataSource = obj_cn_inventario_repuesto.getListadoInventarioRepuesto();
                dgvInventarioRepuestos.AllowUserToAddRows = false;
                for (int i = 0; i < dgvInventarioRepuestos.ColumnCount; i++)
                {
                    dgvInventarioRepuestos.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception ex)
            {
                throw new AccesoException(ex.Message);
            }
        }

        /// <summary>
        /// Maneja el evento Click de una celda en el DataGridView.
        /// Muestra los detalles del registro seleccionado en los controles del formulario.
        /// </summary>
        private void dgvInventarioRepuestos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var fila = e.RowIndex;
            if (fila >= 0)
            {
                txtId.Text = dgvInventarioRepuestos.Rows[fila].Cells["ID"].Value.ToString();
                txtNombreRepuesto.Text = dgvInventarioRepuestos.Rows[fila].Cells["NOMBRE_REPUESTO"].Value.ToString();
                txtPrecioRepuesto.Text = dgvInventarioRepuestos.Rows[fila].Cells["PRECIO"].Value.ToString();

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
                obj_cn_inventario_repuesto.Id = Convert.ToInt16(txtId.Text);
                if (obj_cn_inventario_repuesto.EliminarInventarioRepuesto(obj_cn_inventario_repuesto))
                {
                    MessageBox.Show("Registro Eliminado con Exito");
                    LoadDgvInventarioRespuesto();
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
    }
}
