using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortofolioAPI.ApiModels
{
    public class PersonInfo
    {
        public int ID { get; set; } = 0;
        public string Name { get; set; }
        public string FatharName { get; set; }
        public string GrandFatharName { get; set; }
        public string FamilyName { get; set; }
        public string PhoneNmber { get; set; }
        public string Email { get; set; }
        public string Slogan { get; set; }
        public string AboutMe { get; set; }

        public List<Education> Educations { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Image> Images { get; set; }
        public List<Portofolio> Portofolios { get; set; }
        public List<Service> Services { get; set; }
        public List<Skill> Skills { get; set; }
        public List<SocialMedia> SocialMedias { get; set; }
    }
}
