using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortofolioAPI.ApiModels
{
    public class Experience
    {
        public int ID { get; set; } = 0;
        public string Workplace { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
