using System;
using System.Collections.Generic;
using System.Text;

namespace MODELS.PortoModels
{
    public class SocialMedia : BaseModel
    {
        public string Name { get; set; }
        public string Link { get; set; }
        public string SkillColorIcon { get; set; }
        public string SocialMediaIcon { get; set; }

        public int PersonInfoID { get; set; }
        public PersonInfo Person { get; set; }

    }
}
