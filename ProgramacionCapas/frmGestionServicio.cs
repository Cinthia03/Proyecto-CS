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
    // Clase que representa el formulario de gestión de servicios adicionales
    public partial class frmGestionServicio : Form
    {
        // Objeto para acceder a la lógica de negocio de servicios adicionales
        CN_ServiciosAdicionales obj_cn_servicios_adicionales = new CN_ServiciosAdicionales();
        
        // Variable para indicar si se está creando un nuevo registro
        private bool is_nuevo = false;
        private int nextId;

        /// <summary>
        /// Constructor de la clase `frmGestionServicio`.
        /// Inicializa los componentes del formulario.
        /// </summary>
        public frmGestionServicio()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Maneja el evento Load del formulario.
        /// Carga los datos en el DataGridView.
        /// </summary>
        private void frmGestionServicio_Load(object sender, EventArgs e)
        {
            LoadDgvServiciosAdicionales();
        }

        /// <summary>
        /// Establece los controles del formulario a sus valores predeterminados.
        /// </summary>
        private void setearControles()
        {
            int countRows = dgvServiciosAdicionales.RowCount;
            if (countRows > 0)
                nextId = int.Parse(dgvServiciosAdicionales.Rows[countRows - 1].Cells["ID"].Value.ToString())+1;
            else
                nextId = 1;
            txtId.Text = nextId.ToString();
            txtNombreServicio.Text = string.Empty;
            txtPrecioServicio.Text = string.Empty;
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
                    obj_cn_servicios_adicionales.Nombre = txtNombreServicio.Text;
                    obj_cn_servicios_adicionales.Precio = Convert.ToSingle(txtPrecioServicio.Text);

                    // Intenta guardar el nuevo registro
                    if (obj_cn_servicios_adicionales.GuardarServiciosAdicionales(obj_cn_servicios_adicionales))
                        MessageBox.Show("Registro Guardado");
                    else
                        throw new AccesoException("Registro no pudo ser Guardar.");
                    

                    // Recarga el DataGridView y actualiza los botones
                    LoadDgvServiciosAdicionales();
                    btnGrabar.Enabled = false;
                    btnNuevo.Enabled = true;
                    is_nuevo = false;
                }
                else
                {
                    // Si es una actualización, asigna los valores de los controles a las propiedades del objeto de negocio
                    obj_cn_servicios_adicionales.Id = Convert.ToInt16(txtId.Text);
                    obj_cn_servicios_adicionales.Nombre = txtNombreServicio.Text;
                    obj_cn_servicios_adicionales.Precio = Convert.ToSingle(txtPrecioServicio.Text);

                    // Intenta actualizar el registro
                    if (obj_cn_servicios_adicionales.ActualizarServiciosAdicionales(obj_cn_servicios_adicionales))
                    {
                        MessageBox.Show("Registro Actualizado con Exito");
                        LoadDgvServiciosAdicionales();
                    }
                    else
                        throw new AccesoException("Registro no pudo ser Actualizado");

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
        /// Carga la lista de servicios adicionales en el DataGridView.
        /// </summary>
        private void LoadDgvServiciosAdicionales()
        {
            try
            {
                dgvServiciosAdicionales.DataSource = obj_cn_servicios_adicionales.getListadoServiciosAdicionales();
                dgvServiciosAdicionales.AllowUserToAddRows = false;
                for (int i = 0; i < dgvServiciosAdicionales.ColumnCount; i++)
                {
                    dgvServiciosAdicionales.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
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
        private void dgvServiciosAdicionales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var fila = e.RowIndex;
            if (fila >= 0)
            {
                txtId.Text = dgvServiciosAdicionales.Rows[fila].Cells["ID"].Value.ToString();
                txtNombreServicio.Text = dgvServiciosAdicionales.Rows[fila].Cells["NOMBRE"].Value.ToString();
                txtPrecioServicio.Text = dgvServiciosAdicionales.Rows[fila].Cells["PRECIO"].Value.ToString();

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
                obj_cn_servicios_adicionales.Id = Convert.ToInt16(txtId.Text);
                if (obj_cn_servicios_adicionales.EliminarServiciosAdicionales(obj_cn_servicios_adicionales))
                {
                    MessageBox.Show("Registro Eliminado con Exito");
                    LoadDgvServiciosAdicionales();
                }
                else
                    throw new AccesoException("No se Pudo Eliminar el Registro");
                btnGrabar.Enabled = false;
                btnEliminar.Enabled = false;
                btnNuevo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
