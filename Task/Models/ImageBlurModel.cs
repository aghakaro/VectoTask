using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task.Models
{
    public class ImageBlurModel : IImage
    {
        public string ImageName { get; set; }
        public string BlurPX { get; set; }
    }
}