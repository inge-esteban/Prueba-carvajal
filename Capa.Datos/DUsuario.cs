using Capa.Entidades;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Datos
{
    public class DUsuario
    {
        private string conexion = ConfigurationManager.ConnectionStrings["VuelosCarbajal"].ToString();
        public Usuario GetUsuario(string Nombre)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                try
                {
                cn.Open();
                string query = @"select * from usuario where Nombre = '" + Nombre+"'";
                return cn.Query<Usuario>(query, CommandType.Text).First();
                }catch (Exception ex)
                {
                    return null;
                }
            }
        }
    }
}
