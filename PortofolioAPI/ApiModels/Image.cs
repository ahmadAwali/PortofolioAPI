using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortofolioAPI.ApiModels
{
    public class Image
    {
        public int ID { get; set; } = 0;
        public string Name { get; set; }
        public byte[] Img { get; set; }
    }
}
