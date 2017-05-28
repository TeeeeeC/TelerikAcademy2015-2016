using System;
using System.Collections;
using System.Web;

namespace Lifecycle
{
    public class HttpModule : IHttpModule
    {
        public void Dispose()
        {
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += this.OnBeginrequest;
            context.AuthenticateRequest += this.OnAuthentication;
            context.AuthorizeRequest += this.OnAuthorization;
            context.ResolveRequestCache += this.OnResolveRequestCache;
            context.AcquireRequestState += this.OnAcquireRequestState;
            context.PreRequestHandlerExecute += this.OnPreRequestHandlerExecute;

            context.PostRequestHandlerExecute += this.OnPostRequestHandlerExecute;
            context.ReleaseRequestState += this.OnReleaseRequestState;
            context.UpdateRequestCache += this.OnUpdateRequestCache;
            context.EndRequest += this.OnEndRequest;
        }

        private void OnBeginrequest(object sender, EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            HttpContext context = application.Context;
            context.Response.Write("httpModule:BeginRequest" + "<br/>");
        }

        private void OnAuthentication(object sender, EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            HttpContext context = application.Context;
            context.Response.Write("httpModule:AuthenticateRequest" + "<br/>");
        }

        private void OnAuthorization(object sender, EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            HttpContext context = application.Context;
            context.Response.Write("httpModule:OnAuthorization" + "<br/>");
        }

        private void OnResolveRequestCache(object sender, EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            HttpContext context = application.Context;
            context.Response.Write("httpModule:OnResolveRequestCache" + "<br/>");
        }

        private void OnAcquireRequestState(object sender, EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            HttpContext context = application.Context;
            context.Response.Write("httpModule:OnAcquireRequestState" + "<br/>");
        }

        private void OnPreRequestHandlerExecute(object sender, EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            HttpContext context = application.Context;
            context.Response.Write("httpModule:OnPreRequestHandlerExecute" + "<br/>");
        }

        private void OnPostRequestHandlerExecute(object sender, EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            HttpContext context = application.Context;
            context.Response.Write("httpModule:OnPostRequestHandlerExecute" + "<br/>");
        }

        private void OnReleaseRequestState(object sender, EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            HttpContext context = application.Context;
            context.Response.Write("httpModule:OnReleaseRequestState" + "<br/>");
        }

        private void OnUpdateRequestCache(object sender, EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            HttpContext context = application.Context;
            context.Response.Write("httpModule:OnUpdateRequestCache" + "<br/>");
        }

        private void OnEndRequest(object sender, EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            HttpContext context = application.Context;
            context.Response.Write("httpModule:EndRequest" + "<br/>");
        }
    }
}
