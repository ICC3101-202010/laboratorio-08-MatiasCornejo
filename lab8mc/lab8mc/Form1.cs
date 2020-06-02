using lab8mc.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8mc
{
    public partial class Form1 : Form
    {
        List<string> listlocales = new List<string>();
        List<string> listinftiendas = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarNuevoLocal_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombretienda = txtNombreTienda.Text;
            string dueño = txtnombredueño.Text;

            string id = txtIdTienda.Text;

            string horaAperturaTienda = txtHoraAperturatienda.Text;
            string horaCierreTienda = txtHoraCierrreTienda.Text;

            

            

            if (txtNombreTienda.Text == "" || txtnombredueño.Text == "" || txtIdTienda.Text == "" || txtHoraAperturatienda.Text == "" || txtHoraCierrreTienda.Text == "")
            {
                MessageBox.Show("Rellene todos los datos para poder continuar");

            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton4.Checked == false && radioButton5.Checked == false)
            {
                MessageBox.Show("Escoja una de las tiendas que desea crear");
            }
            else if (radioButton1.Checked == true)
            {
                
                Clases.Tiendas tienda1 = new Clases.Tiendas(nombretienda, dueño, id, horaAperturaTienda, horaCierreTienda);

                string inftiendas;
                listlocales.Add(tienda1.NombreTienda);

                inftiendas = "Nombre tienda  = " + tienda1.NombreTienda + "Nombre Dueño= " + tienda1.NombreDueño + "id=" + tienda1.NumeroIdentificador + "Hora de apertura: " + tienda1.HoraAperturaTienda + "Hora de cierre: " + tienda1.HoraCierreTienda;
                listinftiendas.Add(inftiendas);
                MessageBox.Show("Tienda creada con exito!!");
                txtHoraAperturatienda.Text = "";
                txtHoraCierrreTienda.Text = "";
                txtnombredueño.Text = "";
                txtIdTienda.Text = "";
                txtNombreTienda.Text = "";

                panel1.Visible = false;


            }
            else if (radioButton2.Checked == true)
            {
                Clases.Recreacion recreacion1 = new Clases.Recreacion(nombretienda, dueño, id, horaAperturaTienda, horaCierreTienda);
                listlocales.Add(recreacion1.NombreR);
                string infrecreacion = "Nombre Recreacion  = " + recreacion1.NombreR + "Nombre Dueño= " + recreacion1.NombredueñoR + "id=" + recreacion1.NumeroIdentifidorR + "Hora de apertura: " + recreacion1.HoraAperturaR + "Hora de cierre: " + recreacion1.HoraCierreR;
                listinftiendas.Add(infrecreacion);
                MessageBox.Show("Tienda de recrecion creada con exito!!");

                txtHoraAperturatienda.Text = "";
                txtHoraCierrreTienda.Text = "";
                txtnombredueño.Text = "";
                txtIdTienda.Text = "";
                txtNombreTienda.Text = "";

                panel1.Visible = false;
            }





            else if (radioButton4.Checked == true)
            {
                panel3.Visible = true;
                string numSalasCine;
                numSalasCine = txtCantidadSalas.Text;
                Clases.Cines cine1 = new Clases.Cines(nombretienda, dueño, id, horaAperturaTienda, horaCierreTienda,numSalasCine);

                listlocales.Add(cine1.NombreCine);
                string infcines = "Nombre cine  = " + cine1.NombreCine + "Nombre Dueño= " + cine1.NombreDueñoCine + "id=" + cine1.NumeroIdentificadorCine + "Hora de apertura: " + cine1.HoraAperturaCine + "Hora de cierre: " + cine1.HoraCierreCine+"Numero de salas:"+cine1.NumSalasCine;
                listinftiendas.Add(infcines);
                
                txtHoraAperturatienda.Text = "";
                txtHoraCierrreTienda.Text = "";
                txtnombredueño.Text = "";
                txtIdTienda.Text = "";


                txtNombreTienda.Text = "";
                panel1.Visible = false;

            }
            else if (radioButton5.Checked == true)
            {
                Clases.Restaurant restaurant1 = new Clases.Restaurant(nombretienda, dueño, id, horaAperturaTienda, horaCierreTienda);
                listlocales.Add(restaurant1.NombreRest);
                string infrestaurant = "Nombre Restaurant  = " + restaurant1.NombreRest + "Nombre Dueño= " + restaurant1.NombredueñoRest + "id=" + restaurant1.NumeroIdentifidorRest + "Hora de apertura: " + restaurant1.HoraAperturaTienda + "Hora de cierre: " + restaurant1.HoraCierreTienda;
                listinftiendas.Add(infrestaurant);
                MessageBox.Show("Restaurant creado con exito!!");
                txtHoraAperturatienda.Text = "";
                txtHoraCierrreTienda.Text = "";
                txtnombredueño.Text = "";
                txtIdTienda.Text = "";
                txtNombreTienda.Text = "";


                panel1.Visible = false;

            }
        }

        private void btnLocales_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            listBox1.Items.Add("LISTA DE TIENDAS:");
            listBox1.Items.Add("");
            listBox1.Items.Add("");
            listBox1.Items.Add("");
            int s = 1;
            foreach(string x in listlocales)
            {
                string d = Convert.ToString(s);
                listBox1.Items.Add(d+") "+x);
                listBox1.Items.Add("");
                s += 1;
            }
        }

        private void btnRevisarInformacion_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            listBox1.Items.Add("INFORMACION DE TIENDAS :");
            listBox1.Items.Add("");
            listBox1.Items.Add("");
            listBox1.Items.Add("");
            int s = 1;
            foreach (string x in listinftiendas)
            {
                string d = Convert.ToString(s);
                listBox1.Items.Add(d + ") " + x);
                listBox1.Items.Add("");
                s += 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            listBox1.Items.Clear();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtCantidadSalas.Text == "")
            {
                MessageBox.Show("INGRESE LA CANTIDAD DE SALAS");
            }
            else
            {
                
                MessageBox.Show("TIENDA CREADA CON EXITO");
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
            }
        }
    }
}
