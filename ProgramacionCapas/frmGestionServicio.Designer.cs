namespace CapaPresentacion
{
    partial class frmGestionServicio
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
            dgvServiciosAdicionales = new DataGridView();
            btnEliminar = new Button();
            btnNuevo = new Button();
            btnGrabar = new Button();
            gbServiciosAdicionales = new GroupBox();
            txtPrecioServicio = new TextBox();
            txtNombreServicio = new TextBox();
            txtId = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvServiciosAdicionales).BeginInit();
            gbServiciosAdicionales.SuspendLayout();
            SuspendLayout();
            // 
            // dgvServiciosAdicionales
            // 
            dgvServiciosAdicionales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvServiciosAdicionales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServiciosAdicionales.Location = new Point(10, 191);
            dgvServiciosAdicionales.Margin = new Padding(2);
            dgvServiciosAdicionales.Name = "dgvServiciosAdicionales";
            dgvServiciosAdicionales.RowHeadersWidth = 51;
            dgvServiciosAdicionales.RowTemplate.Height = 24;
            dgvServiciosAdicionales.Size = new Size(512, 247);
            dgvServiciosAdicionales.TabIndex = 83;
            dgvServiciosAdicionales.CellClick += dgvServiciosAdicionales_CellClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(378, 144);
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
            btnNuevo.Location = new Point(104, 144);
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
            btnGrabar.Location = new Point(248, 144);
            btnGrabar.Margin = new Padding(2);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(105, 23);
            btnGrabar.TabIndex = 29;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // gbServiciosAdicionales
            // 
            gbServiciosAdicionales.Controls.Add(txtPrecioServicio);
            gbServiciosAdicionales.Controls.Add(txtNombreServicio);
            gbServiciosAdicionales.Controls.Add(txtId);
            gbServiciosAdicionales.Controls.Add(label5);
            gbServiciosAdicionales.Controls.Add(label6);
            gbServiciosAdicionales.Controls.Add(label11);
            gbServiciosAdicionales.Location = new Point(11, 11);
            gbServiciosAdicionales.Margin = new Padding(2);
            gbServiciosAdicionales.Name = "gbServiciosAdicionales";
            gbServiciosAdicionales.Padding = new Padding(2);
            gbServiciosAdicionales.Size = new Size(511, 119);
            gbServiciosAdicionales.TabIndex = 81;
            gbServiciosAdicionales.TabStop = false;
            gbServiciosAdicionales.Text = "Registro de servicios adicionales";
            // 
            // txtPrecioServicio
            // 
            txtPrecioServicio.Location = new Point(227, 78);
            txtPrecioServicio.Name = "txtPrecioServicio";
            txtPrecioServicio.Size = new Size(115, 23);
            txtPrecioServicio.TabIndex = 21;
            // 
            // txtNombreServicio
            // 
            txtNombreServicio.Location = new Point(227, 48);
            txtNombreServicio.Name = "txtNombreServicio";
            txtNombreServicio.Size = new Size(219, 23);
            txtNombreServicio.TabIndex = 20;
            // 
            // txtId
            // 
            txtId.Location = new Point(227, 20);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(78, 23);
            txtId.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 23);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 15;
            label5.Text = "Id:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 81);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 1;
            label6.Text = "Precio:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(32, 51);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(170, 15);
            label11.TabIndex = 0;
            label11.Text = "Nombre del Servicio Adicional:";
            // 
            // frmGestionServicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 450);
            Controls.Add(btnGrabar);
            Controls.Add(btnEliminar);
            Controls.Add(dgvServiciosAdicionales);
            Controls.Add(btnNuevo);
            Controls.Add(gbServiciosAdicionales);
            Name = "frmGestionServicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegistroServicio";
            Load += frmGestionServicio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServiciosAdicionales).EndInit();
            gbServiciosAdicionales.ResumeLayout(false);
            gbServiciosAdicionales.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvServiciosAdicionales;
        private Button btnEliminar;
        private Button btnNuevo;
        private Button btnGrabar;
        private GroupBox gbServiciosAdicionales;
        private TextBox txtPrecioServicio;
        private TextBox txtNombreServicio;
        private TextBox txtId;
        private Label label5;
        private Label label6;
        private Label label11;
    }
}