using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemopensionPartner.Models
{
    public class RequestPublicPension
    {
        public RequestPublicPension()
        {
            data = new Data();
        }
        public string licenseKey { get; set; }
        public Data data { get; set; }
    }

}
