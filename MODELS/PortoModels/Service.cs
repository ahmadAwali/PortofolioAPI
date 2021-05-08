using System;
using System.Collections.Generic;
using System.Text;

namespace MODELS.PortoModels
{
    public class Service : BaseModel
    {
        public string ServiceIcon { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int PersonInfoID { get; set; }
        public PersonInfo Person { get; set; }
    }
}
