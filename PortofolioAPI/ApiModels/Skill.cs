using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortofolioAPI.ApiModels
{
    public class Skill
    {
        public int ID { get; set; } = 0;
        public string SkillName { get; set; }
        public string SkillIcon { get; set; }
        public string SkillColorIcon { get; set; }
        public int Degree { get; set; }
    }
}
