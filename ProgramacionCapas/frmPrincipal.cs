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
    // Clase principal del formulario

    public partial class frmPrincipal : Form
    {
        /// <summary>
        /// Constructor de la clase `frmPrincipal`.
        /// Inicializa los componentes del formulario.
        /// </summary>
        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Maneja el evento Click del menú "Cliente".
        /// Abre el formulario de gestión de clientes.
        /// </summary>
        private void clienteYVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionCliente frmCliente_Vehiculo = new frmGestionCliente();
            frmCliente_Vehiculo.Show();
        }

        /// <summary>
        /// Maneja el evento Click del menú "Vehiculos".
        /// Abre el formulario de gestión de vehiculos.
        /// </summary>
        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionVehiculos frmGestionVehiculos = new frmGestionVehiculos();
            frmGestionVehiculos.Show();
        }

        /// <summary>
        /// Maneja el evento Click del menú "Mecánicos".
        /// Abre el formulario de gestión de mecánicos.
        /// </summary>
        private void mecanicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionMecanico frmMecanico = new frmGestionMecanico();
            frmMecanico.Show();
        }

        /// <summary>
        /// Maneja el evento Click del menú "Repuestos".
        /// Abre el formulario de gestión de inventario de repuestos.
        /// </summary>
        private void repuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionRepuestos frmRegistroRepuesto = new frmGestionRepuestos();
            frmRegistroRepuesto.Show();
        }

        /// <summary>
        /// Maneja el evento Click del menú "Servicios Adicionales".
        /// Abre el formulario de gestión de servicios adicionales.
        /// </summary>
        private void serviciosAdicionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGestionServicio frmRegistroServicio = new frmGestionServicio();
            frmRegistroServicio.Show();
        }

        /// <summary>
        /// Maneja el evento Click del menú "Registro".
        /// Abre el formulario de mantenimiento.
        /// </summary>
        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimiento frmMantenimiento = new frmMantenimiento();
            frmMantenimiento.Show();
        }

        
    }
}
