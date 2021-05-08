using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortofolioAPI.ApiModels
{
    public class Portofolio
    {
        public int ID { get; set; } = 0;
        public string ProjectName { get; set; }
        public string Role { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
    }
}
