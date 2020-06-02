using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8mc.Clases
{
    class Recreacion
    {
        private string nombreR;
        private string nombreDueñoR;
        private string numeroIdentificadorR;



        private string horaAperturaR;
        private string horaCierreR;




        public Recreacion(string nombreR, string nombreDueñoR, string numeroIdentificadorR, string horaAperturaR, string horaCierreR)
        {
            this.nombreR = nombreR;
            this.nombreDueñoR = nombreDueñoR;
            this.numeroIdentificadorR = numeroIdentificadorR;
            this.horaAperturaR = horaAperturaR;
            this.horaCierreR = horaCierreR;

        }
        public string NombreR { get => nombreR; set => nombreR = value; }
        public string NombredueñoR { get => nombreDueñoR; set => nombreDueñoR = value; }
        public string NumeroIdentifidorR { get => numeroIdentificadorR; set => numeroIdentificadorR = value; }
        public string HoraCierreR { get => horaCierreR; set => horaCierreR = value; }
        public string HoraAperturaR { get => horaAperturaR; set => horaAperturaR = value; }
    }
}
