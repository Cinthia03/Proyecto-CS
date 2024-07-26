namespace CapaPresentacion
{
    partial class frmGestionRepuestos
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
            dgvInventarioRepuestos = new DataGridView();
            groupBox1 = new GroupBox();
            btnEliminar = new Button();
            btnNuevo = new Button();
            btnGrabar = new Button();
            gbRepuestos = new GroupBox();
            txtPrecioRepuesto = new TextBox();
            txtNombreRepuesto = new TextBox();
            txtId = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvInventarioRepuestos).BeginInit();
            groupBox1.SuspendLayout();
            gbRepuestos.SuspendLayout();
            SuspendLayout();
            // 
            // txtTot
            // 
            txtTot.Location = new Point(668, 455);
            txtTot.Margin = new Padding(2);
            txtTot.Name = "txtTot";
            txtTot.ReadOnly = true;
            txtTot.Size = new Size(121, 23);
            txtTot.TabIndex = 82;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(613, 458);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 81;
            label1.Text = "Total : ";
            // 
            // dgvInventarioRepuestos
            // 
            dgvInventarioRepuestos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventarioRepuestos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventarioRepuestos.Location = new Point(21, 146);
            dgvInventarioRepuestos.Margin = new Padding(2);
            dgvInventarioRepuestos.Name = "dgvInventarioRepuestos";
            dgvInventarioRepuestos.RowHeadersWidth = 51;
            dgvInventarioRepuestos.RowTemplate.Height = 24;
            dgvInventarioRepuestos.Size = new Size(561, 293);
            dgvInventarioRepuestos.TabIndex = 80;
            dgvInventarioRepuestos.CellClick += dgvInventarioRepuestos_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(btnGrabar);
            groupBox1.Location = new Point(449, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(133, 120);
            groupBox1.TabIndex = 79;
            groupBox1.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(14, 85);
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
            btnGrabar.Location = new Point(14, 48);
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
            gbRepuestos.Controls.Add(txtPrecioRepuesto);
            gbRepuestos.Controls.Add(txtNombreRepuesto);
            gbRepuestos.Controls.Add(txtId);
            gbRepuestos.Controls.Add(label5);
            gbRepuestos.Controls.Add(label6);
            gbRepuestos.Controls.Add(label11);
            gbRepuestos.Location = new Point(22, 12);
            gbRepuestos.Margin = new Padding(2);
            gbRepuestos.Name = "gbRepuestos";
            gbRepuestos.Padding = new Padding(2);
            gbRepuestos.Size = new Size(404, 120);
            gbRepuestos.TabIndex = 78;
            gbRepuestos.TabStop = false;
            gbRepuestos.Text = "Datos de los Repuestos";
            // 
            // txtPrecioRepuesto
            // 
            txtPrecioRepuesto.Location = new Point(154, 86);
            txtPrecioRepuesto.Name = "txtPrecioRepuesto";
            txtPrecioRepuesto.Size = new Size(115, 23);
            txtPrecioRepuesto.TabIndex = 21;
            // 
            // txtNombreRepuesto
            // 
            txtNombreRepuesto.Location = new Point(154, 55);
            txtNombreRepuesto.Name = "txtNombreRepuesto";
            txtNombreRepuesto.Size = new Size(219, 23);
            txtNombreRepuesto.TabIndex = 20;
            // 
            // txtId
            // 
            txtId.Location = new Point(154, 20);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(130, 23);
            txtId.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 20);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 15;
            label5.Text = "Id:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 86);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 1;
            label6.Text = "Precio:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(22, 56);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(125, 15);
            label11.TabIndex = 0;
            label11.Text = "Nombre del Repuesto:";
            // 
            // frmGestionInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 450);
            Controls.Add(txtTot);
            Controls.Add(label1);
            Controls.Add(dgvInventarioRepuestos);
            Controls.Add(groupBox1);
            Controls.Add(gbRepuestos);
            Name = "frmGestionInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInventario";
            Load += frmGestionInventario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventarioRepuestos).EndInit();
            groupBox1.ResumeLayout(false);
            gbRepuestos.ResumeLayout(false);
            gbRepuestos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTot;
        private Label label1;
        private DataGridView dgvInventarioRepuestos;
        private GroupBox groupBox1;
        private Button btnEliminar;
        private Button btnNuevo;
        private Button btnGrabar;
        private GroupBox gbRepuestos;
        private TextBox txtId;
        private Label label5;
        private Label label6;
        private Label label11;
        private TextBox txtPrecioRepuesto;
        private TextBox txtNombreRepuesto;
    }
}