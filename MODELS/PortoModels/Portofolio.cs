using System;
using System.Collections.Generic;
using System.Text;

namespace MODELS.PortoModels
{
    public class Portofolio : BaseModel
    {
        public string ProjectName { get; set; }
        public string Role { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }

        public int PersonInfoID { get; set; }
        public PersonInfo Person { get; set; }
    }
}
