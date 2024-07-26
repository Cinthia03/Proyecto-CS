namespace CapaPresentacion
{
    partial class frmGestionCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbClientes = new GroupBox();
            txtEdad = new TextBox();
            label1 = new Label();
            txtCorreos = new TextBox();
            label7 = new Label();
            txtId = new TextBox();
            txtCelular = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtCedula = new TextBox();
            label5 = new Label();
            txtNombre = new TextBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            btnEliminar = new Button();
            btnNuevo = new Button();
            btnGrabar = new Button();
            dgvClienteVehiculo = new DataGridView();
            txtContactoEmergencia = new TextBox();
            label4 = new Label();
            gbClientes.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClienteVehiculo).BeginInit();
            SuspendLayout();
            // 
            // gbClientes
            // 
            gbClientes.Controls.Add(txtContactoEmergencia);
            gbClientes.Controls.Add(label4);
            gbClientes.Controls.Add(txtEdad);
            gbClientes.Controls.Add(label1);
            gbClientes.Controls.Add(txtCorreos);
            gbClientes.Controls.Add(label7);
            gbClientes.Controls.Add(txtId);
            gbClientes.Controls.Add(txtCelular);
            gbClientes.Controls.Add(label2);
            gbClientes.Controls.Add(label3);
            gbClientes.Controls.Add(txtCedula);
            gbClientes.Controls.Add(label5);
            gbClientes.Controls.Add(txtNombre);
            gbClientes.Controls.Add(label6);
            gbClientes.Location = new Point(17, 15);
            gbClientes.Name = "gbClientes";
            gbClientes.Size = new Size(652, 232);
            gbClientes.TabIndex = 0;
            gbClientes.TabStop = false;
            gbClientes.Text = "Datos del cliente";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(174, 107);
            txtEdad.Margin = new Padding(4, 3, 4, 3);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(140, 23);
            txtEdad.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 110);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 44;
            label1.Text = "Edad: ";
            // 
            // txtCorreos
            // 
            txtCorreos.Location = new Point(174, 165);
            txtCorreos.Margin = new Padding(4, 3, 4, 3);
            txtCorreos.Name = "txtCorreos";
            txtCorreos.Size = new Size(208, 23);
            txtCorreos.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 168);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 41;
            label7.Text = "Corrreo: ";
            // 
            // txtId
            // 
            txtId.Location = new Point(174, 21);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(77, 23);
            txtId.TabIndex = 40;
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(174, 136);
            txtCelular.Margin = new Padding(4, 3, 4, 3);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(140, 23);
            txtCelular.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 24);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 39;
            label2.Text = "Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 139);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 37;
            label3.Text = "Celular: ";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(174, 77);
            txtCedula.Margin = new Padding(4, 3, 4, 3);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(140, 23);
            txtCedula.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 80);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 33;
            label5.Text = "Cedula: ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(174, 49);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(310, 23);
            txtNombre.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 52);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(113, 15);
            label6.TabIndex = 31;
            label6.Text = "Nombre Completo: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(btnGrabar);
            groupBox1.Location = new Point(675, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(113, 178);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(16, 114);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(92, 23);
            btnEliminar.TabIndex = 30;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(16, 27);
            btnNuevo.Margin = new Padding(2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(92, 23);
            btnNuevo.TabIndex = 28;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Enabled = false;
            btnGrabar.Location = new Point(16, 69);
            btnGrabar.Margin = new Padding(2);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(92, 23);
            btnGrabar.TabIndex = 29;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // dgvClienteVehiculo
            // 
            dgvClienteVehiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClienteVehiculo.Location = new Point(17, 253);
            dgvClienteVehiculo.Name = "dgvClienteVehiculo";
            dgvClienteVehiculo.RowTemplate.Height = 25;
            dgvClienteVehiculo.Size = new Size(771, 192);
            dgvClienteVehiculo.TabIndex = 2;
            dgvClienteVehiculo.CellClick += dgvClienteVehiculo_CellClick;
            // 
            // txtContactoEmergencia
            // 
            txtContactoEmergencia.Location = new Point(174, 194);
            txtContactoEmergencia.Margin = new Padding(4, 3, 4, 3);
            txtContactoEmergencia.Name = "txtContactoEmergencia";
            txtContactoEmergencia.Size = new Size(141, 23);
            txtContactoEmergencia.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 197);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(127, 15);
            label4.TabIndex = 46;
            label4.Text = "Contacto Emergencia: ";
            // 
            // frmGestionCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 459);
            Controls.Add(dgvClienteVehiculo);
            Controls.Add(groupBox1);
            Controls.Add(gbClientes);
            Name = "frmGestionCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCliente_Vehiculo";
            Load += frmCliente_Vehiculo_Load;
            gbClientes.ResumeLayout(false);
            gbClientes.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClienteVehiculo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbClientes;
        private GroupBox groupBox1;
        private Button btnEliminar;
        private Button btnGrabar;
        private Button btnNuevo;
        private TextBox txtId;
        private TextBox txtCelular;
        private Label label2;
        private Label label3;
        private TextBox txtCedula;
        private Label label5;
        private TextBox txtNombre;
        private Label label6;
        private TextBox txtCorreos;
        private Label label7;
        private DataGridView dgvClienteVehiculo;
        private TextBox txtEdad;
        private Label label1;
        private TextBox txtContactoEmergencia;
        private Label label4;
    }
}