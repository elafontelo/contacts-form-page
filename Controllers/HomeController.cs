using ContactsApp.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactsApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContactForm(Contacts input)
        {
            Contacts contact = new Contacts();

            contact.firstName = input.firstName;
            contact.lastName = input.lastName;
            contact.address = input.address;
            contact.state = input.state;
            contact.country = input.country;
            contact.zipCode = input.zipCode;
            contact.phoneNumber = input.phoneNumber;
            contact.notes = input.notes;

            using (MySqlConnection connect = new MySqlConnection("Data Source=localhost; port=3306; Database=testdb; UserId=root; password=123456"))
            {
                connect.Open();
                string insert = "Insert into contacts(firstName, lastName, address, state, country, zipCode, phoneNumber, notes) values('" + input.firstName + "', '" + input.lastName + "', '" + input.address + "', '" + input.state + "', '" + input.country + "', '" + input.zipCode + "', '" + input.phoneNumber + "', '" + input.notes + "')";
                MySqlCommand insertCmd = connect.CreateCommand();
                insertCmd.CommandType = CommandType.Text;
                insertCmd.CommandText = insert;
                insertCmd.ExecuteNonQuery();
                connect.Close();
            }

            return RedirectToAction("ConfirmPage");
        }

        public ActionResult ConfirmPage()
        {
            return View();
        }

    }
}
