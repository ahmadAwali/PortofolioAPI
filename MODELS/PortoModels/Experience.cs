using System;
using System.Collections.Generic;
using System.Text;

namespace MODELS.PortoModels
{
    public class Experience : BaseModel
    {
        public string Workplace { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public int PersonInfoID { get; set; }
        public PersonInfo Person { get; set; }
    }
}
