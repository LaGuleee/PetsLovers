using MySqlConnector;
using System.Text;

namespace Petlovers.Controllers
{
    public class Utilidades
    {
        public static MySqlConnection ConectarBD()
        {
            string cad = "server=localhost; dtabase=petlovers; uid=PetloversP";
            return new MySqlConnection(cad);
        }

  
   }
}
