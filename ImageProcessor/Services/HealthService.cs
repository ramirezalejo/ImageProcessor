using ImageProcessor.Contracts.Services;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ImageProcessor.Services
{
    public class HealthService : IHealthService
    {
        public Task<HealthCheckResult> CheckHealthAsync(
        HealthCheckContext context,
        CancellationToken cancellationToken = default(CancellationToken))
        {
            var healthCheckResultHealthy = true;

            if (healthCheckResultHealthy)
            {
                return Task.FromResult(
                    HealthCheckResult.Healthy("healthy"));
            }

            return Task.FromResult(
                new HealthCheckResult(context.Registration.FailureStatus,
                "unhealthy"));
        }
    }
}
