namespace CapaPresentacion
{
    partial class frmRepuestos
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
            gbRepuestos = new GroupBox();
            txtCantidad = new TextBox();
            txtId = new TextBox();
            label5 = new Label();
            label3 = new Label();
            txtTotal = new TextBox();
            txtPrecio = new TextBox();
            cmbRepuestos = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            label11 = new Label();
            groupBox1 = new GroupBox();
            btnEnviar = new Button();
            btnEliminar = new Button();
            btnNuevo = new Button();
            btnGrabar = new Button();
            dgvRepuestos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            txtTot = new TextBox();
            label1 = new Label();
            gbRepuestos.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRepuestos).BeginInit();
            SuspendLayout();
            // 
            // gbRepuestos
            // 
            gbRepuestos.Controls.Add(txtCantidad);
            gbRepuestos.Controls.Add(txtId);
            gbRepuestos.Controls.Add(label5);
            gbRepuestos.Controls.Add(label3);
            gbRepuestos.Controls.Add(txtTotal);
            gbRepuestos.Controls.Add(txtPrecio);
            gbRepuestos.Controls.Add(cmbRepuestos);
            gbRepuestos.Controls.Add(label4);
            gbRepuestos.Controls.Add(label6);
            gbRepuestos.Controls.Add(label11);
            gbRepuestos.Location = new Point(21, 23);
            gbRepuestos.Margin = new Padding(2);
            gbRepuestos.Name = "gbRepuestos";
            gbRepuestos.Padding = new Padding(2);
            gbRepuestos.Size = new Size(612, 124);
            gbRepuestos.TabIndex = 69;
            gbRepuestos.TabStop = false;
            gbRepuestos.Text = "Datos de los Repuestos";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(99, 83);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.ReadOnly = true;
            txtCantidad.Size = new Size(54, 23);
            txtCantidad.TabIndex = 19;
            // 
            // txtId
            // 
            txtId.Location = new Point(100, 20);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(130, 23);
            txtId.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 21);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 15;
            label5.Text = "Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 86);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 11;
            label3.Text = "Cantidad:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(355, 52);
            txtTotal.Margin = new Padding(2);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(121, 23);
            txtTotal.TabIndex = 6;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(100, 52);
            txtPrecio.Margin = new Padding(2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(130, 23);
            txtPrecio.TabIndex = 5;
            // 
            // cmbRepuestos
            // 
            cmbRepuestos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRepuestos.Enabled = false;
            cmbRepuestos.FormattingEnabled = true;
            cmbRepuestos.Location = new Point(355, 21);
            cmbRepuestos.Margin = new Padding(2);
            cmbRepuestos.Name = "cmbRepuestos";
            cmbRepuestos.Size = new Size(218, 23);
            cmbRepuestos.TabIndex = 4;
            cmbRepuestos.SelectedIndexChanged += cmbRepuestos_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(282, 60);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Subtotal:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 55);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 1;
            label6.Text = "Precio:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(282, 23);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(59, 15);
            label11.TabIndex = 0;
            label11.Text = "Repuesto:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEnviar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(btnGrabar);
            groupBox1.Location = new Point(655, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(133, 124);
            groupBox1.TabIndex = 74;
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
            btnNuevo.Click += btnNuevo_Click_1;
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
            // dgvRepuestos
            // 
            dgvRepuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRepuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRepuestos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dgvRepuestos.Location = new Point(20, 152);
            dgvRepuestos.Margin = new Padding(2);
            dgvRepuestos.Name = "dgvRepuestos";
            dgvRepuestos.RowHeadersWidth = 51;
            dgvRepuestos.RowTemplate.Height = 24;
            dgvRepuestos.Size = new Size(754, 301);
            dgvRepuestos.TabIndex = 75;
            dgvRepuestos.CellClick += dgvRepuestos_CellClick;
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
            // Column4
            // 
            Column4.HeaderText = "Cantidad";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Subtotal";
            Column5.Name = "Column5";
            // 
            // txtTot
            // 
            txtTot.Location = new Point(220, 466);
            txtTot.Margin = new Padding(2);
            txtTot.Name = "txtTot";
            txtTot.ReadOnly = true;
            txtTot.Size = new Size(121, 23);
            txtTot.TabIndex = 77;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 469);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 76;
            label1.Text = "Total : ";
            // 
            // frmRepuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(txtTot);
            Controls.Add(label1);
            Controls.Add(dgvRepuestos);
            Controls.Add(groupBox1);
            Controls.Add(gbRepuestos);
            Name = "frmRepuestos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRepuestos";
            gbRepuestos.ResumeLayout(false);
            gbRepuestos.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRepuestos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbRepuestos;
        private Label label3;
        private TextBox txtTotal;
        private TextBox txtPrecio;
        private ComboBox cmbRepuestos;
        private Label label4;
        private Label label6;
        private Label label11;
        private GroupBox groupBox1;
        private Button btnEliminar;
        private Button btnNuevo;
        private Button btnGrabar;
        private DataGridView dgvRepuestos;
        private TextBox txtId;
        private Label label5;
        private TextBox txtCantidad;
        private TextBox txtTot;
        private Label label1;
        private Button btnEnviar;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}