using Capa.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa.Presentacion
{
    public partial class ListaVuelos : Form
    {
        public ListaVuelos()
        {
            InitializeComponent();
        }

        private void ListaVuelos_Load(object sender, EventArgs e)
        {
            GetVuelos();
        }

        private void GetVuelos()
        {
            NVuelo vuelos = new NVuelo();
            DGVuelos.DataSource = vuelos.GetVuelos();
        }
    }
}
