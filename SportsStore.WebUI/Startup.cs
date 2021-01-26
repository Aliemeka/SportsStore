using Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace SportsStore.WebUI
{
    public class Startup
    {
        public static void Configuration(IAppBuilder app)
        {
            app.Use(async (ctx, next) =>
            {
                Debug.WriteLine($"Incoming request path: {ctx.Request.Path}");
                await next();
                Debug.WriteLine($"Incoming request headers: {ctx.Request.Headers}");
            });
        }
    }
}