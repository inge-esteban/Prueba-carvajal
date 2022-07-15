using Capa.Datos;
using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Negocios
{
    public class NVuelo
    {
        private DVuelo dvuelos = new DVuelo();
        public IEnumerable<Vuelo> GetVuelos()
        {
            try
            {

                return dvuelos.GetVuelos();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int PostVuelo(Vuelo vuelo)
        {
            try
            {
                return dvuelos.PostVuelo(vuelo);
            }
            catch (Exception ex)
            {
                return 1;
            }
        }
        public int PutVuelo(Vuelo vuelo)
        {
            try
            {

                return dvuelos.PutVuelo(vuelo);
            }
            catch (Exception ex)
            {
                return 1;
            }
        }
        public int DeleteVuelo(int id)
        {
            try
            {

                return dvuelos.DeleteVuelo(id);
            }
            catch (Exception ex)
            {
                return 1;
            }
        }
    }
}
