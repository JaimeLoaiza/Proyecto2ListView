using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Lista2_ListViewListadeDatos
{
    public partial class Form1 : Form
    {
        List<Productos> ListaProductos = new List<Productos>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnagregarproducto_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos();
            producto.Id = Convert.ToInt32(txtid.Text);
            producto.Nombre = txtnombreproducto.Text;
            producto.Valor = Convert.ToDecimal(txtvalor.Text);
            ListaProductos.Add(producto);
            txtvalor.Text = String.Empty;
            txtid.Text = String.Empty;
            txtnombreproducto.Text = String.Empty;
            MessageBox.Show("Producto agregado a la Lista de manera Exitosa");
        }
        private void btnlistadeproductos_Click(object sender, EventArgs e)
        {
            //Antes de llenar el ListView, limpiar el ListView(LISTA) para no llenarlo con información repetitiva
            LISTA.Items.Clear();
            foreach(Productos producto in ListaProductos)
            {
                ListViewItem item = new ListViewItem();
                item = LISTA.Items.Add(producto.Id.ToString());
                item.SubItems.Add(producto.Nombre);
                item.SubItems.Add(producto.Valor.ToString());
            }
        }
        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
