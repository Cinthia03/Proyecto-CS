namespace CapaPresentacion
{
    partial class frmGestionMecanico
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
            dgvMecanico = new DataGridView();
            groupBox1 = new GroupBox();
            btnEliminar = new Button();
            btnNuevo = new Button();
            btnGrabar = new Button();
            gbMecanicos = new GroupBox();
            txtCorreo = new TextBox();
            label7 = new Label();
            txtId = new TextBox();
            txtCelular = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtCedula = new TextBox();
            label5 = new Label();
            txtNombre = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMecanico).BeginInit();
            groupBox1.SuspendLayout();
            gbMecanicos.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClienteVehiculo
            // 
            dgvMecanico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMecanico.Location = new Point(12, 195);
            dgvMecanico.Name = "dgvClienteVehiculo";
            dgvMecanico.RowTemplate.Height = 25;
            dgvMecanico.Size = new Size(771, 243);
            dgvMecanico.TabIndex = 5;
            dgvMecanico.CellClick += dgvClienteVehiculo_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(btnGrabar);
            groupBox1.Location = new Point(590, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(157, 138);
            groupBox1.TabIndex = 4;
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
            // gbMecanicos
            // 
            gbMecanicos.Controls.Add(txtCorreo);
            gbMecanicos.Controls.Add(label7);
            gbMecanicos.Controls.Add(txtId);
            gbMecanicos.Controls.Add(txtCelular);
            gbMecanicos.Controls.Add(label2);
            gbMecanicos.Controls.Add(label3);
            gbMecanicos.Controls.Add(txtCedula);
            gbMecanicos.Controls.Add(label5);
            gbMecanicos.Controls.Add(txtNombre);
            gbMecanicos.Controls.Add(label6);
            gbMecanicos.Location = new Point(12, 12);
            gbMecanicos.Name = "gbMecanicos";
            gbMecanicos.Size = new Size(561, 167);
            gbMecanicos.TabIndex = 3;
            gbMecanicos.TabStop = false;
            gbMecanicos.Text = "Datos del mecanico";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(134, 135);
            txtCorreo.Margin = new Padding(4, 3, 4, 3);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(263, 23);
            txtCorreo.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 137);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 41;
            label7.Text = "Corrreo: ";
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
            // txtCelular
            // 
            txtCelular.Location = new Point(134, 106);
            txtCelular.Margin = new Padding(4, 3, 4, 3);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(147, 23);
            txtCelular.TabIndex = 38;
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
            label3.Location = new Point(13, 108);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 37;
            label3.Text = "Celular: ";
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(134, 77);
            txtCedula.Margin = new Padding(4, 3, 4, 3);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(147, 23);
            txtCedula.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 79);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 33;
            label5.Text = "Cedula: ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(134, 48);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(380, 23);
            txtNombre.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 51);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(113, 15);
            label6.TabIndex = 31;
            label6.Text = "Nombre Completo: ";
            // 
            // frmGestionMecanico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMecanico);
            Controls.Add(groupBox1);
            Controls.Add(gbMecanicos);
            Name = "frmGestionMecanico";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMecanico";
            Load += frmMecanico_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMecanico).EndInit();
            groupBox1.ResumeLayout(false);
            gbMecanicos.ResumeLayout(false);
            gbMecanicos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMecanico;
        private GroupBox groupBox1;
        private Button btnEliminar;
        private Button btnNuevo;
        private Button btnGrabar;
        private GroupBox gbMecanicos;
        private TextBox txtCorreo;
        private Label label7;
        private TextBox txtId;
        private TextBox txtCelular;
        private Label label2;
        private Label label3;
        private TextBox txtCedula;
        private Label label5;
        private TextBox txtNombre;
        private Label label6;
    }
}