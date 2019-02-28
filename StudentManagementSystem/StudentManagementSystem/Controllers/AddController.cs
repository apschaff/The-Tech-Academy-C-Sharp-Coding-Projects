using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManagementSystem.Controllers
{
    public class AddController : Controller
    {
        private string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = School; 
                                            Integrated Security = True; Connect Timeout = 30; Encrypt=False;
                                            TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                            MultiSubnetFailover=False";

        // GET: Add
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Student student)
        {
            string queryString = @"Insert into Students (FirstName, LastName) Values (@FirstName, @LastName)";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                command.Parameters.Add("@LastName", SqlDbType.VarChar);

                command.Parameters["@FirstName"].Value = student.FirstName;
                command.Parameters["@LastName"].Value = student.LastName;

                connection.Open();
                command.ExecuteNonQuery();

                connection.Close();
            }
            return RedirectToAction("Index");
        }
    }
}