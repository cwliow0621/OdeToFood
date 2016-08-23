using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    [Route("About")]
    public class AboutController
    {
        [Route("phone")]
        public string Phone()
        {
            return "+1555 555 555";
        }

        [Route("country")]
        public string Country()
        {
            return "USA";
        }
    }
}
