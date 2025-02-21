namespace SIST_STOCK
{
    partial class pantallaPrincipal
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
            this.botonAgregarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonAgregarProducto
            // 
            this.botonAgregarProducto.BackColor = System.Drawing.Color.Cyan;
            this.botonAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonAgregarProducto.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregarProducto.Location = new System.Drawing.Point(12, 12);
            this.botonAgregarProducto.Name = "botonAgregarProducto";
            this.botonAgregarProducto.Size = new System.Drawing.Size(202, 29);
            this.botonAgregarProducto.TabIndex = 0;
            this.botonAgregarProducto.Text = "Agregar Producto";
            this.botonAgregarProducto.UseVisualStyleBackColor = false;
            this.botonAgregarProducto.Click += new System.EventHandler(this.botonAgregarProducto_Click);
            // 
            // pantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonAgregarProducto);
            this.Name = "pantallaPrincipal";
            this.Text = "Pantalla Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonAgregarProducto;
    }
}

