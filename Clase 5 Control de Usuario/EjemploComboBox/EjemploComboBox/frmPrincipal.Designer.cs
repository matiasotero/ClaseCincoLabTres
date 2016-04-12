namespace EjemploComboBox
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboCanciones = new System.Windows.Forms.ComboBox();
            this.lblCancion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInterprete = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtInterprete = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtAlbum = new System.Windows.Forms.TextBox();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.grbInterprete = new System.Windows.Forms.GroupBox();
            this.lblInterpreteSeleccionado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbInterprete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCanciones
            // 
            this.cboCanciones.FormattingEnabled = true;
            this.cboCanciones.Location = new System.Drawing.Point(107, 32);
            this.cboCanciones.Name = "cboCanciones";
            this.cboCanciones.Size = new System.Drawing.Size(166, 21);
            this.cboCanciones.TabIndex = 0;
            this.cboCanciones.SelectedIndexChanged += new System.EventHandler(this.cboCanciones_SelectedIndexChanged);
            // 
            // lblCancion
            // 
            this.lblCancion.AutoSize = true;
            this.lblCancion.Location = new System.Drawing.Point(36, 35);
            this.lblCancion.Name = "lblCancion";
            this.lblCancion.Size = new System.Drawing.Size(49, 13);
            this.lblCancion.TabIndex = 1;
            this.lblCancion.Text = "Canción:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(36, 84);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Título:";
            // 
            // lblInterprete
            // 
            this.lblInterprete.AutoSize = true;
            this.lblInterprete.Location = new System.Drawing.Point(36, 112);
            this.lblInterprete.Name = "lblInterprete";
            this.lblInterprete.Size = new System.Drawing.Size(55, 13);
            this.lblInterprete.TabIndex = 3;
            this.lblInterprete.Text = "Interprete:";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(36, 164);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(29, 13);
            this.lblAño.TabIndex = 4;
            this.lblAño.Text = "Año:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(36, 192);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 5;
            this.lblGenero.Text = "Género:";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Location = new System.Drawing.Point(36, 220);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(39, 13);
            this.lblAlbum.TabIndex = 6;
            this.lblAlbum.Text = "Album:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(107, 81);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(166, 20);
            this.txtTitulo.TabIndex = 7;
            // 
            // txtInterprete
            // 
            this.txtInterprete.Location = new System.Drawing.Point(107, 109);
            this.txtInterprete.Name = "txtInterprete";
            this.txtInterprete.Size = new System.Drawing.Size(166, 20);
            this.txtInterprete.TabIndex = 8;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(107, 161);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(166, 20);
            this.txtAño.TabIndex = 9;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(107, 189);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(166, 20);
            this.txtGenero.TabIndex = 10;
            // 
            // txtAlbum
            // 
            this.txtAlbum.Location = new System.Drawing.Point(107, 217);
            this.txtAlbum.Name = "txtAlbum";
            this.txtAlbum.Size = new System.Drawing.Size(166, 20);
            this.txtAlbum.TabIndex = 11;
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(36, 138);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(53, 13);
            this.lblDuracion.TabIndex = 12;
            this.lblDuracion.Text = "Duración:";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(107, 135);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(166, 20);
            this.txtDuracion.TabIndex = 13;
            // 
            // grbInterprete
            // 
            this.grbInterprete.Controls.Add(this.lblInterpreteSeleccionado);
            this.grbInterprete.Location = new System.Drawing.Point(27, 268);
            this.grbInterprete.Name = "grbInterprete";
            this.grbInterprete.Size = new System.Drawing.Size(270, 64);
            this.grbInterprete.TabIndex = 14;
            this.grbInterprete.TabStop = false;
            this.grbInterprete.Text = "Interprete Seleccionado";
            // 
            // lblInterpreteSeleccionado
            // 
            this.lblInterpreteSeleccionado.AutoSize = true;
            this.lblInterpreteSeleccionado.Location = new System.Drawing.Point(51, 30);
            this.lblInterpreteSeleccionado.Name = "lblInterpreteSeleccionado";
            this.lblInterpreteSeleccionado.Size = new System.Drawing.Size(0, 13);
            this.lblInterpreteSeleccionado.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(318, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 280);
            this.dataGridView1.TabIndex = 16;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 354);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCancion);
            this.Controls.Add(this.cboCanciones);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblInterprete);
            this.Controls.Add(this.txtInterprete);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.lblAlbum);
            this.Controls.Add(this.txtAlbum);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.grbInterprete);
            this.Name = "frmPrincipal";
            this.Text = "ComboBox Canciones";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.grbInterprete.ResumeLayout(false);
            this.grbInterprete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCanciones;
        private System.Windows.Forms.Label lblCancion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInterprete;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtInterprete;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtAlbum;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.GroupBox grbInterprete;
        private System.Windows.Forms.Label lblInterpreteSeleccionado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

