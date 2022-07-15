using Capa.Entidades;
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
    public partial class Vuelos : Form
    {
        string _accion = "";
        int _id = 0;
        DataGridViewRow row;
        public Vuelos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void DGVuelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtHoraSalida_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetVuelos();
            DesactivarCajas();
            DesabilitarBotonesGuardado();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _accion = "nuevo";
            DesabilitarBotonesOperaciones();
            ActivarCajas();
            HabilitarBotonesGuardado();
        }


        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Validar campos



            switch (_accion)
            {
                case "nuevo":
                    GuardaNuevoVuelo();
                    break;
                case "editar":
                    ActualizarVuelo();
                    break;

            }
            LimpiarCajas();
            DesactivarCajas();
            HabilitarBotonesOperaciones();
            DesabilitarBotonesGuardado();

        }

        private void GuardaNuevoVuelo()
        {
            Vuelo vuelo = new Vuelo
            {

                CiudadDestino = this.txtCiudadDestino.Text,
                CiudadOrigen = this.txtCiudadOrigen.Text,
                HoraSalida = this.txtHoraSalida.Text + ":" + this.txtMinutoSalida.Text,
                HoraLlegada = this.txtHoraLlegada.Text + ":" + this.txtMinutoLlegada.Text,
                NumeroVuelo = int.Parse(this.txtNumeroVuelo.Text),
                Aerolinea = this.txtAerolinea.Text,
                EstadoVuelo = this.TextEstadoVuelo.Text,

                Fecha = new DateTime(this.DTFecha.Value.Year, this.DTFecha.Value.Month, this.DTFecha.Value.Day)


            };

            NVuelo nVuelo = new NVuelo();
            int resp = nVuelo.PostVuelo(vuelo);
            if (resp == 0)
            {
                MessageBox.Show("Se octuvo un error en el sistema");
            }
            else
            {
                MessageBox.Show("Los datos de han guardado");
            }
            GetVuelos();
        }
        private void ActualizarVuelo()
        {
            Vuelo vuelo = new Vuelo
            {
                Id = _id,
                CiudadDestino = this.txtCiudadDestino.Text,
                CiudadOrigen = this.txtCiudadOrigen.Text,
                HoraSalida = this.txtHoraSalida.Text + ":" + this.txtMinutoSalida.Text,
                HoraLlegada = this.txtHoraLlegada.Text + ":" + this.txtMinutoLlegada.Text,
                NumeroVuelo = int.Parse(this.txtNumeroVuelo.Text),
                Aerolinea = this.txtAerolinea.Text,
                EstadoVuelo = this.TextEstadoVuelo.Text,

                Fecha = new DateTime(this.DTFecha.Value.Year, this.DTFecha.Value.Month, this.DTFecha.Value.Day)


            };

            NVuelo nVuelo = new NVuelo();
            int resp = nVuelo.PutVuelo(vuelo);
            if (resp == 0)
            {
                MessageBox.Show("Se octuvo un error en el sistema");
            }
            else
            {
                MessageBox.Show("Los datos de han guardado");
            }
            GetVuelos();
        }
        private void GetVuelos()
        {
            NVuelo vuelos = new NVuelo();
            DGVuelos.DataSource = vuelos.GetVuelos();
        }




        private void LimpiarCajas()
        {
            this.DTFecha.Text = "";
            this.txtCiudadDestino.Text = "";
            this.txtCiudadOrigen.Text = "";
            this.txtHoraSalida.Text = "";
            this.txtMinutoSalida.Text = "";
            this.txtHoraLlegada.Text = "";
            this.txtMinutoLlegada.Text = "";
            this.txtNumeroVuelo.Text = "";
            this.txtAerolinea.Text = "";
            this.TextEstadoVuelo.Text = "";
        }
        private void DesactivarCajas()
        {
            this.DTFecha.Enabled = false;
            this.txtCiudadDestino.Enabled = false;
            this.txtCiudadOrigen.Enabled = false;
            this.txtHoraSalida.Enabled = false;
            this.txtMinutoSalida.Enabled = false;
            this.txtHoraLlegada.Enabled = false;
            this.txtMinutoLlegada.Enabled = false;
            this.txtNumeroVuelo.Enabled = false;
            this.txtAerolinea.Enabled = false;
            this.TextEstadoVuelo.Enabled = false;
        }
        private void ActivarCajas()
        {
            this.DTFecha.Enabled = true;
            this.txtCiudadDestino.Enabled = true;
            this.txtCiudadOrigen.Enabled = true;
            this.txtHoraSalida.Enabled = true;
            this.txtMinutoSalida.Enabled = true;
            this.txtHoraLlegada.Enabled = true;
            this.txtMinutoLlegada.Enabled = true;
            this.txtNumeroVuelo.Enabled = true;
            this.txtAerolinea.Enabled = true;
            this.TextEstadoVuelo.Enabled = true;
        }
        private void DesabilitarBotonesOperaciones()
        {
            this.btnEditar.Enabled = false;
            this.btnNuevo.Enabled = false;
            this.btnEliminar.Enabled = false;
        }
        private void HabilitarBotonesOperaciones()
        {
            this.btnEditar.Enabled = true;
            this.btnNuevo.Enabled = true;
            this.btnEliminar.Enabled = true;
        }

        private void DesabilitarBotonesGuardado()
        {
            this.btnCancelar.Enabled = false;
            this.BtnGuardar.Enabled = false;
        }
        private void HabilitarBotonesGuardado()
        {
            this.btnCancelar.Enabled = true;
            this.BtnGuardar.Enabled = true;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
            DesactivarCajas();
            HabilitarBotonesOperaciones();
            DesabilitarBotonesGuardado();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (_id > 0)
            {

                _accion = "editar";
                DesabilitarBotonesOperaciones();
                ActivarCajas();
                HabilitarBotonesGuardado();


                this.DTFecha.Text = row.Cells["Fecha"].Value.ToString();
                this.txtCiudadDestino.Text = row.Cells["CiudadDestino"].Value.ToString();
                this.txtCiudadOrigen.Text = row.Cells["CiudadOrigen"].Value.ToString();
                /*  this.txtHoraSalida.Text = row.Cells["HoraSalida"].Value.ToString();
                  this.txtMinutoSalida.Text = row.Cells["MinutoSalida"].Value.ToString();
                  this.txtHoraLlegada.Text = row.Cells["HoraLlegada"].Value.ToString();
                  this.txtMinutoLlegada.Text = row.Cells["MinutoLlegada"].Value.ToString(); */
                this.txtNumeroVuelo.Text = row.Cells["NumeroVuelo"].Value.ToString();
                this.txtAerolinea.Text = row.Cells["Aerolinea"].Value.ToString();
                this.TextEstadoVuelo.Text = row.Cells["EstadoVuelo"].Value.ToString();

            }
        }

        private void DGVuelos_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                row = this.DGVuelos.Rows[e.RowIndex];
                _id = int.Parse(row.Cells["Id"].Value.ToString());
            }
            catch (Exception)
            {

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quieres eliminar este vuelo?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                NVuelo nvueno = new NVuelo();
                nvueno.DeleteVuelo(_id);
                GetVuelos();
            }
            else
            {

            }
        }
    }
}
