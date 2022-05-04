using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Task.Models;

namespace Task.Helpers
{
    public class ImageBlurer
    {
        public static void BlurImages(IEnumerable<ImageBlurModel> images)
        {
            foreach (var item in images)
            {
                Console.WriteLine($"{item.ImageName} blured to {item.BlurPX}");

            }
        }
    }
}