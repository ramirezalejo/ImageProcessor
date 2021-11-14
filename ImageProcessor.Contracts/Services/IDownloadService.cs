using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ImageProcessor.Contracts.Services
{
    public interface IDownloadService
    {
        Task<byte[]> DownloadToByteArrrayAsync(Uri uri, CancellationToken cancellationToken = default);
    }
}
