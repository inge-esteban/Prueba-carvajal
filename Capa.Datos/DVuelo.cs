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
    public class DVuelo
    {
        private string conexion = ConfigurationManager.ConnectionStrings["VuelosCarbajal"].ToString();


        public IEnumerable<Vuelo> GetVuelos()
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                cn.Open();
                const string query = @"select * from vuelo";
                return cn.Query<Vuelo>(query, CommandType.Text).ToList();
            }
        }

        //Envio de datos
        public int PostVuelo(Vuelo vuelo)
        {
            const string query = @"insert into vuelo(CiudadOrigen, CiudadDestino, Fecha,HoraSalida,HoraLlegada,NumeroVuelo,Aerolinea,EstadoVuelo) 
                                   values(@CiudadOrigen, @CiudadDestino, @Fecha, @HoraSalida, @HoraLlegada,@NumeroVuelo,@Aerolinea,@EstadoVuelo)";


            using (SqlConnection cn = new SqlConnection(conexion))
            {
               return cn.Execute(query, new
                {
                    CiudadOrigen = vuelo.CiudadOrigen,
                    CiudadDestino = vuelo.CiudadDestino,
                    Fecha = vuelo.Fecha,
                    HoraSalida = vuelo.HoraSalida,
                    HoraLlegada = vuelo.HoraLlegada,
                    NumeroVuelo = vuelo.NumeroVuelo,
                    Aerolinea = vuelo.Aerolinea,
                    EstadoVuelo = vuelo.EstadoVuelo
                });
            }

        }

        public int PutVuelo(Vuelo vuelo)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                cn.Open();
                const string query = @"update vuelo set CiudadOrigen=@CiudadOrigen, CiudadDestino=@CiudadDestino,
                                       Fecha=@Fecha,HoraSalida=@HoraSalida,HoraLlegada=@HoraLlegada,NumeroVuelo=@NumeroVuelo,
                                        Aerolinea=@Aerolinea,EstadoVuelo=@EstadoVuelo
                                        where Id=@Id";
                return cn.Execute(query, new
                {   Id=vuelo.Id,
                    CiudadOrigen = vuelo.CiudadOrigen,
                    CiudadDestino = vuelo.CiudadDestino,
                    Fecha = vuelo.Fecha,
                    HoraSalida = vuelo.HoraSalida,
                    HoraLlegada = vuelo.HoraLlegada,
                    NumeroVuelo = vuelo.NumeroVuelo,
                    Aerolinea = vuelo.Aerolinea,
                    EstadoVuelo = vuelo.EstadoVuelo
                }, commandType: CommandType.Text);
            }
        }

        public int DeleteVuelo(int id)
        {
            using (SqlConnection cn = new SqlConnection(conexion))
            {
                cn.Open(); 
                const string query = @"Delete from vuelo where Id=@Id";
                return cn.Execute(query, new
                {
                    Id = id
                }, commandType: CommandType.Text);
            }
        }
    }
}
