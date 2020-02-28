using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace groccit_rest_api.controllers
{
    public class TestPurphaseController: NancyModule 
    {
        public TestPurphaseController()
        {
            Get("/testpurphase", u => {
                return "Hello";
            });
        }
    }
}