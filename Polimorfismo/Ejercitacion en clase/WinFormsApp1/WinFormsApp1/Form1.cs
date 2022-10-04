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

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Guerrero? guerrero;
        Arma? espada;
        Arma? hacha;
        Arma? arco;


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            hacha = new Hacha(100, 200, "Double Axe", "Doble hoja", 70);
            espada = new Espada(85, 180, "Gigant Sword", "Critical", 50);
            arco = new Arco(60, 150, "Elf Bow", "Cazador", 30);

            Personaje guerrero = new Guerrero("Juan", 500);
        }

        private void btnHacha_Click(object sender, EventArgs e)
        {

            guerrero.miArma = hacha;
            

        }

        private void btnEspada_Click(object sender, EventArgs e)
        {
            guerrero.miArma = espada;  
        }

        private void btnAtacar_Click(object sender, EventArgs e)
        {
            guerrero.miArma.Ataque();
        }
    }
}
