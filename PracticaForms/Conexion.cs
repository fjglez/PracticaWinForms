using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaForms
{
    public class Conexion
    {
        public SqlConnection cnx;

        public Conexion()
        {
            try
            {
                cnx = new SqlConnection("Data Source=WINAPZHTG0RWNVU\\SQLEXPRESS;Initial Catalog=PracticaForms;Integrated Security=True");
                Console.WriteLine("Éxito al conectar.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error al conectar. " + ex.Message);
            }
        }
    }
}
