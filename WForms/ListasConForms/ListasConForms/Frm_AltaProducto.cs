using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
namespace ListasConForms
{
    public partial class Frm_AltaProducto : Form
    {
        public Frm_AltaProducto()
        {
            InitializeComponent();
        }
        private Producto producto;

        public Producto Producto { get => producto;}

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
           this.DialogResult = DialogResult.OK;

           


        }




        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}
