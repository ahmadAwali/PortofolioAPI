using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortofolioAPI.ApiModels
{
    public class Education
    {
        public int ID { get; set; } = 0;
        public string OrganizationName { get; set; }
        public string OrganizationTitle { get; set; }
        public string Specialty { get; set; }
        public string Degree { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string GraduationProject { get; set; }
        public string Certificate { get; set; }
        public string Description { get; set; }
    }
}
