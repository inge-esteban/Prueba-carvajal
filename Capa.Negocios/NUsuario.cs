using Capa.Datos;
using Capa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Negocios
{
    public class NUsuario
    {
        DUsuario datosUsuario = new DUsuario();
        string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        public int ValidarDatos(Usuario usuario)
        {
            try
            {

                Usuario _usuario = datosUsuario.GetUsuario(usuario.Nombre);

                if (_usuario == null)
                {
                    return 2;
                }

                _usuario.Nombre = _usuario.Nombre.Trim();
                _usuario.Contraseña = _usuario.Contraseña.Trim();
                _usuario.Rol = _usuario.Rol.Trim();

                if (usuario.Nombre == _usuario.Nombre &&
                    usuario.Contraseña == _usuario.Contraseña)
                {
                    switch (_usuario.Rol)
                    {
                        case "adm":
                            return 0;
                            break;
                        case "user":
                            return 1;
                            break;
                    }
                }
                else if (usuario.Nombre == null || usuario.Nombre != _usuario.Nombre)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
                return 2;

            }
            catch (Exception ex)
            {
                return 2;
            }
        }
    }
}
