using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using isRock.Web.Core.Razor;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace __NameSpace__.Pages
{
    public class mainWithLayoutModel : isPageModel
    {
        public void OnGet()
        {

        }

        [PageMethod]
        public static object GetData(dynamic para)
        {
            var db = new RazorPageDemo.Models.CRMContext();
            var ret = from c in db.Employee
                      select c;

            return ret.ToList();
        }

        [PageMethod]
        public static object AddNew(dynamic para)
        {
            var db = new RazorPageDemo.Models.CRMContext();

            var item = new RazorPageDemo.Models.Employee()
            {
                Address = para.address,
                IsValid = true,
                Memo = para.memo,
                Name = para.name,
                Phone = para.phone,
                PictureUrl = para.pictureUrl,
                Title = para.title,
            };

            db.Employee.Add(item);
            db.SaveChanges();

            return item.Id;
        }
    }
}