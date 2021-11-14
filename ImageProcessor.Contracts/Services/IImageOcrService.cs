using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessor.Contracts.Services
{
    public interface IImageOcrService
    {
        Task ProcessImage(byte[] image, string[] blackList, string language = "eng");
    }
}
