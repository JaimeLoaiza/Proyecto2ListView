namespace Proyecto_Lista2_ListViewListadeDatos
{
    partial class Form1
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
            this.lbllistadedatos = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblnombreproducto = new System.Windows.Forms.Label();
            this.lblvalor = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnombreproducto = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.btnagregarproducto = new System.Windows.Forms.Button();
            this.btnlistadeproductos = new System.Windows.Forms.Button();
            this.LISTA = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbllistadedatos
            // 
            this.lbllistadedatos.AutoSize = true;
            this.lbllistadedatos.Location = new System.Drawing.Point(138, 36);
            this.lbllistadedatos.Name = "lbllistadedatos";
            this.lbllistadedatos.Size = new System.Drawing.Size(80, 13);
            this.lbllistadedatos.TabIndex = 0;
            this.lbllistadedatos.Text = "Listas de Datos";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(55, 91);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(16, 13);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "Id";
            // 
            // lblnombreproducto
            // 
            this.lblnombreproducto.AutoSize = true;
            this.lblnombreproducto.Location = new System.Drawing.Point(129, 91);
            this.lblnombreproducto.Name = "lblnombreproducto";
            this.lblnombreproducto.Size = new System.Drawing.Size(107, 13);
            this.lblnombreproducto.TabIndex = 2;
            this.lblnombreproducto.Text = "Nombre del Producto";
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(285, 91);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(31, 13);
            this.lblvalor.TabIndex = 3;
            this.lblvalor.Text = "Valor";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(28, 107);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(75, 20);
            this.txtid.TabIndex = 4;
            // 
            // txtnombreproducto
            // 
            this.txtnombreproducto.Location = new System.Drawing.Point(109, 107);
            this.txtnombreproducto.Name = "txtnombreproducto";
            this.txtnombreproducto.Size = new System.Drawing.Size(142, 20);
            this.txtnombreproducto.TabIndex = 5;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(257, 107);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 6;
            // 
            // btnagregarproducto
            // 
            this.btnagregarproducto.Location = new System.Drawing.Point(58, 153);
            this.btnagregarproducto.Name = "btnagregarproducto";
            this.btnagregarproducto.Size = new System.Drawing.Size(100, 23);
            this.btnagregarproducto.TabIndex = 7;
            this.btnagregarproducto.Text = "Agregar Producto";
            this.btnagregarproducto.UseVisualStyleBackColor = true;
            this.btnagregarproducto.Click += new System.EventHandler(this.btnagregarproducto_Click);
            // 
            // btnlistadeproductos
            // 
            this.btnlistadeproductos.Location = new System.Drawing.Point(209, 153);
            this.btnlistadeproductos.Name = "btnlistadeproductos";
            this.btnlistadeproductos.Size = new System.Drawing.Size(107, 23);
            this.btnlistadeproductos.TabIndex = 8;
            this.btnlistadeproductos.Text = "Lista de Productos";
            this.btnlistadeproductos.UseVisualStyleBackColor = true;
            this.btnlistadeproductos.Click += new System.EventHandler(this.btnlistadeproductos_Click);
            // 
            // LISTA
            // 
            this.LISTA.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.NombreProducto,
            this.Valor});
            this.LISTA.HideSelection = false;
            this.LISTA.Location = new System.Drawing.Point(28, 202);
            this.LISTA.Name = "LISTA";
            this.LISTA.Size = new System.Drawing.Size(329, 197);
            this.LISTA.TabIndex = 9;
            this.LISTA.UseCompatibleStateImageBehavior = false;
            this.LISTA.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 75;
            // 
            // NombreProducto
            // 
            this.NombreProducto.Text = "Nombre Producto";
            this.NombreProducto.Width = 140;
            // 
            // Valor
            // 
            this.Valor.Text = "Valor";
            this.Valor.Width = 105;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(244, 415);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(113, 23);
            this.btnsalir.TabIndex = 10;
            this.btnsalir.Text = "Salir de la Aplicación";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.LISTA);
            this.Controls.Add(this.btnlistadeproductos);
            this.Controls.Add(this.btnagregarproducto);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtnombreproducto);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.lblnombreproducto);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.lbllistadedatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllistadedatos;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblnombreproducto;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnombreproducto;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Button btnagregarproducto;
        private System.Windows.Forms.Button btnlistadeproductos;
        private System.Windows.Forms.ListView LISTA;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader NombreProducto;
        private System.Windows.Forms.ColumnHeader Valor;
        private System.Windows.Forms.Button btnsalir;
    }
}

