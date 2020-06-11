namespace Caja
{
    partial class MenuAdmin
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
            this.components = new System.ComponentModel.Container();
            this.gridViewCajero = new System.Windows.Forms.DataGridView();
            this.dataSetCajero = new Caja.DataSetCajero();
            this.dataSetCajeroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cajeroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cajeroTableAdapter = new Caja.DataSetCajeroTableAdapters.CajeroTableAdapter();
            this.rutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRut = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtDigito = new System.Windows.Forms.TextBox();
            this.lblRepetir = new System.Windows.Forms.Label();
            this.txtRepetir = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCajero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCajero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCajeroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajeroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewCajero
            // 
            this.gridViewCajero.AllowUserToAddRows = false;
            this.gridViewCajero.AllowUserToDeleteRows = false;
            this.gridViewCajero.AutoGenerateColumns = false;
            this.gridViewCajero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewCajero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rutDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn});
            this.gridViewCajero.DataSource = this.cajeroBindingSource;
            this.gridViewCajero.Location = new System.Drawing.Point(12, 12);
            this.gridViewCajero.Name = "gridViewCajero";
            this.gridViewCajero.ReadOnly = true;
            this.gridViewCajero.Size = new System.Drawing.Size(345, 305);
            this.gridViewCajero.TabIndex = 0;
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
            // rutDataGridViewTextBoxColumn
            // 
            this.rutDataGridViewTextBoxColumn.DataPropertyName = "rut";
            this.rutDataGridViewTextBoxColumn.HeaderText = "rut";
            this.rutDataGridViewTextBoxColumn.Name = "rutDataGridViewTextBoxColumn";
            this.rutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "pass";
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            this.passDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Location = new System.Drawing.Point(363, 32);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(30, 13);
            this.lblRut.TabIndex = 1;
            this.lblRut.Text = "RUT";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(363, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(363, 86);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(61, 13);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Contraseña";
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(484, 32);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(69, 20);
            this.txtRut.TabIndex = 4;
            this.txtRut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRut_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(484, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(109, 20);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(484, 87);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(109, 20);
            this.txtPass.TabIndex = 6;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // txtDigito
            // 
            this.txtDigito.Location = new System.Drawing.Point(560, 33);
            this.txtDigito.Name = "txtDigito";
            this.txtDigito.Size = new System.Drawing.Size(33, 20);
            this.txtDigito.TabIndex = 7;
            this.txtDigito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigito_KeyPress);
            // 
            // lblRepetir
            // 
            this.lblRepetir.AutoSize = true;
            this.lblRepetir.Location = new System.Drawing.Point(363, 117);
            this.lblRepetir.Name = "lblRepetir";
            this.lblRepetir.Size = new System.Drawing.Size(97, 13);
            this.lblRepetir.TabIndex = 8;
            this.lblRepetir.Text = "Repetir contraseña";
            // 
            // txtRepetir
            // 
            this.txtRepetir.Location = new System.Drawing.Point(484, 117);
            this.txtRepetir.Name = "txtRepetir";
            this.txtRepetir.PasswordChar = '*';
            this.txtRepetir.Size = new System.Drawing.Size(109, 20);
            this.txtRepetir.TabIndex = 9;
            this.txtRepetir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRepetir_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(366, 159);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 38);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar cajero";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 338);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtRepetir);
            this.Controls.Add(this.lblRepetir);
            this.Controls.Add(this.txtDigito);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblRut);
            this.Controls.Add(this.gridViewCajero);
            this.Name = "MenuAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCajero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCajero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCajeroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajeroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewCajero;
        private System.Windows.Forms.BindingSource dataSetCajeroBindingSource;
        private DataSetCajero dataSetCajero;
        private System.Windows.Forms.BindingSource cajeroBindingSource;
        private DataSetCajeroTableAdapters.CajeroTableAdapter cajeroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtDigito;
        private System.Windows.Forms.Label lblRepetir;
        private System.Windows.Forms.TextBox txtRepetir;
        private System.Windows.Forms.Button btnAgregar;
    }
}