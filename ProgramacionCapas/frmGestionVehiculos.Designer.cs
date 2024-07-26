namespace CapaPresentacion
{
    partial class frmGestionVehiculos
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
            dgvVehiculo = new DataGridView();
            groupBox1 = new GroupBox();
            btnEliminar = new Button();
            btnNuevo = new Button();
            btnGrabar = new Button();
            gbVehiculos = new GroupBox();
            cmbCliente = new ComboBox();
            label7 = new Label();
            txtPlaca = new TextBox();
            txtId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtKilometraje = new TextBox();
            label5 = new Label();
            txtVehiculo = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculo).BeginInit();
            groupBox1.SuspendLayout();
            gbVehiculos.SuspendLayout();
            SuspendLayout();
            // 
            // dgvVehiculo
            // 
            dgvVehiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculo.Location = new Point(16, 195);
            dgvVehiculo.Name = "dgvVehiculo";
            dgvVehiculo.RowTemplate.Height = 25;
            dgvVehiculo.Size = new Size(550, 243);
            dgvVehiculo.TabIndex = 8;
            dgvVehiculo.CellClick += dgvVehiculo_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(btnGrabar);
            groupBox1.Location = new Point(409, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(157, 138);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(29, 102);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(105, 23);
            btnEliminar.TabIndex = 30;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(29, 21);
            btnNuevo.Margin = new Padding(2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(105, 23);
            btnNuevo.TabIndex = 28;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Enabled = false;
            btnGrabar.Location = new Point(29, 62);
            btnGrabar.Margin = new Padding(2);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(105, 23);
            btnGrabar.TabIndex = 29;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // gbVehiculos
            // 
            gbVehiculos.Controls.Add(cmbCliente);
            gbVehiculos.Controls.Add(label7);
            gbVehiculos.Controls.Add(txtPlaca);
            gbVehiculos.Controls.Add(txtId);
            gbVehiculos.Controls.Add(label2);
            gbVehiculos.Controls.Add(label3);
            gbVehiculos.Controls.Add(txtKilometraje);
            gbVehiculos.Controls.Add(label5);
            gbVehiculos.Controls.Add(txtVehiculo);
            gbVehiculos.Controls.Add(label6);
            gbVehiculos.Location = new Point(16, 12);
            gbVehiculos.Name = "gbVehiculos";
            gbVehiculos.Size = new Size(373, 167);
            gbVehiculos.TabIndex = 6;
            gbVehiculos.TabStop = false;
            gbVehiculos.Text = "Datos de los vehiculos";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(134, 135);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(214, 23);
            cmbCliente.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 109);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 41;
            label7.Text = "Placa: ";
            // 
            // txtPlaca
            // 
            txtPlaca.Location = new Point(134, 106);
            txtPlaca.Margin = new Padding(4, 3, 4, 3);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(214, 23);
            txtPlaca.TabIndex = 42;
            // 
            // txtId
            // 
            txtId.Location = new Point(134, 21);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(90, 23);
            txtId.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 23);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 39;
            label2.Text = "Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 138);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 37;
            label3.Text = "Nombre del cliente: ";
            // 
            // txtKilometraje
            // 
            txtKilometraje.Location = new Point(134, 77);
            txtKilometraje.Margin = new Padding(4, 3, 4, 3);
            txtKilometraje.Name = "txtKilometraje";
            txtKilometraje.Size = new Size(147, 23);
            txtKilometraje.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 79);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 33;
            label5.Text = "Kilometraje: ";
            // 
            // txtVehiculo
            // 
            txtVehiculo.Location = new Point(134, 48);
            txtVehiculo.Margin = new Padding(4, 3, 4, 3);
            txtVehiculo.Name = "txtVehiculo";
            txtVehiculo.Size = new Size(214, 23);
            txtVehiculo.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 51);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 31;
            label6.Text = "Nombre Vehiculo: ";
            // 
            // frmGestionVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 450);
            Controls.Add(dgvVehiculo);
            Controls.Add(groupBox1);
            Controls.Add(gbVehiculos);
            Name = "frmGestionVehiculos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGestionVehiculos";
            Load += frmGestionVehiculos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVehiculo).EndInit();
            groupBox1.ResumeLayout(false);
            gbVehiculos.ResumeLayout(false);
            gbVehiculos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVehiculo;
        private GroupBox groupBox1;
        private Button btnEliminar;
        private Button btnNuevo;
        private Button btnGrabar;
        private GroupBox gbVehiculos;
        private TextBox txtPlaca;
        private Label label7;
        private TextBox txtId;
        private Label label2;
        private Label label3;
        private TextBox txtKilometraje;
        private Label label5;
        private TextBox txtVehiculo;
        private Label label6;
        private ComboBox cmbCliente;
    }
}