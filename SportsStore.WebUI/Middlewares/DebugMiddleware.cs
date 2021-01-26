using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Owin;
using AppFunc = System.Func<
    System.Collections.Generic.IDictionary<string, object>,
    System.Threading.Tasks.Task
>;

namespace SportsStore.WebUI.Middlewares
{
    public class DebugMiddleware
    {
        private readonly AppFunc _next;
        private DebugMiddlewareOptions _options;

        public DebugMiddleware(AppFunc next, DebugMiddlewareOptions options)
        {
            _next = next;

            _options = options;
            if (_options.IncomingRequest == null)
                _options.IncomingRequest = (ctx) => { Debug.WriteLine($"Incoming request path: {ctx.Request.Path}"); };
            if (_options.OutgoingRequest == null)
                _options.OutgoingRequest = (ctx) => { Debug.WriteLine($"Outgoing request path: {ctx.Request.Path}"); };
        }

        public async Task Invoke(IDictionary<string, object> environment)
        {
            var ctx = new OwinContext(environment);
            _options.IncomingRequest(ctx);
            await _next(environment); 
            _options.OutgoingRequest(ctx);
        }
    }
}