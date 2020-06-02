using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8mc.Clases
{
    class Restaurant
    {
        private string nombreRest;
        private string nombreDueñoRest;
        private string numeroIdentificadorRest;



        private string horaAperturaRest;
        private string horaCierreRest;




        public Restaurant(string nombreRest, string nombreDueñoRest, string numeroIdentificadorRest, string horaAperturaRest, string horaCierreRest)
        {
            this.nombreRest = nombreRest;
            this.nombreDueñoRest = nombreDueñoRest;
            this.numeroIdentificadorRest = numeroIdentificadorRest;
            this.horaAperturaRest = horaAperturaRest;
            this.horaCierreRest = horaCierreRest;

        }
        public string NombreRest { get => nombreRest; set => nombreRest = value; }
        public string NombredueñoRest { get => nombreDueñoRest; set => nombreDueñoRest = value; }
        public string NumeroIdentifidorRest { get => numeroIdentificadorRest; set => numeroIdentificadorRest = value; }
        public string HoraCierreTienda { get => horaCierreRest; set => horaCierreRest = value; }
        public string HoraAperturaTienda { get => horaAperturaRest; set => horaAperturaRest = value; }
    }
}
