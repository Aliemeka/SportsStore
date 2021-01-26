using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;

namespace SportsStore.WebUI.Middlewares
{
    public class DebugMiddlewareOptions
    {
        public Action<OwinContext> IncomingRequest { get; set; }
        public Action<OwinContext> OutgoingRequest { get; set; }
    }
}