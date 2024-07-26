namespace CapaPresentacion
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            mecanicosToolStripMenuItem = new ToolStripMenuItem();
            clienteYVehiculoToolStripMenuItem = new ToolStripMenuItem();
            vehiculosToolStripMenuItem = new ToolStripMenuItem();
            repuestosToolStripMenuItem = new ToolStripMenuItem();
            serviciosAdicionalesToolStripMenuItem = new ToolStripMenuItem();
            registroToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(777, 619);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mantenimientoToolStripMenuItem, registroToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(777, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mecanicosToolStripMenuItem, clienteYVehiculoToolStripMenuItem, vehiculosToolStripMenuItem, repuestosToolStripMenuItem, serviciosAdicionalesToolStripMenuItem });
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(67, 20);
            mantenimientoToolStripMenuItem.Text = "Registros";
            mantenimientoToolStripMenuItem.Click += mantenimientoToolStripMenuItem_Click;
            // 
            // mecanicosToolStripMenuItem
            // 
            mecanicosToolStripMenuItem.Name = "mecanicosToolStripMenuItem";
            mecanicosToolStripMenuItem.Size = new Size(184, 22);
            mecanicosToolStripMenuItem.Text = "Mecanicos";
            mecanicosToolStripMenuItem.Click += mecanicosToolStripMenuItem_Click;
            // 
            // clienteYVehiculoToolStripMenuItem
            // 
            clienteYVehiculoToolStripMenuItem.Name = "clienteYVehiculoToolStripMenuItem";
            clienteYVehiculoToolStripMenuItem.Size = new Size(184, 22);
            clienteYVehiculoToolStripMenuItem.Text = "Cliente ";
            clienteYVehiculoToolStripMenuItem.Click += clienteYVehiculoToolStripMenuItem_Click;
            // 
            // vehiculosToolStripMenuItem
            // 
            vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            vehiculosToolStripMenuItem.Size = new Size(184, 22);
            vehiculosToolStripMenuItem.Text = "Vehiculos";
            vehiculosToolStripMenuItem.Click += vehiculosToolStripMenuItem_Click;
            // 
            // repuestosToolStripMenuItem
            // 
            repuestosToolStripMenuItem.Name = "repuestosToolStripMenuItem";
            repuestosToolStripMenuItem.Size = new Size(184, 22);
            repuestosToolStripMenuItem.Text = "Repuestos";
            repuestosToolStripMenuItem.Click += repuestosToolStripMenuItem_Click;
            // 
            // serviciosAdicionalesToolStripMenuItem
            // 
            serviciosAdicionalesToolStripMenuItem.Name = "serviciosAdicionalesToolStripMenuItem";
            serviciosAdicionalesToolStripMenuItem.Size = new Size(184, 22);
            serviciosAdicionalesToolStripMenuItem.Text = "Servicios Adicionales";
            serviciosAdicionalesToolStripMenuItem.Click += serviciosAdicionalesToolStripMenuItem_Click;
            // 
            // registroToolStripMenuItem
            // 
            registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            registroToolStripMenuItem.Size = new Size(143, 20);
            registroToolStripMenuItem.Text = "Mantenimiento Factura";
            registroToolStripMenuItem.Click += registroToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 640);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPrincipal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem clienteYVehiculoToolStripMenuItem;
        private ToolStripMenuItem mecanicosToolStripMenuItem;
        private ToolStripMenuItem registroToolStripMenuItem;
        private ToolStripMenuItem repuestosToolStripMenuItem;
        private ToolStripMenuItem serviciosAdicionalesToolStripMenuItem;
        private ToolStripMenuItem vehiculosToolStripMenuItem;
    }
}