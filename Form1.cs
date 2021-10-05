using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Te_juzgo_el_helado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSabores.Items.Add("Banana Split");
            cmbSabores.Items.Add("Bananita Dolca");
            cmbSabores.Items.Add("Chocolate");
            cmbSabores.Items.Add("Chocolate con almendras");
            cmbSabores.Items.Add("Crema cookie");
            cmbSabores.Items.Add("Crema del cielo");
            cmbSabores.Items.Add("Durazno");
            cmbSabores.Items.Add("Frutilla");
            cmbSabores.Items.Add("Granizado");
            cmbSabores.Items.Add("Limón");
            cmbSabores.Items.Add("Marroc");
            cmbSabores.Items.Add("Papa frita");
            cmbSabores.Items.Add("Quinotos al Whisky");
            cmbSabores.Items.Add("Vainilla");
            cmbSabores.Items.Add("Otro");
        }

        private void cmbSabores_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btJuzgar_Click(object sender, EventArgs e)
        {
            if (cmbSabores.Text== "Banana Split")
            {
                lblResultado.Text = "???????";
            }
            if (cmbSabores.Text == "Bananita Dolca")
            {
                lblResultado.Text = "No sé si existe pero si sabes donde hay por favor llevame.";
            }
            if (cmbSabores.Text == "Chocolate")
            {
                lblResultado.Text = "No salís de tu zona de confort, deberías arriesgarte más.";
            }
            if (cmbSabores.Text == "Chocolate con almendras")
            {
                lblResultado.Text = "Respetable.";
            }
            if (cmbSabores.Text == "Crema cookie")
            {
                lblResultado.Text = "Trolazo, pero same bro.";
            }
            if (cmbSabores.Text == "Crema del cielo")
            {
                lblResultado.Text = "Sos fan de las películas disney. Sobre todo de Mulan.";
            }
            if (cmbSabores.Text == "Durazno")
            {
                lblResultado.Text = "Alguien fresco, seguro lo pedís con otros 3 sabores frutales.";
            }
            if (cmbSabores.Text == "Frutilla")
            {
                lblResultado.Text = "Te diría algo pero la verdad suficiente triste tiene que ser tu vida para que eso sea tu sabor favorito.";
            }
            if (cmbSabores.Text == "Granizado")
            {
                lblResultado.Text = "Casate conmigo por favor no importa que yo sea un programa y vos un humano.";
            }
            if (cmbSabores.Text == "Limón")
            {
                lblResultado.Text = "Te gustaba más el helado de limon de antes pero aún así te gusta.";
            }
            if (cmbSabores.Text == "Marroc")
            {
                lblResultado.Text = "Eso es trampa, todos amamos el Marroc. (Espacio no auspiciado por Felfort)";
            }
            if (cmbSabores.Text == "Papa frita")
            {
                lblResultado.Text = "No existe, pero debería.";
            }
            if (cmbSabores.Text == "Quinotos al Whisky")
            {
                DecidisteMal DecidisteMall = new DecidisteMal();
                DecidisteMall.Show();
                this.Hide();
                //this.Dispose();
            }
            if (cmbSabores.Text == "Vainilla")
            {
                lblResultado.Text = "O sos muy tranquilo o tenés 4 años.";
            }
            if (cmbSabores.Text == "Otro")
            {
                lblResultado.Text = "Bueno no hay más, conformate y elegí de la lista que te doy, no me pagan lo suficiente para esto";
            }
        }

       
    }
}
