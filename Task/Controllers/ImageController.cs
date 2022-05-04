using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Task.Helpers;
using Task.Models;

namespace Task
{
    public class ImageController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        [Route("api/Image/UploadFiles")]
        [HttpPost]
        public HttpResponseMessage UploadFiles(IEnumerable<ImageModel> images)
        {
            try
            {
                var imageToResize = images.Where(x => x.Filters.Any(y => y.FilterType == (int)FilterTypes.Resize)).
                Select(s => new ImageResizerModel
                {
                    ImageName = s.ImageName,
                    ResizePX = s.Filters.Select(w => w.FilterEffect).FirstOrDefault()

                }).ToList();

                if (imageToResize.Any())
                {
                    ImageResizer.ResizeImage(imageToResize);
                }

                var imageToBlur = images.Where(x => x.Filters.Any(y => y.FilterType == (int)FilterTypes.Blur)).
                   Select(s => new ImageBlurModel
                   {
                       ImageName = s.ImageName,
                       BlurPX = s.Filters.Select(w => w.FilterEffect).FirstOrDefault()

                   }).ToList();

                if (imageToBlur.Any())
                {
                    ImageBlurer.BlurImages(imageToBlur);
                }

                var imageToConvert = images.Where(x => x.Filters.Any(y => y.FilterType == (int)FilterTypes.Convert)).
                   Select(s => new ImageConverterModel
                   {
                       ImageName = s.ImageName,
                       ConvertType = s.Filters.Select(w => w.FilterEffect).FirstOrDefault()

                   }).ToList();

                if (imageToConvert.Any())
                {
                    ImageConverter.ConvertImages(imageToConvert);
                }

                return Request.CreateResponse(HttpStatusCode.OK);

            }
            catch (Exception e)
            {
                return Request.CreateResponse(e.Message);
            }

        }

    }
}