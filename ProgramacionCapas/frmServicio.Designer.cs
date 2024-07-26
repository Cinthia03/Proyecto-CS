namespace CapaPresentacion
{
    partial class frmServicio
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
            txtTot = new TextBox();
            label1 = new Label();
            dgvServicios = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnEnviar = new Button();
            btnEliminar = new Button();
            btnNuevo = new Button();
            btnGrabar = new Button();
            gbRepuestos = new GroupBox();
            txtId = new TextBox();
            label5 = new Label();
            txtPrecio = new TextBox();
            cmbServicios = new ComboBox();
            label6 = new Label();
            lblServicio = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            groupBox1.SuspendLayout();
            gbRepuestos.SuspendLayout();
            SuspendLayout();
            // 
            // txtTot
            // 
            txtTot.Location = new Point(503, 461);
            txtTot.Margin = new Padding(2);
            txtTot.Name = "txtTot";
            txtTot.ReadOnly = true;
            txtTot.Size = new Size(121, 23);
            txtTot.TabIndex = 82;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(448, 464);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 81;
            label1.Text = "Total : ";
            // 
            // dgvServicios
            // 
            dgvServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvServicios.Location = new Point(11, 142);
            dgvServicios.Margin = new Padding(2);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.RowHeadersWidth = 51;
            dgvServicios.RowTemplate.Height = 24;
            dgvServicios.Size = new Size(613, 301);
            dgvServicios.TabIndex = 80;
            dgvServicios.CellClick += dgvServicios_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Precio";
            Column3.Name = "Column3";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEnviar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(btnGrabar);
            groupBox1.Location = new Point(479, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(133, 124);
            groupBox1.TabIndex = 79;
            groupBox1.TabStop = false;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(14, 95);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(105, 23);
            btnEnviar.TabIndex = 78;
            btnEnviar.Text = "Enviar Dato";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(14, 67);
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
            btnNuevo.Location = new Point(14, 13);
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
            btnGrabar.Location = new Point(14, 40);
            btnGrabar.Margin = new Padding(2);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(105, 23);
            btnGrabar.TabIndex = 29;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // gbRepuestos
            // 
            gbRepuestos.Controls.Add(txtId);
            gbRepuestos.Controls.Add(label5);
            gbRepuestos.Controls.Add(txtPrecio);
            gbRepuestos.Controls.Add(groupBox1);
            gbRepuestos.Controls.Add(cmbServicios);
            gbRepuestos.Controls.Add(label6);
            gbRepuestos.Controls.Add(lblServicio);
            gbRepuestos.Location = new Point(12, 13);
            gbRepuestos.Margin = new Padding(2);
            gbRepuestos.Name = "gbRepuestos";
            gbRepuestos.Padding = new Padding(2);
            gbRepuestos.Size = new Size(612, 124);
            gbRepuestos.TabIndex = 78;
            gbRepuestos.TabStop = false;
            gbRepuestos.Text = "Datos de los Repuestos";
            // 
            // txtId
            // 
            txtId.Location = new Point(100, 20);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(85, 23);
            txtId.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 23);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 15;
            label5.Text = "Id:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(100, 55);
            txtPrecio.Margin = new Padding(2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(85, 23);
            txtPrecio.TabIndex = 5;
            // 
            // cmbServicios
            // 
            cmbServicios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbServicios.Enabled = false;
            cmbServicios.FormattingEnabled = true;
            cmbServicios.Location = new Point(332, 20);
            cmbServicios.Margin = new Padding(2);
            cmbServicios.Name = "cmbServicios";
            cmbServicios.Size = new Size(130, 23);
            cmbServicios.TabIndex = 4;
            cmbServicios.SelectedIndexChanged += cmbServicios_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 58);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 1;
            label6.Text = "Precio:";
            // 
            // lblServicio
            // 
            lblServicio.AutoSize = true;
            lblServicio.Location = new Point(260, 23);
            lblServicio.Margin = new Padding(2, 0, 2, 0);
            lblServicio.Name = "lblServicio";
            lblServicio.Size = new Size(51, 15);
            lblServicio.TabIndex = 0;
            lblServicio.Text = "Servicio:";
            // 
            // frmServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 495);
            Controls.Add(txtTot);
            Controls.Add(label1);
            Controls.Add(dgvServicios);
            Controls.Add(gbRepuestos);
            Name = "frmServicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmServicio";
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            groupBox1.ResumeLayout(false);
            gbRepuestos.ResumeLayout(false);
            gbRepuestos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTot;
        private Label label1;
        private DataGridView dgvServicios;
        private GroupBox groupBox1;
        private Button btnEnviar;
        private Button btnEliminar;
        private Button btnNuevo;
        private Button btnGrabar;
        private GroupBox gbRepuestos;
        private TextBox txtId;
        private Label label5;
        private TextBox txtPrecio;
        private ComboBox cmbServicios;
        private Label label6;
        private Label lblServicio;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}