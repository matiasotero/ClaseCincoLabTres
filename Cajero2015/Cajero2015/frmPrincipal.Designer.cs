namespace Cajero2015
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
            this.grbCantidad = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.grbBilletes = new System.Windows.Forms.GroupBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt10 = new System.Windows.Forms.TextBox();
            this.txt20 = new System.Windows.Forms.TextBox();
            this.txt50 = new System.Windows.Forms.TextBox();
            this.txt100 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbCantidad.SuspendLayout();
            this.grbBilletes.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCantidad
            // 
            this.grbCantidad.Controls.Add(this.txtCantidad);
            this.grbCantidad.Controls.Add(this.lblCantidad);
            this.grbCantidad.Location = new System.Drawing.Point(21, 12);
            this.grbCantidad.Name = "grbCantidad";
            this.grbCantidad.Size = new System.Drawing.Size(252, 57);
            this.grbCantidad.TabIndex = 0;
            this.grbCantidad.TabStop = false;
            this.grbCantidad.Text = "Cantidad a Retirar";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(122, 26);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(117, 20);
            this.txtCantidad.TabIndex = 0;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCantidad.Location = new System.Drawing.Point(6, 27);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(110, 16);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Cantidad a retirar";
            // 
            // grbBilletes
            // 
            this.grbBilletes.Controls.Add(this.txt2);
            this.grbBilletes.Controls.Add(this.txt5);
            this.grbBilletes.Controls.Add(this.txt10);
            this.grbBilletes.Controls.Add(this.txt20);
            this.grbBilletes.Controls.Add(this.txt50);
            this.grbBilletes.Controls.Add(this.txt100);
            this.grbBilletes.Controls.Add(this.label7);
            this.grbBilletes.Controls.Add(this.label6);
            this.grbBilletes.Controls.Add(this.label5);
            this.grbBilletes.Controls.Add(this.label4);
            this.grbBilletes.Controls.Add(this.label3);
            this.grbBilletes.Controls.Add(this.label2);
            this.grbBilletes.Location = new System.Drawing.Point(21, 76);
            this.grbBilletes.Name = "grbBilletes";
            this.grbBilletes.Size = new System.Drawing.Size(252, 321);
            this.grbBilletes.TabIndex = 1;
            this.grbBilletes.TabStop = false;
            this.grbBilletes.Text = "Cantidad de Billetes";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(122, 28);
            this.txt2.Name = "txt2";
            this.txt2.ReadOnly = true;
            this.txt2.Size = new System.Drawing.Size(117, 20);
            this.txt2.TabIndex = 6;
            this.txt2.TabStop = false;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(122, 77);
            this.txt5.Name = "txt5";
            this.txt5.ReadOnly = true;
            this.txt5.Size = new System.Drawing.Size(117, 20);
            this.txt5.TabIndex = 7;
            this.txt5.TabStop = false;            
            // 
            // txt10
            // 
            this.txt10.Location = new System.Drawing.Point(122, 126);
            this.txt10.Name = "txt10";
            this.txt10.ReadOnly = true;
            this.txt10.Size = new System.Drawing.Size(117, 20);
            this.txt10.TabIndex = 8;
            this.txt10.TabStop = false;
            // 
            // txt20
            // 
            this.txt20.Location = new System.Drawing.Point(122, 175);
            this.txt20.Name = "txt20";
            this.txt20.ReadOnly = true;
            this.txt20.Size = new System.Drawing.Size(117, 20);
            this.txt20.TabIndex = 9;
            this.txt20.TabStop = false;
            // 
            // txt50
            // 
            this.txt50.Location = new System.Drawing.Point(122, 224);
            this.txt50.Name = "txt50";
            this.txt50.ReadOnly = true;
            this.txt50.Size = new System.Drawing.Size(117, 20);
            this.txt50.TabIndex = 10;
            this.txt50.TabStop = false;
            // 
            // txt100
            // 
            this.txt100.Location = new System.Drawing.Point(122, 273);
            this.txt100.Name = "txt100";
            this.txt100.ReadOnly = true;
            this.txt100.Size = new System.Drawing.Size(117, 20);
            this.txt100.TabIndex = 11;
            this.txt100.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(15, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Billete de $ 100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(15, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Billete de $ 50";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(15, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Billete de $ 20";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(15, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Billete de $ 10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(15, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Billete de $ 5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Billete de $ 2";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(326, 94);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(99, 27);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(326, 157);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(99, 27);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(326, 220);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 27);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 416);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grbCantidad);
            this.Controls.Add(this.grbBilletes);
            this.Name = "frmPrincipal";
            this.Text = "Cajero Automático";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbCantidad.ResumeLayout(false);
            this.grbCantidad.PerformLayout();
            this.grbBilletes.ResumeLayout(false);
            this.grbBilletes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.GroupBox grbBilletes;
        private System.Windows.Forms.TextBox txt100;
        private System.Windows.Forms.TextBox txt50;
        private System.Windows.Forms.TextBox txt20;
        private System.Windows.Forms.TextBox txt10;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}

