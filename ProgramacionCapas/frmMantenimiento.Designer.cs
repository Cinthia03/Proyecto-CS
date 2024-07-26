namespace CapaPresentacion
{
    partial class frmMantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimiento));
            groupBox1 = new GroupBox();
            txtVehiculo = new TextBox();
            btnEliminar = new Button();
            btnCalcular = new Button();
            btnGrabar = new Button();
            btnNuevo = new Button();
            groupBox4 = new GroupBox();
            btnServiciosAdicionales = new Button();
            rtbServicios = new RichTextBox();
            txtTotalServicios = new TextBox();
            lbTotalServicios = new Label();
            label3 = new Label();
            txtTotal = new TextBox();
            label10 = new Label();
            btnCliente = new Button();
            txtSubtotal = new TextBox();
            txtNombre = new TextBox();
            label9 = new Label();
            gbTipoMantenimiento = new GroupBox();
            lbTotalTipoCorr = new Label();
            rbCorrectivo = new RadioButton();
            rbPreventivo = new RadioButton();
            txtTotalCorrectivo = new TextBox();
            lbTotalTipoPre = new Label();
            txtTotalPreventivo = new TextBox();
            rtbRepuestos = new RichTextBox();
            rtbTrabajos = new RichTextBox();
            cmbMecanico = new ComboBox();
            txtId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvMantenimiento = new DataGridView();
            txtKilometraje = new TextBox();
            label7 = new Label();
            txtPlaca = new TextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            gbTipoMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMantenimiento).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPlaca);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtKilometraje);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtVehiculo);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Controls.Add(btnGrabar);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(btnCliente);
            groupBox1.Controls.Add(txtSubtotal);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(gbTipoMantenimiento);
            groupBox1.Controls.Add(rtbTrabajos);
            groupBox1.Controls.Add(cmbMecanico);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1131, 437);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del mantenimiento";
            // 
            // txtVehiculo
            // 
            txtVehiculo.Location = new Point(663, 48);
            txtVehiculo.Name = "txtVehiculo";
            txtVehiculo.ReadOnly = true;
            txtVehiculo.Size = new Size(228, 23);
            txtVehiculo.TabIndex = 34;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(1010, 88);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(105, 23);
            btnEliminar.TabIndex = 30;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(785, 402);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Enabled = false;
            btnGrabar.Location = new Point(1010, 56);
            btnGrabar.Margin = new Padding(2);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(105, 23);
            btnGrabar.TabIndex = 29;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(1010, 22);
            btnNuevo.Margin = new Padding(2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(105, 23);
            btnNuevo.TabIndex = 28;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnServiciosAdicionales);
            groupBox4.Controls.Add(rtbServicios);
            groupBox4.Controls.Add(txtTotalServicios);
            groupBox4.Controls.Add(lbTotalServicios);
            groupBox4.Location = new Point(538, 251);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(322, 137);
            groupBox4.TabIndex = 33;
            groupBox4.TabStop = false;
            groupBox4.Text = "Servicios Adicionales";
            // 
            // btnServiciosAdicionales
            // 
            btnServiciosAdicionales.BackColor = SystemColors.Control;
            btnServiciosAdicionales.FlatStyle = FlatStyle.Popup;
            btnServiciosAdicionales.ForeColor = SystemColors.Control;
            btnServiciosAdicionales.Image = (Image)resources.GetObject("btnServiciosAdicionales.Image");
            btnServiciosAdicionales.Location = new Point(273, 22);
            btnServiciosAdicionales.Name = "btnServiciosAdicionales";
            btnServiciosAdicionales.Size = new Size(32, 24);
            btnServiciosAdicionales.TabIndex = 33;
            btnServiciosAdicionales.UseVisualStyleBackColor = false;
            btnServiciosAdicionales.Click += btnServiciosAdicionales_Click;
            // 
            // rtbServicios
            // 
            rtbServicios.Location = new Point(15, 22);
            rtbServicios.Name = "rtbServicios";
            rtbServicios.ReadOnly = true;
            rtbServicios.Size = new Size(241, 76);
            rtbServicios.TabIndex = 29;
            rtbServicios.Text = "";
            // 
            // txtTotalServicios
            // 
            txtTotalServicios.Location = new Point(171, 104);
            txtTotalServicios.Name = "txtTotalServicios";
            txtTotalServicios.ReadOnly = true;
            txtTotalServicios.Size = new Size(134, 23);
            txtTotalServicios.TabIndex = 19;
            // 
            // lbTotalServicios
            // 
            lbTotalServicios.AutoSize = true;
            lbTotalServicios.Location = new Point(76, 107);
            lbTotalServicios.Name = "lbTotalServicios";
            lbTotalServicios.Size = new Size(81, 15);
            lbTotalServicios.TabIndex = 18;
            lbTotalServicios.Text = "Total Servicios";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(538, 51);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 13;
            label3.Text = "Nombre vehiculo:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(244, 403);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(89, 23);
            txtTotal.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(200, 406);
            label10.Name = "label10";
            label10.Size = new Size(38, 15);
            label10.TabIndex = 24;
            label10.Text = "Total: ";
            // 
            // btnCliente
            // 
            btnCliente.BackColor = SystemColors.Control;
            btnCliente.FlatStyle = FlatStyle.Popup;
            btnCliente.ForeColor = SystemColors.Control;
            btnCliente.Image = (Image)resources.GetObject("btnCliente.Image");
            btnCliente.Location = new Point(307, 53);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(32, 24);
            btnCliente.TabIndex = 32;
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(101, 403);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.ReadOnly = true;
            txtSubtotal.Size = new Size(88, 23);
            txtSubtotal.TabIndex = 21;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(103, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(198, 23);
            txtNombre.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(38, 406);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 23;
            label9.Text = "Subtotal: ";
            // 
            // gbTipoMantenimiento
            // 
            gbTipoMantenimiento.Controls.Add(lbTotalTipoCorr);
            gbTipoMantenimiento.Controls.Add(rbCorrectivo);
            gbTipoMantenimiento.Controls.Add(rbPreventivo);
            gbTipoMantenimiento.Controls.Add(txtTotalCorrectivo);
            gbTipoMantenimiento.Controls.Add(lbTotalTipoPre);
            gbTipoMantenimiento.Controls.Add(txtTotalPreventivo);
            gbTipoMantenimiento.Controls.Add(rtbRepuestos);
            gbTipoMantenimiento.Location = new Point(29, 251);
            gbTipoMantenimiento.Name = "gbTipoMantenimiento";
            gbTipoMantenimiento.Size = new Size(413, 137);
            gbTipoMantenimiento.TabIndex = 14;
            gbTipoMantenimiento.TabStop = false;
            gbTipoMantenimiento.Text = "Tipo de mantenimiento";
            // 
            // lbTotalTipoCorr
            // 
            lbTotalTipoCorr.AutoSize = true;
            lbTotalTipoCorr.Location = new Point(298, 62);
            lbTotalTipoCorr.Name = "lbTotalTipoCorr";
            lbTotalTipoCorr.Size = new Size(70, 15);
            lbTotalTipoCorr.TabIndex = 35;
            lbTotalTipoCorr.Text = "Total Mnto: ";
            lbTotalTipoCorr.Visible = false;
            // 
            // rbCorrectivo
            // 
            rbCorrectivo.AutoSize = true;
            rbCorrectivo.Location = new Point(24, 47);
            rbCorrectivo.Name = "rbCorrectivo";
            rbCorrectivo.Size = new Size(80, 19);
            rbCorrectivo.TabIndex = 1;
            rbCorrectivo.TabStop = true;
            rbCorrectivo.Text = "Correctivo";
            rbCorrectivo.UseVisualStyleBackColor = true;
            rbCorrectivo.Click += rbCorrectivo_Click;
            // 
            // rbPreventivo
            // 
            rbPreventivo.AutoSize = true;
            rbPreventivo.Location = new Point(24, 22);
            rbPreventivo.Name = "rbPreventivo";
            rbPreventivo.Size = new Size(81, 19);
            rbPreventivo.TabIndex = 0;
            rbPreventivo.TabStop = true;
            rbPreventivo.Text = "Preventivo";
            rbPreventivo.UseVisualStyleBackColor = true;
            rbPreventivo.Click += rbPreventivo_Click;
            // 
            // txtTotalCorrectivo
            // 
            txtTotalCorrectivo.Location = new Point(298, 80);
            txtTotalCorrectivo.Name = "txtTotalCorrectivo";
            txtTotalCorrectivo.ReadOnly = true;
            txtTotalCorrectivo.Size = new Size(93, 23);
            txtTotalCorrectivo.TabIndex = 16;
            txtTotalCorrectivo.Visible = false;
            // 
            // lbTotalTipoPre
            // 
            lbTotalTipoPre.AutoSize = true;
            lbTotalTipoPre.Location = new Point(159, 24);
            lbTotalTipoPre.Name = "lbTotalTipoPre";
            lbTotalTipoPre.Size = new Size(70, 15);
            lbTotalTipoPre.TabIndex = 15;
            lbTotalTipoPre.Text = "Total Mnto: ";
            lbTotalTipoPre.Visible = false;
            // 
            // txtTotalPreventivo
            // 
            txtTotalPreventivo.Location = new Point(235, 21);
            txtTotalPreventivo.Name = "txtTotalPreventivo";
            txtTotalPreventivo.Size = new Size(93, 23);
            txtTotalPreventivo.TabIndex = 20;
            txtTotalPreventivo.Visible = false;
            // 
            // rtbRepuestos
            // 
            rtbRepuestos.Location = new Point(128, 62);
            rtbRepuestos.Name = "rtbRepuestos";
            rtbRepuestos.ReadOnly = true;
            rtbRepuestos.Size = new Size(164, 65);
            rtbRepuestos.TabIndex = 34;
            rtbRepuestos.Text = "";
            rtbRepuestos.Visible = false;
            // 
            // rtbTrabajos
            // 
            rtbTrabajos.Location = new Point(29, 150);
            rtbTrabajos.Name = "rtbTrabajos";
            rtbTrabajos.Size = new Size(894, 80);
            rtbTrabajos.TabIndex = 13;
            rtbTrabajos.Text = "";
            // 
            // cmbMecanico
            // 
            cmbMecanico.FormattingEnabled = true;
            cmbMecanico.Location = new Point(103, 85);
            cmbMecanico.Name = "cmbMecanico";
            cmbMecanico.Size = new Size(236, 23);
            cmbMecanico.TabIndex = 12;
            // 
            // txtId
            // 
            txtId.Location = new Point(103, 22);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(41, 23);
            txtId.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 132);
            label6.Name = "label6";
            label6.Size = new Size(130, 15);
            label6.TabIndex = 6;
            label6.Text = "Trabajos y diagnostico: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(538, 23);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 5;
            label5.Text = "Fecha: ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(663, 17);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(256, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 88);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 3;
            label4.Text = "Mecanico: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 56);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Cliente: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 25);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 0;
            label1.Text = "Id: ";
            // 
            // dgvMantenimiento
            // 
            dgvMantenimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMantenimiento.Location = new Point(12, 455);
            dgvMantenimiento.Name = "dgvMantenimiento";
            dgvMantenimiento.RowTemplate.Height = 25;
            dgvMantenimiento.Size = new Size(1131, 185);
            dgvMantenimiento.TabIndex = 6;
            dgvMantenimiento.CellClick += dgvMantenimiento_CellClick;
            dgvMantenimiento.DoubleClick += dgvMantenimiento_DoubleClick;
            // 
            // txtKilometraje
            // 
            txtKilometraje.Location = new Point(663, 77);
            txtKilometraje.Name = "txtKilometraje";
            txtKilometraje.ReadOnly = true;
            txtKilometraje.Size = new Size(228, 23);
            txtKilometraje.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(538, 80);
            label7.Name = "label7";
            label7.Size = new Size(118, 15);
            label7.TabIndex = 35;
            label7.Text = "Kilometraje vehiculo:";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(663, 112);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.ReadOnly = true;
            txtPlaca.Size = new Size(228, 23);
            txtPlaca.TabIndex = 38;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(538, 115);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 37;
            label8.Text = "Placa vehiculo:";
            // 
            // frmMantenimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 652);
            Controls.Add(dgvMantenimiento);
            Controls.Add(groupBox1);
            Name = "frmMantenimiento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMantenimiento";
            Load += frmMantenimiento_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            gbTipoMantenimiento.ResumeLayout(false);
            gbTipoMantenimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMantenimiento).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private RichTextBox rtbTrabajos;
        private ComboBox cmbMecanico;
        private TextBox txtId;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Button btnEliminar;
        private Button btnNuevo;
        private Button btnGrabar;
        private GroupBox gbTipoMantenimiento;
        private RadioButton rbCorrectivo;
        private RadioButton rbPreventivo;
        private DataGridView dgvMantenimiento;
        private TextBox txtTotalServicios;
        private Label lbTotalServicios;
        private TextBox txtTotalCorrectivo;
        private Label lbTotalTipoPre;
        private TextBox txtTotalPreventivo;
        private Label label10;
        private Label label9;
        private TextBox txtTotal;
        private TextBox txtSubtotal;
        private RichTextBox rtbServicios;
        private Button btnCalcular;
        //private TextBox txtCliente;
        private Button btnCliente;
        private TextBox txtNombre;
        private GroupBox groupBox4;
        private Button btnServiciosAdicionales;
        private RichTextBox rtbRepuestos;
        private Label label3;
        private Label lbTotalTipoCorr;
        private TextBox txtVehiculo;
        private TextBox txtPlaca;
        private Label label8;
        private TextBox txtKilometraje;
        private Label label7;
    }
}