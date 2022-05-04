using System;
using System.Collections.Generic;
using System.Linq;
using System.Web; 

namespace Task.Models
{
    public class ImageConverterModel : IImage
    {
        public string ImageName { get; set; }
        public string ConvertType { get; set; }
    }
}