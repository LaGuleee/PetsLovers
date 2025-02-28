using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using Petlovers.Models.ViewModel.cs;

namespace Petlovers.Controllers
{
    public class LoginController : Controller
    {
        private object modelState;

        public string Clave { get; private set; }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Login(LoginViewModel user)
        {
            if (ModelState.IsValid) {
                MySqlConnection con = Utilidades.ConectarBD();
                con.Open();


                string sql = "SELECT * FROM usuario WHERE doc =" + user.Doc + "AND clave" + Clave;

                MySqlCommand cmd = new MySqlCommand(sql, con);

                MySqlDataAdapter dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    { }
                    con.Close();
                }
                return View();
            }

        }
    }
    
