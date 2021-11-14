using ImageProcessor.Contracts.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace ImageProcessor.Services
{
    public class ImageOcrService : IImageOcrService
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<ImageOcrService> _logger;

        public ImageOcrService(IConfiguration configuration, ILogger<ImageOcrService> logger)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public async Task ProcessImage(byte[] image, string[] blackList, string language)
        {
            using (var engine = new TesseractEngine(_configuration[$"TesseractEnginePath_{language}"], language, EngineMode.Default))
{
                using (var img = Pix.LoadFromMemory(image))
                {
                    using (var page = engine.Process(img))
                    {
                        recognitionText = page.GetText();
                    }
                }
            }
        }
    }
}
