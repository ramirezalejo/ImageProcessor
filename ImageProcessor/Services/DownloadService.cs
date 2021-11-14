using ImageProcessor.Contracts.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ImageProcessor.Services
{
    public class DownloadService : IDownloadService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<DownloadService> _logger;

        public DownloadService(IHttpClientFactory httpClientFactory, ILogger<DownloadService> logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

        public async Task<byte[]> DownloadToByteArrrayAsync(Uri uri, CancellationToken cancellationToken)
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
                return await client.GetByteArrayAsync(uri, cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error downloading from Uri {uri}");
                throw;
            }
           
        }
    }
}
