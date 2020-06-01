using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        List<string> listlocales = new List<string>();
        
        List<string> listId = new List<string>();




        List<string> listnombredueñostiendas= new List<string>();
        List<string> listnombredueñoscine = new List<string>();
        List<string> listnombredueñosrestaruante = new List<string>();
        List<string> listnombredueñosrecreaciones = new List<string>();

        List<string> listinformaciontiendas = new List<string>();

        

      



        private void button1_Click(object sender, EventArgs e)
        {
            panelListaLocales.Visible = true;
            listLocales.Items.Add("hola");
            listLocales.Items.Add("");
            listLocales.Items.Add("fsdnasjkfaskj");

            
            

            


        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarLocal_Click(object sender, EventArgs e)
        {
            panelAgregarLocal.Visible = true;

        }

        private void btnVolverDeELegirtipoDeLocal_Click(object sender, EventArgs e)
        {
            panelAgregarLocal.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(string x in listlocales)
            {
                listLocales.Items.Add(x);
            }
            panelListaLocales.Visible = true;
            

        }

        private void btnTienda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rellene los siguientes datos");
            panelRegistroNuevTienda.Visible = true;

            }

        public class nombrestiendas
        {
        }

        private void listLocales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFinalizarCreacionTienda_Click(object sender, EventArgs e)
        {
            
            bool a =true;
            string nombretienda = txtNombreTienda.Text;
            string dueño = txtnombredueño.Text;
            
            string id = txtIdTienda.Text;

            string horaAperturaTienda = txtHoraAperturatienda.Text;
            string horaCierreTienda = txtHoraCierrreTienda.Text;

            if (txtNombreTienda.Text == "" || txtnombredueño.Text == "" || txtIdTienda.Text == "" || txtHoraAperturatienda.Text == "" || txtHoraCierrreTienda.Text == "")
            {
                MessageBox.Show("Rellene todos los datos para poder continuar");

            }
            



            else
            {
               
                Clases.Tiendas tienda1 = new Clases.Tiendas(nombretienda, dueño, id, horaAperturaTienda, horaCierreTienda);
                MessageBox.Show("estamos");
                string inftiendas;
                listlocales.Add(tienda1.NombreTienda);
                panelAgregarLocal.Visible = false;
                panelRegistroNuevTienda.Visible = false;
                inftiendas = "Nombre tienda = "+tienda1.NombreTienda+"Nombre Dueño= "+tienda1.NombreDueño;

                listinformaciontiendas.Add(inftiendas);
               
                
            }


              

        }

        private void btnCine_Click(object sender, EventArgs e)
        {

        }

        private void btnagregarnuevocine_Click(object sender, EventArgs e)
        {
            bool a = true;
            string nombre = txtNombreCine.Text;
            string dueño = txtnombreDueñoCine.Text;

            string id = txtIdCine.Text;

            string horaApertura = txtHoraaperturacine.Text;
            string horaCierre = txtHoracierreCine.Text;

            if (txtNombreCine.Text == "" || txtnombreDueñoCine.Text == "" || txtIdCine.Text == "" |txtHoraaperturacine.Text=="" || txtHoracierreCine.Text == "")
            {
                MessageBox.Show("Rellene todos los datos para poder continuar");

            }




            else
            {

                Clases.Cines cine1 = new Clases.Cines(nombre, dueño, id, horaApertura, horaCierre);
                
                string inftiendas;
                listlocales.Add(cine1.NombreCine);
                panelAgregarLocal.Visible = false;
                
             
                inftiendas = "Nombre Cine = " + cine1.NombreCine + "Nombre Dueño= " + cine1.NombreDueñoCine;

                listinformaciontiendas.Add(inftiendas);


            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNombreCine_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
















