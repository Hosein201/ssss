using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppDemo
{
    public partial class Action : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var name = Request.Form["name"];
            var family = Request.Form["family"];
            var locations = Request.Form["locationss"];
            var seatbuttons = Request.Form["seatbuttonss"];

            using (StreamWriter sw = new StreamWriter(Server.MapPath("~/SubmittedData/locations.txt"), true))
            {
                sw.WriteLine($"{name},{family},{locations},{seatbuttons}");
            }

            Thread.Sleep(2000);

            Response.Write("اطلاعات با موفقیت ثبت شد");

        }
    }
}