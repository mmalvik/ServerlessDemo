using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace ServerlessDemo
{
    public static class DemoFunction
    {
        [FunctionName("DemoFunction")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]
            HttpRequestMessage req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            var company = new Company() {Id = Guid.NewGuid(), Name = "DIPS AS", Location = "Bodø"};

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(company.ToJson(), Encoding.UTF8, "application/json")
            };
        }
    }
}
