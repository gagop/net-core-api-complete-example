using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreExApi.Controllers
{
    [Route("api/test")]
    public class TestController : Controller
    {
        public string Index()
        {
            return "Ala ma kota";
        }
    }
}