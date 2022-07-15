using Capa.Negocios;
using Capa.Entidades;
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
    public partial class Acceso : Form
    {
        public Acceso()
        {
            InitializeComponent();
        }

        private void txtContraseña_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Validar Campos


            Usuario usuario = new Usuario
            {
                Nombre = this.txtUsuario.Text.Trim(),
                Contraseña = this.txtContraseña.Text.Trim(),

            };
            NUsuario nUsuario = new NUsuario();

            switch (nUsuario.ValidarDatos(usuario))
            {
                case 0:
                    //Abrir pantalla admin
                    this.Hide();
                    Vuelos vuelos = new Vuelos();
                    vuelos.FormClosed +=(s,args)=>this.Close();
                    vuelos.Show();
                    break;
                case 1:
                    //Abrir pantall user
                    this.Hide();
                    ListaVuelos listVuelos = new ListaVuelos();
                    listVuelos.FormClosed += (s, args) => this.Close();
                    listVuelos.Show();
                    break;
                case 2:
                    MessageBox.Show("Usuario no encontrado");
                    //Mensaje de usuario no existe
                    break;
                case 3:
                    MessageBox.Show("Contraseña incorrecta");
                    //Contraseña equivocada
                    break;
            }


        }
    }
}
