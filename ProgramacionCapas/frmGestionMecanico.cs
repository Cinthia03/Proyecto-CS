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
    // Clase que representa el formulario de gestión de mecánicos
    public partial class frmGestionMecanico : Form
    {
        // Objeto para acceder a la lógica de negocio de mecánicos
        CN_Mecanico obj_cn_mecanico = new CN_Mecanico();
        
        // Variable para indicar si se está creando un nuevo registro
        private bool is_nuevo = false;
        private int nextId;

        /// <summary>
        /// Constructor de la clase `frmGestionMecanico`.
        /// Inicializa los componentes del formulario.
        /// </summary>
        public frmGestionMecanico()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Maneja el evento Load del formulario.
        /// Carga los datos en el DataGridView.
        /// </summary>
        private void frmMecanico_Load(object sender, EventArgs e)
        {
            LoadDgvMecanico();
        }

        /// <summary>
        /// Establece los controles del formulario a sus valores predeterminados.
        /// </summary>
        private void setearControles()
        {
            if (dgvMecanico.RowCount > 0)
                nextId = int.Parse(dgvMecanico.Rows[dgvMecanico.RowCount - 1].Cells["ID"].Value.ToString()) + 1;
            else
                nextId = 1;
            txtId.Text = nextId.ToString();
            txtNombre.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtCorreo.Text = string.Empty;
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
                    obj_cn_mecanico.Nombre = txtNombre.Text;
                    obj_cn_mecanico.Cedula = txtCedula.Text;
                    obj_cn_mecanico.Celular = txtCelular.Text;
                    obj_cn_mecanico.Correo = txtCorreo.Text;

                    // Intenta guardar el nuevo registro
                    if (obj_cn_mecanico.GuardarMecanico(obj_cn_mecanico))
                        MessageBox.Show("Registro Guardado");
                    else
                        throw new AccesoException("Registro No pudo Grabarse");

                    // Recarga el DataGridView y actualiza los botones
                    LoadDgvMecanico();
                    btnGrabar.Enabled = false;
                    btnNuevo.Enabled = true;
                    is_nuevo = false;
                }
                else
                {
                    // Si es una actualización, asigna los valores de los controles a las propiedades del objeto de negocio
                    obj_cn_mecanico.Id = Convert.ToInt16(txtId.Text);
                    obj_cn_mecanico.Nombre = txtNombre.Text;
                    obj_cn_mecanico.Cedula = txtCedula.Text;
                    obj_cn_mecanico.Celular = txtCelular.Text;
                    obj_cn_mecanico.Correo = txtCorreo.Text;

                    // Intenta actualizar el registro
                    if (obj_cn_mecanico.ActualizarMecanico(obj_cn_mecanico))
                    {
                        MessageBox.Show("Registro Actualizado con Exito");
                        LoadDgvMecanico();
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
        /// Carga la lista de mecánicos en el DataGridView.
        /// </summary>
        private void LoadDgvMecanico()
        {
            try
            {
                dgvMecanico.DataSource = obj_cn_mecanico.getListadoMecanico();
                dgvMecanico.AllowUserToAddRows = false;
                for (int i = 0; i < dgvMecanico.ColumnCount; i++)
                {
                    dgvMecanico.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvMecanico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMecanico.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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

                txtId.Text = dgvMecanico.Rows[fila].Cells["ID"].Value.ToString();
                txtNombre.Text = dgvMecanico.Rows[fila].Cells["NOMBRE"].Value.ToString();
                txtCedula.Text = dgvMecanico.Rows[fila].Cells["CEDULA"].Value.ToString();
                txtCelular.Text = dgvMecanico.Rows[fila].Cells["CELULAR"].Value.ToString();
                txtCorreo.Text = dgvMecanico.Rows[fila].Cells["CORREO"].Value.ToString();

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
                obj_cn_mecanico.Id = Convert.ToInt16(txtId.Text);
                if (obj_cn_mecanico.EliminarMecanico(obj_cn_mecanico))
                {
                    MessageBox.Show("Registro Eliminado con Exito");
                    LoadDgvMecanico();
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
