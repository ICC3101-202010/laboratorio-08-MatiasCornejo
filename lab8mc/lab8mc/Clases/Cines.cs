using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8mc.Clases
{
    class Cines
    {
        private string nombreCine;
        private string nombreDueñoCine;
        private string numeroIdentificadorCine;
        private string horaAperturaCine;
        private string horaCierreCine;
        private string numSalasCine;




        public Cines(string nombreCine, string nombreDueñoCine, string numeroIdentificadorCine, string horaAperturaCine, string horaCierreCine, string numSalasCine)
        {
            this.nombreCine = nombreCine;
            this.nombreDueñoCine = nombreDueñoCine;
            this.numeroIdentificadorCine = numeroIdentificadorCine;
            this.HoraAperturaCine = HoraAperturaCine;
            this.HoraCierreCine = HoraCierreCine;
            this.NumSalasCine = numSalasCine;
        }
        public string NombreCine { get => nombreCine; set => nombreCine = value; }
        public string NombreDueñoCine { get => nombreDueñoCine; set => nombreDueñoCine = value; }
        public string NumeroIdentificadorCine { get => numeroIdentificadorCine; set => numeroIdentificadorCine = value; }
        public string HoraCierreCine { get => horaCierreCine; set => horaCierreCine = value; }
        public string HoraAperturaCine { get => horaAperturaCine; set => horaAperturaCine = value; }
        public string NumSalasCine { get => numSalasCine; set => numSalasCine = value; }
    }
}
