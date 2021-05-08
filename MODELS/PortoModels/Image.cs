using System;
using System.Collections.Generic;
using System.Text;

namespace MODELS.PortoModels
{
    public class Image : BaseModel
    {
        public string Name { get; set; }
        public byte[] Img { get; set; }

        public int PersonInfoID { get; set; }
        public PersonInfo Person { get; set; }
    }
}
