using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cajero2015
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.IconoUTN;

            this.btnAceptar.Click += new EventHandler(this.Calcular);
        }

        private void Calcular(object sender, EventArgs e)
        {
            float valor;
            if (float.TryParse(this.txtCantidad.Text, out valor))
            {

                this.txt100.Text = ((int)(valor / 100)).ToString();

                valor -= float.Parse(this.txt100.Text) * 100;

                this.txt50.Text = ((int)(valor / 50)).ToString();

                valor -= float.Parse(this.txt50.Text) * 50;

                this.txt20.Text = ((int)(valor / 20)).ToString();

                valor -= float.Parse(this.txt20.Text) * 20;

                this.txt10.Text = ((int)(valor / 10)).ToString();

                valor -= float.Parse(this.txt10.Text) * 10;

                this.txt5.Text = ((int)(valor / 5)).ToString();

                valor -= float.Parse(this.txt5.Text) * 5;

                this.txt2.Text = ((int)(valor / 2)).ToString();

                valor -= float.Parse(this.txt2.Text) * 2;

                if (valor != 0)
                    MessageBox.Show("Le queda $ " + valor + " Peso", "Vuelto");

                this.btnAceptar.Click -= new EventHandler(this.Calcular);
                this.btnAceptar.Click += new EventHandler(this.Informar);

                this.btnLimpiar.Click += new EventHandler(this.Limpiar);
            }
            else
            {

                MessageBox.Show("Debe ingresar una cantidad", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtCantidad.Clear();
                this.txtCantidad.Focus();

            }
        }

        private void Informar(object sender, EventArgs e)
        {
            MessageBox.Show("Debe limpiar la pantalla para seguir operando", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Limpiar(object sender, EventArgs e)
        {

            this.btnAceptar.Click += new EventHandler(this.Calcular);
            this.btnAceptar.Click -= new EventHandler(this.Informar);
            this.btnLimpiar.Click -= new EventHandler(this.Limpiar);

            foreach (Control unControl in this.Controls)
            {
                if (unControl is GroupBox)
                {
                    foreach (Control otroControl in unControl.Controls)
                    {
                        if (otroControl is TextBox)
                        {
                            ((TextBox)otroControl).Clear();
                        }
                    }
                }
            }

            this.txtCantidad.Clear();
        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Confirma Salir de la aplicación", "Confirmacíon", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
