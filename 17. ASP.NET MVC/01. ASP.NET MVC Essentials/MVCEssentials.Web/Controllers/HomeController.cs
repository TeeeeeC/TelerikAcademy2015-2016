
using MVCEssentials.Web.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVCEssentials.Web.Controllers
{
    public class HomeController : Controller
    {
        private List<Data> types = new List<Data>();

        public ActionResult Index()
        {
            types.Add( new Data() { Key = "bit - b", Value = 1 });
            types.Add( new Data() { Key = "Byte - B", Value = (decimal)1 / 8 });
            types.Add( new Data() { Key =  "Kilobit - Kb" });
            types.Add( new Data() { Key =  "Kilobyte - KB" });
            types.Add( new Data() { Key =  "Megabit - Mb" });
            types.Add( new Data() { Key =  "Megabyte - MB" });
            types.Add( new Data() { Key =  "Gigabit - Gb" });
            types.Add( new Data() { Key =  "Gigabyte - GB" });
            types.Add( new Data() { Key =  "Terabit - Tb" });
            types.Add( new Data() { Key =  "Terabyte - TB" });
            types.Add( new Data() { Key =  "Petabit - Pb" });
            types.Add( new Data() { Key =  "Petabyte - PB" });
            types.Add( new Data() { Key =  "Exabit - Eb" });
            types.Add( new Data() { Key =  "Exabyte - EB" });
            types.Add( new Data() { Key =  "Zettabit - Zb" });
            types.Add( new Data() { Key =  "Zettabyte - ZB" });
            types.Add( new Data() { Key =  "Yottabit - Yb" });
            types.Add(new Data() { Key = "Yottabyte - YB" });

            decimal startStorageBit = 1;
            decimal startStorageByte = (decimal)1 / 8;
            for (int i = 2; i < types.Count; i++)
            {
                if (i % 2 == 0)
                {
                    startStorageBit /= 1024;
                    types[i].Value = startStorageBit;
                    startStorageByte = startStorageBit;
                }
                else
                {
                    startStorageByte /= 8;
                    types[i].Value = startStorageByte;
                }
            }

            return View(types);
        }
    }
}