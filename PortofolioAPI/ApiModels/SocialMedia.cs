using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortofolioAPI.ApiModels
{
    public class SocialMedia
    {
        public int ID { get; set; } = 0;
        public string Name { get; set; }
        public string Link { get; set; }
        public string SkillColorIcon { get; set; }
        public string SocialMediaIcon { get; set; }
    }
}
