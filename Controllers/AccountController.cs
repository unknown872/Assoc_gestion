using Microsoft.AspNetCore.Mvc;
using appli_gest_assoc.Models;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace appli_gest_assoc.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        //GET:Account
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        void connectionString()
        {
            con.ConnectionString = "data source=UNKNOWN01; database=db_gest_assoc_db; integrated security=true;";
        }
        [HttpPost]
        public ActionResult Verify(Account account)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from admin where email='"+account.Email+"' and password='"+account.Password+"' ";
            dr = com.ExecuteReader();
            if(dr.Read())
            {
                con.Close();
                return View("Index");
            }
            else
            {
                con.Close();
                return View("ErrorLogin");
            }
            
            
        }
    }
}
