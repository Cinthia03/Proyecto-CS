using CapaException;
using CapaNegocio.LN_Entidades;
using ProgramacionCapas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    /// Clase que representa el formulario de mantenimiento en la capa de presentación.

    public partial class frmMantenimiento : Form
    {
        // Instancias de las clases de la capa de negocio para gestionar el mantenimiento
        private CN_Mantenimiento obj_cn_mantenimiento = new CN_Mantenimiento();
        CN_Cliente obj_cn_cliente_vehiculo = new CN_Cliente();
        CN_Mecanico obj_cn_mecanico = new CN_Mecanico();
        CN_ServiciosAdicionales obj_cn_servicios_adicionales = new CN_ServiciosAdicionales();

        // Bandera para indicar si se está agregando un nuevo registro
        private bool is_nuevo = false;
        // Variable para almacenar el total del mantenimiento
        float totalMantenimiento = 0;

        /// <summary>
        /// Constructor de la clase `frmMantenimiento`.
        /// Inicializa los componentes del formulario.
        /// </summary>
        public frmMantenimiento()
        {
            InitializeComponent();
            // Configurar ComboBox como de solo lectura
            cmbMecanico.DropDownStyle = ComboBoxStyle.DropDownList;
            // Inicializar instancia de la clase de manejo de mantenimiento
            obj_cn_mantenimiento = new CN_Mantenimiento();   
            // Cargar los DataGridView de mantenimiento y mecánico
            LoadDgvMantenimiento();
            LoadDgvMecanico();
        }

        /// <summary>
        /// Método para restablecer los controles del formulario a sus valores predeterminados.
        /// </summary>
        private void setearControles()
        {
            // Limpiar todos los campos de entrada y selección en el formulario
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtVehiculo.Text = string.Empty;
            txtKilometraje.Text = string.Empty;
            txtPlaca.Text = string.Empty;
            cmbMecanico.Text = string.Empty;
            rtbTrabajos.Text = string.Empty;
            rtbServicios.Text = string.Empty;
            txtTotalServicios.Text = string.Empty;
            txtTotalPreventivo.Text = string.Empty;
            txtTotalCorrectivo.Text = string.Empty;
            rtbRepuestos.Text = string.Empty;
            txtSubtotal.Text = string.Empty;
            txtTotal.Text = string.Empty;
        }

        /// <summary>
        /// Maneja el evento Click del botón "Nuevo".
        /// Prepara el formulario para agregar un nuevo registro de mantenimiento.
        /// </summary>
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Restablecer los controles del formulario
            setearControles();
            
            // Habilitar la bandera para indicar que se está agregando un nuevo registro
            is_nuevo = true;

            // Habilitar el botón de grabar y deshabilitar los botones de eliminar y nuevo
            btnGrabar.Enabled = true;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            txtId.Text = dgvMantenimiento.RowCount + 1 + "";
        }

        /// <summary>
        /// Maneja el evento Click del botón "Grabar".
        /// Guarda o actualiza un registro de mantenimiento según corresponda.
        /// </summary>
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (is_nuevo)
                {
                    // Si se está agregando un nuevo registro
                    // Asignar los valores de los controles del formulario al objeto de mantenimiento
                    obj_cn_mantenimiento.Fecha = dateTimePicker1.Value;
                    obj_cn_mantenimiento.NombreCliente = txtNombre.Text;
                    obj_cn_mantenimiento.Nombre_vehiculo = txtVehiculo.Text;
                    obj_cn_mantenimiento.Kilometraje_vehiculo = txtKilometraje.Text;
                    obj_cn_mantenimiento.Placa_vehiculo = txtPlaca.Text;
                    obj_cn_mantenimiento.NombreMecanico = cmbMecanico.Text;
                    obj_cn_mantenimiento.Trabajos = rtbTrabajos.Text;
                    obj_cn_mantenimiento.NombreServicios = rtbServicios.Text;
                    obj_cn_mantenimiento.TotalServicios = Convert.ToSingle(txtTotalServicios.Text);

                    // Determinar el tipo de mantenimiento y asignar el total correspondiente
                    //Si se selecciona Mantenimiento correctivo
                    if (rbCorrectivo.Checked)
                    {
                        obj_cn_mantenimiento.TipoMantenimiento = rbCorrectivo.Text;
                        obj_cn_mantenimiento.TotalMantenimiento = Convert.ToSingle(txtTotalCorrectivo.Text);
                        obj_cn_mantenimiento.Repuesto = rtbRepuestos.Text;
                    }//Si se seleciona Mantenimiuento Preventivo
                    else if (rbPreventivo.Checked)
                    {
                        obj_cn_mantenimiento.TipoMantenimiento = rbPreventivo.Text;
                        obj_cn_mantenimiento.TotalMantenimiento = Convert.ToSingle(txtTotalPreventivo.Text);
                    }

                    // Asignar el subtotal y el total a pagar
                    obj_cn_mantenimiento.Subtotal = Convert.ToSingle(txtSubtotal.Text);
                    obj_cn_mantenimiento.TotalPagar = Convert.ToSingle(txtTotal.Text);

                    // Guardar el registro de mantenimiento
                    if (obj_cn_mantenimiento.GuardarMantenimiento())

                        MessageBox.Show("Registro Guardado");
                    else
                        throw new AccesoException("Registro No pudo Grabarse");

                    // Recargar el DataGridView de mantenimiento y restablecer los controles del formulario
                    LoadDgvMantenimiento();
                    setearControles();
                    btnGrabar.Enabled = false;
                    btnNuevo.Enabled = true;
                    is_nuevo = false;

                }
                else
                {
                    // Si se está actualizando un registro existente
                    // Asignar los valores de los controles del formulario al objeto de mantenimiento
                    obj_cn_mantenimiento.Id = Convert.ToInt16(txtId.Text);
                    obj_cn_mantenimiento.Fecha = dateTimePicker1.Value;
                    obj_cn_mantenimiento.NombreCliente = txtNombre.Text;
                    obj_cn_mantenimiento.Nombre_vehiculo = txtVehiculo.Text;
                    obj_cn_mantenimiento.Kilometraje_vehiculo = txtKilometraje.Text;
                    obj_cn_mantenimiento.Placa_vehiculo = txtPlaca.Text;
                    obj_cn_mantenimiento.NombreMecanico = cmbMecanico.Text;
                    obj_cn_mantenimiento.Trabajos = rtbTrabajos.Text;
                    obj_cn_mantenimiento.NombreServicios = rtbServicios.Text;
                    obj_cn_mantenimiento.TotalServicios = Convert.ToSingle(txtTotalServicios.Text);

                    // Determinar el tipo de mantenimiento y asignar el total correspondiente
                    //Si se selecciona Mantenimiento correctivo
                    if (rbCorrectivo.Checked)
                    {
                        obj_cn_mantenimiento.TipoMantenimiento = rbCorrectivo.Text;
                        obj_cn_mantenimiento.TotalMantenimiento = Convert.ToSingle(txtTotalCorrectivo.Text);
                        obj_cn_mantenimiento.Repuesto = rtbRepuestos.Text;
                    }//Si se seleciona Mantenimiuento Preventivo
                    else if (rbPreventivo.Checked)
                    {
                        obj_cn_mantenimiento.TipoMantenimiento = rbPreventivo.Text;
                        obj_cn_mantenimiento.TotalMantenimiento = Convert.ToSingle(txtTotalPreventivo.Text);
                    }

                    // Asignar el subtotal y el total a pagar
                    obj_cn_mantenimiento.Subtotal = Convert.ToSingle(txtSubtotal.Text);
                    obj_cn_mantenimiento.TotalPagar = Convert.ToSingle(txtTotal.Text);

                    // Actualizar el registro de mantenimiento
                    if (obj_cn_mantenimiento.ActualizarMantenimiento())
                    {
                        MessageBox.Show("Registro Actualizado con Exito");
                        LoadDgvMantenimiento();
                    }
                    else
                        throw new AccesoException("Registro no pudo Actualizarce!");

                    // Deshabilitar los botones de grabar y eliminar, y habilitar el botón de nuevo
                    btnGrabar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnNuevo.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si ocurre una excepción
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Carga los datos de mantenimiento en el DataGridView.
        /// </summary>
        private void LoadDgvMantenimiento()
        {
            try
            {
                dgvMantenimiento.DataSource = obj_cn_mantenimiento.getListadoMantenimiento();
                dgvMantenimiento.AllowUserToAddRows = false;
                for (int i = 0; i < dgvMantenimiento.ColumnCount; i++)
                {
                    dgvMantenimiento.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si ocurre una excepción al cargar los datos
                MessageBox.Show(ex.Message);
            }
            dgvMantenimiento.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        /// <summary>
        /// Maneja el evento CellClick del DataGridView de mantenimiento.
        /// Carga los datos de la fila seleccionada en los controles del formulario.
        /// </summary>
        private void dgvMantenimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var fila = e.RowIndex;
            if (fila >= 0)// Se cambió de ">" a ">=" para incluir la primera fila
            {
                // Cargar los valores de las celdas de la fila seleccionada en los controles del formulario
                txtId.Text = dgvMantenimiento.Rows[fila].Cells["ID"].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(dgvMantenimiento.Rows[fila].Cells["FECHA"].Value.ToString());
                txtNombre.Text = dgvMantenimiento.Rows[fila].Cells["NOMBRE_CLIENTE"].Value.ToString();
                txtVehiculo.Text = dgvMantenimiento.Rows[fila].Cells["NOMBRE_VEHICULO"].Value.ToString();
                txtKilometraje.Text = dgvMantenimiento.Rows[fila].Cells["KILOMETRAJE_VEHICULO"].Value.ToString();
                txtPlaca.Text = dgvMantenimiento.Rows[fila].Cells["PLACA_VEHICULO"].Value.ToString();
                cmbMecanico.Text = dgvMantenimiento.Rows[fila].Cells["NOMBRE_MECANICO"].Value.ToString();
                rtbTrabajos.Text = dgvMantenimiento.Rows[fila].Cells["TRABAJOS"].Value.ToString();

                // Obtener el tipo de mantenimiento y el total de servicios desde el DataGridView
                string tipoMantenimiento = dgvMantenimiento.Rows[fila].Cells["TIPO_MANTENIMIENTO"].Value.ToString();
                // Asignar el tipo de mantenimiento al RadioButton correspondiente
                if (tipoMantenimiento == "Correctivo")
                {
                    rbCorrectivo.Checked = true;
                    lbTotalTipoPre.Visible = false;
                    txtTotalPreventivo.Visible = false;
                    lbTotalTipoCorr.Visible = true;
                    txtTotalCorrectivo.Visible = true;
                    rtbRepuestos.Visible = true;
                    txtTotalCorrectivo.Text = dgvMantenimiento.Rows[fila].Cells["TOTAL_MANTENIMIENTO"].Value.ToString();
                }
                else if (tipoMantenimiento == "Preventivo")
                {
                    rbPreventivo.Checked = true;
                    lbTotalTipoCorr.Visible = false;
                    txtTotalCorrectivo.Visible = false;
                    rtbRepuestos.Visible = false;
                    lbTotalTipoPre.Visible = true;
                    txtTotalPreventivo.Visible = true;
                    txtTotalPreventivo.Text = dgvMantenimiento.Rows[fila].Cells["TOTAL_MANTENIMIENTO"].Value.ToString();
                }
                rtbRepuestos.Text = dgvMantenimiento.Rows[fila].Cells["REPUESTO"].Value.ToString();
                rtbServicios.Text = dgvMantenimiento.Rows[fila].Cells["NOMBRE_SERVICIOS"].Value.ToString();
                txtTotalServicios.Text = dgvMantenimiento.Rows[fila].Cells["TOTAL_SERVICIOS"].Value.ToString();
                txtSubtotal.Text = dgvMantenimiento.Rows[fila].Cells["SUBTOTAL_FACTURA"].Value.ToString();
                txtTotal.Text = dgvMantenimiento.Rows[fila].Cells["TOTAL_FACTURA"].Value.ToString();

                // Configurar los botones de acuerdo al estado de edición
                btnNuevo.Enabled = true;
                btnGrabar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón de eliminar.
        /// Intenta eliminar el registro seleccionado y actualiza el DataGridView.
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Asigna el ID del registro a eliminar desde el campo de texto
                obj_cn_mantenimiento.Id = Convert.ToInt16(txtId.Text);

                // Intenta eliminar el registro y muestra un mensaje según el resultado
                if (obj_cn_mantenimiento.EliminarMantenimiento())
                {
                    MessageBox.Show("Registro Eliminado con Exito");
                    LoadDgvMantenimiento();
                }
                else
                    throw new AccesoException("No se pudo eliminar el Registro!");

                // Deshabilita los botones correspondientes después de la operación
                btnGrabar.Enabled = false;
                btnEliminar.Enabled = false;
                btnNuevo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Carga la lista de mecánicos en el ComboBox.
        /// </summary>
        private void LoadDgvMecanico()
        {
            try
            {
                // Obtiene la lista de mecánicos y la asigna como origen de datos al ComboBox
                DataTable dtMecanico = obj_cn_mecanico.getListadoMecanico();
                cmbMecanico.DataSource = dtMecanico;
                cmbMecanico.DisplayMember = "nombre";
            }
            catch (Exception ex)
            {
                throw new AccesoException("Error al cargar Mecanico: " + ex.Message);
            }

        }



        //BUSCAR VEHICULO Y SUS CLIENTES
        /// <summary>
        /// Evento que se dispara al hacer clic en el botón de buscar clientes.
        /// Abre el formulario de clientes y actualiza los campos correspondientes en el formulario principal.
        /// </summary>
        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes = new frmClientes();
            if (frmClientes.ShowDialog() == DialogResult.OK)
            {
                txtNombre.Text = frmClientes.ObtenerNombre();
                txtVehiculo.Text = frmClientes.ObtenerVehiculo();
                txtKilometraje.Text = frmClientes.ObtenerKilometraje();
                txtPlaca.Text = frmClientes.ObtenerPlaca();
            }
        }


        //SERVICIOS ALMACENADOS
        /// <summary>
        /// Evento que se dispara al hacer clic en el botón de buscar servicios adicionales.
        /// Abre el formulario de servicios adicionales y actualiza los campos correspondientes en el formulario principal.
        /// </summary>
        private void btnServiciosAdicionales_Click(object sender, EventArgs e)
        {
            frmServicio frmS = new frmServicio();
            if (frmS.ShowDialog() == DialogResult.OK)
            {
                rtbServicios.Text = "";
                txtTotalServicios.Text = frmS.ObtenerSeleccionesTotal();
                int getRows = frmS.getCountRows();
                for (int i = 0; i < getRows - 1; i++)
                {
                    rtbServicios.AppendText(frmS.ObtenerSeleccionServicios(i) + ", ");
                }
                rtbServicios.AppendText(frmS.ObtenerSeleccionServicios(getRows - 1) + ".");
            }
        }


        //TIPO DE MANTENIMIENTO
        /// <summary>
        /// Evento que se dispara cuando cambia la selección del tipo de mantenimiento (correctivo o preventivo).
        /// Actualiza la visibilidad de los campos correspondientes según el tipo seleccionado.
        /// </summary>
        private void TipoMantenimiento_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton.Checked)
            {
                if (radioButton == rbCorrectivo)
                {
                    // Muestra el campo para el total del mantenimiento correctivo y oculta el campo para el preventivo
                    lbTotalTipoCorr.Visible = true;
                    txtTotalCorrectivo.Visible = true;
                    rtbRepuestos.Visible = true;
                    lbTotalTipoPre.Visible = false;
                    txtTotalPreventivo.Visible = false;                   
                    txtTotalPreventivo.Text = string.Empty;
                    txtTotalCorrectivo.Text = string.Empty;
                    rtbRepuestos.Text = string.Empty;
                }
                else if (radioButton == rbPreventivo)
                {
                    // Muestra el campo para el total del mantenimiento preventivo y oculta el campo para el correctivo                   
                    txtTotalPreventivo.Visible = true;
                    lbTotalTipoPre.Visible = true;
                    lbTotalTipoCorr.Visible = false;
                    txtTotalCorrectivo.Visible = false;
                    rtbRepuestos.Visible = false;
                    txtTotalPreventivo.Text = string.Empty;
                    txtTotalCorrectivo.Text = string.Empty;
                    rtbRepuestos.Text = string.Empty;
                }
            }
        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón de seleccionar repuestos para el mantenimiento correctivo.
        /// Abre el formulario de repuestos y actualiza el campo correspondiente en el formulario principal.
        /// </summary>
        private void rbCorrectivo_Click(object sender, EventArgs e)
        {
            frmRepuestos frmRepuestos = new frmRepuestos();
            lbTotalTipoCorr.Visible = true;
            txtTotalCorrectivo.Visible = true;
            rtbRepuestos.Visible = true;
            lbTotalTipoPre.Visible = false;
            txtTotalPreventivo.Visible = false;
            if (frmRepuestos.ShowDialog() == DialogResult.OK)
            {
                rtbRepuestos.Text = "";
                // Asigna el total de repuestos seleccionados desde el formulario de repuestos
                txtTotalCorrectivo.Text = frmRepuestos.ObtenerSeleccionesTotal();
                int getRows = frmRepuestos.getCountRows();
                for (int i = 0; i < getRows - 1; i++)
                {
                    rtbRepuestos.AppendText(frmRepuestos.ObtenerSeleccionRepuestos(i) + ", ");
                }
                rtbRepuestos.AppendText(frmRepuestos.ObtenerSeleccionRepuestos(getRows - 1) + ".");
            }
        }

        /// <summary>
        /// Maneja la vision de las herramientas
        /// Si es preventivo ciertas herramientas desapareceran
        /// </summary>
        private void rbPreventivo_Click(object sender, EventArgs e)
        {
            txtTotalPreventivo.Visible = true;
            lbTotalTipoPre.Visible = true;
            lbTotalTipoCorr.Visible = false;
            txtTotalCorrectivo.Visible = false;
            rtbRepuestos.Visible = false;
        }

        //Calcular subtotal y total a pagar creo que lo puedes hacer de una mejor forma 
        private void CalcularSubtotalYTotal()
        {
            if (rbCorrectivo.Checked)
            {
                // Calcula el total del mantenimiento correctivo sumando el total de repuestos y servicios adicionales
                //if (float.TryParse(txtTotalCorrectivo.Text, out float totalCorrectivo))
                if (float.TryParse(txtTotalCorrectivo.Text, out float totalCorrectivo))
                {
                    totalMantenimiento = totalCorrectivo + Convert.ToSingle(txtTotalServicios.Text);
                }
            }
            else if (rbPreventivo.Checked)
            {

                // Tomar el valor de txtTotalPreventivo como parte del total de Preventivo
                if (float.TryParse(txtTotalPreventivo.Text, out float totalPreventivo))
                {
                    totalMantenimiento = totalPreventivo + Convert.ToSingle(txtTotalServicios.Text);
                }
            }

            // Calcular IVA y totales
            float iva = Convert.ToSingle(totalMantenimiento * 0.12);
            float subtotal = totalMantenimiento;
            float total = subtotal + iva;

            // Mostrar resultados
            txtSubtotal.Text = subtotal.ToString("F2");
            txtTotal.Text = total.ToString("F2");
        }

        /// <summary>
        /// Carga los datos de mantenimiento en el DataGridView al cargar el formulario.
        /// </summary>
        private void frmMantenimiento_Load(object sender, EventArgs e)
        {
            LoadDgvMantenimiento();

        }

        /// <summary>
        /// Evento que se dispara al hacer clic en el botón de calcular.
        /// Calcula el subtotal y total a pagar del mantenimiento.
        /// </summary>
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularSubtotalYTotal();
        }


        //MOSTRAR DATOS
        /// <summary>
        /// Muestra los detalles del mantenimiento seleccionado en un mensaje emergente.
        /// </summary>
        private void MostrarDatos()
        {
            DataGridViewRow fila = dgvMantenimiento.CurrentRow;

            if (fila != null)
            {
                // Obtener los valores de las celdas de la fila seleccionada o establecer "N/A" si son nulos
                string id = fila.Cells["ID"].Value?.ToString() ?? "N/A";
                string fecha = fila.Cells["FECHA"].Value?.ToString() ?? "N/A";
                string cliente = fila.Cells["NOMBRE_CLIENTE"].Value?.ToString() ?? "N/A";
                string vehiculo = fila.Cells["NOMBRE_VEHICULO"].Value?.ToString() ?? "N/A";
                string kilometraje = fila.Cells["KILOMETRAJE_VEHICULO"].Value?.ToString() ?? "N/A";
                string placa = fila.Cells["PLACA_VEHICULO"].Value?.ToString() ?? "N/A";
                string mecanico = fila.Cells["NOMBRE_MECANICO"].Value?.ToString() ?? "N/A";
                string trabajos = fila.Cells["TRABAJOS"].Value?.ToString() ?? "N/A";
                string tipoMantenimiento = fila.Cells["TIPO_MANTENIMIENTO"].Value?.ToString() ?? "N/A";
                string repuestos = fila.Cells["REPUESTO"].Value?.ToString() ?? "N/A";
                string totalMantenimiento = fila.Cells["TOTAL_MANTENIMIENTO"].Value?.ToString() ?? "N/A";
                string servicios = fila.Cells["NOMBRE_SERVICIOS"].Value?.ToString() ?? "N/A";
                string totalServicios = fila.Cells["TOTAL_SERVICIOS"].Value?.ToString() ?? "N/A";
                string subtotal = fila.Cells["SUBTOTAL_FACTURA"].Value?.ToString() ?? "N/A";
                string total = fila.Cells["TOTAL_FACTURA"].Value?.ToString() ?? "N/A";

                // Construir el mensaje con los datos específicos
                string mensaje = $"Id de la factura: {id}" +
                    $"\nFecha de la factura: {fecha}" +
                    $"\nNombre del cliente: {cliente}" +
                    $"\nNombre del vehiculo: {vehiculo}" +
                    $"\nKilometraje del vehiculo: {kilometraje}" +
                    $"\nPlaca del vehiculo: {placa}" +
                    $"\nNombre del mecanico: {mecanico}" +
                    $"\nTrabajos realizados: {trabajos}" +
                    $"\nTipo de mantenimiento: {tipoMantenimiento}" +
                    $"\nRepuestos: {repuestos}" +
                    $"\nTotal de mantenimiento: {totalMantenimiento}" +
                    $"\nServicios Adicionales: {servicios}" +
                    $"\nTotal servicios adicionales: {totalServicios}" +                   
                    $"\nSubtotal: {subtotal}" +
                    $"\nTotal a pagar: {total}";

                // Mostrar el mensaje emergente con los detalles del mantenimiento
                MessageBox.Show(mensaje, "Datos a mostrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay fila seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Maneja el evento de doble clic en el DataGridView de mantenimiento para mostrar los detalles del mantenimiento.
        /// </summary>
        private void dgvMantenimiento_DoubleClick(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        
    }
}

