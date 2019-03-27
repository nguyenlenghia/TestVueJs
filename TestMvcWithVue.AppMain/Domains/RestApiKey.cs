using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestMvcWithVue.AppMain.Domains
{
    public class RestApiKey
    {
        public string Username { get; set; }
        public string Description { get; set; }

        public string ConconsumerKey { get; set; }
        public string consumerSecret { get; set; }
    }
}