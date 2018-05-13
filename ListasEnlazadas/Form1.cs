using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasEnlazadas
{
    public partial class Form1 : Form
    {
        Estructura catalog = new Estructura();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClaseBase nuevo;
            nuevo = new ClaseBase(txtProducto.Text, txtAlumno.Text,txtContacto.Text,txtVehiculo.Text);
            catalog.agregar(nuevo);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtInfo.Text = catalog.Listar();
        }

        private void btnEliminarPrimero_Click(object sender, EventArgs e)
        {
            catalog.eliminarPrimero();
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
            catalog.EliminarUltimo();
        }

        private void btnInvertirLista_Click(object sender, EventArgs e)
        {
            catalog.InvertirLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            catalog.ReporteInverso();
        }
    }
}
