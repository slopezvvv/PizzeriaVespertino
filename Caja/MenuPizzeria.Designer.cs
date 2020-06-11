namespace Caja
{
    partial class MenuPizzeria
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblGanacias = new System.Windows.Forms.Label();
            this.dataSetCajero = new Caja.DataSetCajero();
            this.dataSetCajeroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cajeroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cajeroTableAdapter = new Caja.DataSetCajeroTableAdapters.CajeroTableAdapter();
            this.cajeroBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCajero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCajeroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajeroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajeroBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(103, 255);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(106, 46);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Nueva venta";
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(242, 255);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 46);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Devolución";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(377, 255);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(105, 46);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar venta";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // lblGanacias
            // 
            this.lblGanacias.AutoSize = true;
            this.lblGanacias.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanacias.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblGanacias.Location = new System.Drawing.Point(96, 46);
            this.lblGanacias.Name = "lblGanacias";
            this.lblGanacias.Size = new System.Drawing.Size(62, 42);
            this.lblGanacias.TabIndex = 4;
            this.lblGanacias.Text = "$0";
            // 
            // dataSetCajero
            // 
            this.dataSetCajero.DataSetName = "DataSetCajero";
            this.dataSetCajero.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetCajeroBindingSource
            // 
            this.dataSetCajeroBindingSource.DataSource = this.dataSetCajero;
            this.dataSetCajeroBindingSource.Position = 0;
            // 
            // cajeroBindingSource
            // 
            this.cajeroBindingSource.DataMember = "Cajero";
            this.cajeroBindingSource.DataSource = this.dataSetCajeroBindingSource;
            // 
            // cajeroTableAdapter
            // 
            this.cajeroTableAdapter.ClearBeforeFill = true;
            // 
            // cajeroBindingSource1
            // 
            this.cajeroBindingSource1.DataMember = "Cajero";
            this.cajeroBindingSource1.DataSource = this.dataSetCajeroBindingSource;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // MenuPizzeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGanacias);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPizzeria";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuPizzeria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCajero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCajeroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajeroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajeroBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblGanacias;
        private System.Windows.Forms.BindingSource dataSetCajeroBindingSource;
        private DataSetCajero dataSetCajero;
        private System.Windows.Forms.BindingSource cajeroBindingSource;
        private DataSetCajeroTableAdapters.CajeroTableAdapter cajeroTableAdapter;
        private System.Windows.Forms.BindingSource cajeroBindingSource1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
    }
}

