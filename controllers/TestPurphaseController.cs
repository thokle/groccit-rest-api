using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using data_soruce_mil.services;
using data_soruce_mil.models;
using Nancy.ModelBinding;
using Newtonsoft.Json;

namespace groccit_rest_api.controllers
{
    public class TestPurphaseController: NancyModule 
    {
        public TestPurphaseController(TestPurhaseIntentionService testPurhaseIntentionService)
        {
            Get("/testPurphase/all", u => {
              
             var res=  JsonConvert.SerializeObject(testPurhaseIntentionService.GetTestPurchaseIntentions());
                return res;
            });
            Post("/testPurphase/create", c =>
            {
             var test =    this.Bind<TestPurchaseIntention>();
                var res = testPurhaseIntentionService.CreateTestPurchaseIntention(test);
            
                return "Oprettet ";
            }); 
         
        }
    }
}