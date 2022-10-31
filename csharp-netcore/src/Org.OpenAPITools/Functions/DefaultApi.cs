using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Enums;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Org.OpenAPITools.Models;

namespace Org.OpenAPITools.Functions
{ 
    public partial class DefaultApi
    { 
        [FunctionName("DefaultApi_GetPing")]
        public async Task<ActionResult<>> _GetPing([HttpTrigger(AuthorizationLevel.Anonymous, "Get", Route = "ping")]HttpRequest req, ExecutionContext context)
        {
            var method = this.GetType().GetMethod("GetPing");
            if(method == null)
            {
                return new StatusCodeResult((int)HttpStatusCode.NotImplemented);
            }
            return (await ((Task<>)method.Invoke(this, new object[] { req, context, id })).ConfigureAwait(false));
        }
    }
}
