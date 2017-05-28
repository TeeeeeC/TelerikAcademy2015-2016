using System;
using System.Web;

namespace Lifecycle
{
    public class HttpHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("httpHandler:ProcessRequest" + "<br/>");
        }
    }
}
