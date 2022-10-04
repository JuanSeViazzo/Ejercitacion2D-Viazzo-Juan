using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ListasConForms
{
    public partial class Frm_Restaurante : Form
    {
        List<Producto> listaDePlatos;
        List<Producto> listaDeBebidas;

        public Frm_Restaurante()
        {
            InitializeComponent();
            listaDeBebidas = new List<Producto>();
            listaDePlatos = new List<Producto>();
        }

        private void btn_CrearProducto_Click(object sender, EventArgs e)
        {
            DialogResult validacion;

            Frm_AltaProducto formAbm = new Frm_AltaProducto();

            formAbm.Text = "Formulario De Alta Producto";

            validacion = formAbm.ShowDialog();
          


            if (validacion == DialogResult.OK)
            {
                Producto producto = formAbm.Producto;   

                
            }

            MessageBox.Show(listaDePlatos.Count.ToString());

        }

        private void btn_FinalizarCompra_Click(object sender, EventArgs e)
        {
            Frm_Factura factura = new Frm_Factura(listaDePlatos, listaDeBebidas);

            factura.ShowDialog();


        }
    }
























}
