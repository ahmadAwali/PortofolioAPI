using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortofolioAPI.ApiModels
{
    public class Service
    {
        public int ID { get; set; } = 0;
        public string ServiceIcon { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
