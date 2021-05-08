using System;
using System.Collections.Generic;
using System.Text;

namespace MODELS.PortoModels
{
    public class Skill : BaseModel
    {
        public string SkillName { get; set; }
        public string SkillIcon { get; set; }
        public string SkillColorIcon { get; set; }
        public int Degree { get; set; }

        public int PersonInfoID { get; set; }
        public PersonInfo Person { get; set; }
    }
}
