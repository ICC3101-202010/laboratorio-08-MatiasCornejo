using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Clases
{
     public class Tiendas
    {

        private string nombreTienda;
        private string nombreDueño;
        private string numeroIdentificador;
        private string horaAperturaTienda;
        private string horaCierreTienda;


       

        public Tiendas(string nombreTienda, string nombreDueño, string numeroIdentificador,string horaAperturaTienda,string horaCierreTienda)
        {
            this.nombreTienda = nombreTienda;
            this.nombreDueño = nombreDueño;
            this.numeroIdentificador = numeroIdentificador;
            this.HoraAperturaTienda = HoraAperturaTienda;
            this.HoraCierreTienda = HoraCierreTienda;

        }
        public string NombreTienda { get => nombreTienda; set => nombreTienda = value; }
        public string NombreDueño { get => nombreDueño; set => nombreDueño = value; }
        public string NumeroIdentificador { get => numeroIdentificador; set => numeroIdentificador = value; }
        public string HoraCierreTienda { get => horaCierreTienda; set => horaCierreTienda = value; }
        public string HoraAperturaTienda { get => horaAperturaTienda; set => horaAperturaTienda = value; }
    }
}
