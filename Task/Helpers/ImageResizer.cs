using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Task.Models;

namespace Task.Helpers
{
    public static class ImageResizer
    {
        public static void ResizeImage(IEnumerable<ImageResizerModel> images)
        {
            foreach (var item in images)
            {
                Console.WriteLine($"{item.ImageName} resized to {item.ResizePX}");

            }
        }
    }
}