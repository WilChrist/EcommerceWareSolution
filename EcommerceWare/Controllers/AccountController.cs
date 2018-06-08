
using EcommerceWare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace EcommerceWare.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            if (Session["user"] != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        public ActionResult Login(string Login, string Password)
        {
            try
            {
                // TODO: Add insert logic here
                Login_informationsForView login = new Login_informationsForView();
                login.Login = Login;
                login.Password = Password;
                HttpResponseMessage response = Poster(login, "api/Customers");
                CustomersForView customers = new CustomersForView();
                if (response.IsSuccessStatusCode)
                {
                    customers = response.Content.ReadAsAsync<CustomersForView>().Result;
                    Session["user"] = customers;
                }
                else
                {
                    ViewBag.error = "error";
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public ActionResult SignUp(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Account/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        // GET: Account/Detail
        public ActionResult Detail()
        {
            return View();
        }

        // GET: Account/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Account/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Account/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Account/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Account/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Account/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public HttpResponseMessage Poster(Login_informationsForView login, string path)
        {
            HttpClient client = new HttpClient();

            // Update port # in the following line.
            client.BaseAddress = new Uri("http://192.168.1.12:8088/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.PostAsJsonAsync<Login_informationsForView>(path, login).Result;
            return response;

        }
    }

}
