using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login_MVC_.Models;
using System.Data.SqlClient;
namespace Login_MVC_.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        void connectionString()
        {
            con.ConnectionString = "Data source=desktop-e5jj4pe\\abdulsql;Initial Catalog=Login;User ID=sa;Password=abdul542001";
        }
        [HttpPost]
        public ActionResult Verify(Account acc)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from tbl_login where username = '"+acc.Name+"' and password = '"+acc.Password+"'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return View("Create");

            }
            else
            {
                con.Close();
                return View("Error");
            }
        }
    }
}