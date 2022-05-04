using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Task.Models;

namespace Task.Helpers
{
    public class ImageConverter
    {
        public static void ConvertImages(IEnumerable<ImageConverterModel> images)
        {
            foreach (var item in images)
            {
                Console.WriteLine($"{item.ImageName} Converted to {item.ConvertType}");

            }
        }
    }
}