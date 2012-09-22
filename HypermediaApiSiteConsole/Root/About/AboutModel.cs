﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HypermediaApiSiteConsole.Root.About
{
    public class AboutModel
    {
        public AboutModel()
        {
            Name = "Darrel Miller";
            TwitterName = "@darrel_miller";
            BlogUrl = new Uri("http://www.bizcoder.com");
            Email = "darrel@tavis.ca";
        }
        public string Name { get; set; }
        public string TwitterName { get; set; }
        public Uri BlogUrl { get; set; }
        public string Email { get; set; }
    }
}
