using System;
using System.Collections.Generic;
using System.Text;

namespace MODELS.PortoModels
{
    public class Education : BaseModel
    {
        public string OrganizationName { get; set; }
        public string OrganizationTitle { get; set; }
        public string Specialty { get; set; }
        public string Degree { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string GraduationProject { get; set; }
        public string Certificate { get; set; }
        public string Description { get; set; }

        public int PersonInfoID { get; set; }
        public PersonInfo Person { get; set; }
    }
}
