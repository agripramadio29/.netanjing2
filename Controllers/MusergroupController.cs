using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WebApplication2.Models;
using WebApplicationTest.Models;

namespace WebApplication2.Controllers
{
    public class MusergroupController : Controller
    {
        public async Task<IActionResult> Musergroup()
        {
            List<MusergroupModel> listMusergroup = new List<MusergroupModel>();
            string url = "http://ruangjuang.sdd.co.id:6064/musergroup";
            //using (var client = new HttpClient())
            //{
            //    var result = client.GetAsync(url).Result;
            //    if (result.IsSuccessStatusCode)
            //    {
            //        var Resp = await result.Content.ReadAsStringAsync();
            //        var data = JsonSerializer.Deserialize<ResponViewModel<ResponPage>>(Resp);

            //        //
            //        listMusergroup = (data != null) ? data.data.Data.ToList() : null;
            //        return View(listMusergroup);
            //    }
            //    else
            //        return View(null);
            //}

            var client = new HttpClient();
            var result = client.GetAsync(url).Result;
            if (result.IsSuccessStatusCode)
            {
                var Resp = await result.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<ResponViewModel<ResponPage>>(Resp);

                //
                listMusergroup = (data.data.Data != null) ? data.data.Data.ToList() : null;
                return View(listMusergroup);
            }
            else
                return View(null);
        }
    }
}
