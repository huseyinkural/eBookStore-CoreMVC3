using System;
using System.Collections.Generic;
using System.Text;

namespace eBookStore.Utility
{
    public class EmailOptions
    {
        public string SendGridKey { get; set; }
        public string SendGridUser { get; set; }

        public string mailgunAPI { get; set; }
        public string domainName { get; set; }

        public string CredentialEmail { get; set; }
        
        public string CredentialPassword { get; set; }
    }
}
