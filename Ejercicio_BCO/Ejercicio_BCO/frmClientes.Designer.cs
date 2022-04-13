
namespace Ejercicio_BCO
{
    partial class frmClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.agregarCliente = new System.Windows.Forms.Button();
            this.modificarCliente = new System.Windows.Forms.Button();
            this.eliminarCliente = new System.Windows.Forms.Button();
            this.consultarCliente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de clientes";
            // 
            // agregarCliente
            // 
            this.agregarCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.agregarCliente.Location = new System.Drawing.Point(46, 837);
            this.agregarCliente.Name = "agregarCliente";
            this.agregarCliente.Size = new System.Drawing.Size(224, 53);
            this.agregarCliente.TabIndex = 2;
            this.agregarCliente.Text = "Agregar";
            this.agregarCliente.UseVisualStyleBackColor = true;
            this.agregarCliente.Click += new System.EventHandler(this.agregarCliente_Click);
            // 
            // modificarCliente
            // 
            this.modificarCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.modificarCliente.Location = new System.Drawing.Point(309, 837);
            this.modificarCliente.Name = "modificarCliente";
            this.modificarCliente.Size = new System.Drawing.Size(224, 53);
            this.modificarCliente.TabIndex = 3;
            this.modificarCliente.Text = "Modificar";
            this.modificarCliente.UseVisualStyleBackColor = true;
            this.modificarCliente.Click += new System.EventHandler(this.modificarCliente_Click);
            // 
            // eliminarCliente
            // 
            this.eliminarCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.eliminarCliente.Location = new System.Drawing.Point(566, 837);
            this.eliminarCliente.Name = "eliminarCliente";
            this.eliminarCliente.Size = new System.Drawing.Size(224, 53);
            this.eliminarCliente.TabIndex = 4;
            this.eliminarCliente.Text = "Eliminar";
            this.eliminarCliente.UseVisualStyleBackColor = true;
            // 
            // consultarCliente
            // 
            this.consultarCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.consultarCliente.Location = new System.Drawing.Point(836, 837);
            this.consultarCliente.Name = "consultarCliente";
            this.consultarCliente.Size = new System.Drawing.Size(224, 53);
            this.consultarCliente.TabIndex = 5;
            this.consultarCliente.Text = "Consultar";
            this.consultarCliente.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(2306, 563);
            this.dataGridView1.TabIndex = 6;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2426, 999);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.consultarCliente);
            this.Controls.Add(this.eliminarCliente);
            this.Controls.Add(this.modificarCliente);
            this.Controls.Add(this.agregarCliente);
            this.Controls.Add(this.label1);
            this.Name = "frmClientes";
            this.Text = "..::CLIENTES::..";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button agregarCliente;
        private System.Windows.Forms.Button modificarCliente;
        private System.Windows.Forms.Button eliminarCliente;
        private System.Windows.Forms.Button consultarCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

