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

namespace ListasConForms
{
    public partial class Frm_Factura : Form
    {
        private List<Producto> listaDePlatos;
        private List<Producto> listaDeBebidas;

        private Frm_Factura()
        {
            InitializeComponent();

        }

        public Frm_Factura(List<Producto> listaDePlatos, List<Producto> listaDeBebidas) : this()
        {
            this.listaDePlatos = listaDePlatos;
            this.listaDeBebidas = listaDeBebidas;
        }

        private void Frm_Factura_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = listaDePlatos;



        }
    }
}
