using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace RaIssue
{
    public class TestFunc
    {
        private readonly ILogger _log;

        public TestFunc(ILoggerFactory loggerFactory)
        {
            _log = loggerFactory.CreateLogger<TestFunc>();
        }

        [FunctionName(nameof(TestFunc))]
        public void RunAsync([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req)
        {
            _log.LogInformation("Hello World!");
        }

    }
}