using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Script.Serialization;
using MiyaYazilim.Models;

namespace MiyaYazilim.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult List()
        {
            ViewBag.Data = GetApiData();
            return View();
        }

        public List<PageInfo> GetApiData()
        {

            var apiUrl = "https://reqres.in/api/users?page=2";

            //Connect API
            Uri url = new Uri(apiUrl);
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;

            string json = client.DownloadString(url);
            //END

            //JSON Parse START
            JavaScriptSerializer ser = new JavaScriptSerializer();
            List<PageInfo> jsonList = ser.Deserialize<List<PageInfo>>(json);
            PageInfo PI = ser.Deserialize<PageInfo>(json);
            ViewBag.listem = PI.data.ToList();
            
            //END

            return jsonList;
        }



        [HttpGet]
        public ActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Add(DataInfo model)  
        {
           

            DataInfo yeni = new DataInfo();
            yeni.first_name = model.first_name;
            yeni.last_name = model.last_name;
            


            return RedirectToAction("List");


        }
    }
}
