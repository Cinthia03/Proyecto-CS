namespace CapaPresentacion
{
    partial class frmClientes
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
            dgvCargaClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCargaClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvCargaClientes
            // 
            dgvCargaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCargaClientes.Location = new Point(40, 30);
            dgvCargaClientes.Name = "dgvCargaClientes";
            dgvCargaClientes.RowTemplate.Height = 25;
            dgvCargaClientes.Size = new Size(699, 394);
            dgvCargaClientes.TabIndex = 2;
            dgvCargaClientes.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // frmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCargaClientes);
            Name = "frmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmClientes";
            Load += frmClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCargaClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvCargaClientes;
    }
}