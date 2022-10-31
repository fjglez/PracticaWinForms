using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaForms
{
    internal class Repositorio
    {
        public static DataSet ObtenerJuegos()
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "SELECT * FROM Juegos";
            return RealizarConsulta(comando);
        }

        public static DataSet ObtenerGeneros()
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "SELECT DISTINCT genero FROM Juegos";
            return RealizarConsulta(comando);
        }
        public static DataSet RealizarConsulta(SqlCommand comando)
        {
            Conexion conexion = new Conexion();
            DataSet ds = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter();

            try
            {
                comando.Connection = conexion.cnx;
                adaptador.SelectCommand = comando;
                conexion.cnx.Open();
                adaptador.Fill(ds);
                conexion.cnx.Close();

                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ds;
        }

        public static bool RealizarComando(SqlCommand comando)
        {
            bool todoCorrecto = false;
            Conexion conexion = new Conexion();

            try
            {
                comando.Connection = conexion.cnx;
                conexion.cnx.Open();
                comando.ExecuteNonQuery();
                conexion.cnx.Close();

                todoCorrecto = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                todoCorrecto = false;
            }

            return todoCorrecto;
        }

        internal static bool CrearJuego(Juego j)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "INSERT INTO Juegos VALUES ('" + j.titulo + "', '" + j.fechaSalida + "', '" + 
                                    j.ventas + "', '" + j.genero + "', '" + j.precio + "')";
            return RealizarComando(comando);
         }

        internal static bool ModificarJuego(Juego j)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "UPDATE Juegos SET Titulo = '" + j.titulo + "', FechaSalida= '" + j.fechaSalida + "', " +
                    "Ventas = '" + j.ventas + "', Precio = '" + j.precio + "', Genero = '" + j.genero + "' " +
                    " WHERE JuegoId = '" + j.id + "'";
            return RealizarComando(comando);
        }

        internal static bool EliminarJuego(Juego j)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "DELETE FROM Juegos WHERE JuegoId = '" + j.id + "'";
            return RealizarComando(comando);
        }
    }
}
