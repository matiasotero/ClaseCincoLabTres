using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploComboBox
{
    public partial class frmPrincipal : Form
    {

        private List<Cancion> _lista;
        private Cancion _cancionElegida;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private List<Cancion> generarListadoCanciones()
        {
            List<Cancion> lista = new List<Cancion>();

            lista.Add(new Cancion("Hello", "Adele", new Duration(4,55), "Soul", 2015, "Adelle 25"));
            lista.Add(new Cancion("Highway to Hell", "ACDC", new Duration(4, 44), "Hard Rock", 1979, "Highway to Hell"));
            lista.Add(new Cancion("Sugar", "Maroon 5", new Duration(5, 2), "Pop", 2014, "Adelle 25"));
            lista.Add(new Cancion("UpTown Funk", "Mark Ronson", new Duration(4, 31), "Funk", 2014, "UpTown Funk"));
            lista.Add(new Cancion("Loquita", "Marama", new Duration(2, 31), "Cumbia", 2015, "Todo Comenzo Bailando"));
            lista.Add(new Cancion("Shake It Off", "Taylor Swift", new Duration(4, 55), "Pop", 2015, "1989"));            return lista;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
            this.ConfigurarCombo();
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.DataSource = this._lista;


        }

        private void ConfigurarCombo()
        {
            this._lista = this.generarListadoCanciones();            

            //this.CargarCombo();

            this.cboCanciones.DataSource = this._lista;

            // con display member indicamos cual es el atributo que queremos que se muestre en el comboBox
            this.cboCanciones.DisplayMember = "Titulo";

            this.cboCanciones.ValueMember = "Interprete";

            


        }

        private void cboCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Con la propiedad selectedItem obtengo el objeto seleccionado en el combo (como Object) por eso para usarlo debo castearlo
            this._cancionElegida = (Cancion) this.cboCanciones.SelectedItem;

            // Cargo los textBox con las propiedades del objeto cancion
            this.txtTitulo.Text = this._cancionElegida.Titulo;
            this.txtInterprete.Text = this._cancionElegida.Interprete;
            this.txtDuracion.Text = this._cancionElegida.Duracion.ToString();
            this.txtAño.Text = this._cancionElegida.Año.ToString();
            this.txtGenero.Text = this._cancionElegida.Genero;
            this.txtAlbum.Text = this._cancionElegida.Album;

            if(this.cboCanciones.SelectedValue != null)
            this.lblInterpreteSeleccionado.Text = this.cboCanciones.SelectedValue.ToString();

          
        }

        private void CargarCombo()
        {
            // Recorro con un foreach la lista de canciones y las cargo en la lista (Items) del comboBox
            foreach (Cancion unaCancion in this._lista)
            {
                this.cboCanciones.Items.Add(unaCancion);
            }
            // Para que el combo muestre algo le digo que el indice seleccionado es el 0
            this.cboCanciones.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //this.cboCanciones.ValueMember = "Interprete";
            this.cboCanciones.SelectedValue = "Maroon 5";
            //this.cboCanciones.SelectedIndex = 2;
        }
    }
}
