using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Entidades
{
    public class Vuelo
    {
        public int Id { get; set; }
        public string CiudadOrigen { get; set; }
        public string CiudadDestino { get; set; }
        public DateTime Fecha { get; set; }
        public string HoraSalida { get; set; }
        public string HoraLlegada { get; set; }
        public int NumeroVuelo { get; set; }
        public string Aerolinea { get; set; }
        public string EstadoVuelo { get; set; }

    }
}
