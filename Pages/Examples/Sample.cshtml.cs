using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using isRock.Web.Core.Razor;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace __NameSpace__.Pages.Examples
{
    public class SampleModel : isPageModel
    {
        public void OnGet()
        {

        }

        [PageMethod]
        public static object CalBmi(dynamic para)
        {
            //get data from javascript
            int height = para.height;
            int weight = para.weight;
            
            //logic
            float H = para.height;
            H = H / 100;

            //response 200 OK with result
            var result = weight / (H * H);
            return result;
        }
    }
}