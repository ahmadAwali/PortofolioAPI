using System;
using System.Collections.Generic;
using System.Text;

namespace MODELS.PortoModels
{
    public class PersonInfo : BaseModel
    {
        public string Name { get; set; }
        public string FatharName { get; set; }
        public string GrandFatharName { get; set; }
        public string FamilyName { get; set; }
        public string PhoneNmber { get; set; }
        public string Email{ get; set; }
        public string Slogan { get; set; }
        public string AboutMe { get; set; }

        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Portofolio> Portofolios { get; set; }
        public virtual ICollection<Service> Services { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
        public virtual ICollection<SocialMedia> SocialMedias { get; set; }

    }
}
