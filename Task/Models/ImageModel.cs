using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task.Models
{
    public class ImageModel : IImage
    {
        public int Id { get; set; } 
        public string ImageName { get; set; } 
        public IEnumerable<FilterModel> Filters { get; set; } 
    }
}