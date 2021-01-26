using Owin;
using Microsoft.Owin;
using System.Diagnostics;
using SportsStore.WebUI.Middlewares;

[assembly: OwinStartupAttribute(typeof(SportsStore.WebUI.Startup))]

namespace SportsStore.WebUI
{
    public class Startup
    {
        public static void Configuration(IAppBuilder app)
        {
            app.UseDebugMiddleware(new DebugMiddlewareOptions
            {
                IncomingRequest = (ctx) =>
                {
                    var watch = new Stopwatch();
                    watch.Start();
                    ctx.Environment["DebugStopwatch"] = watch;
                },
                OutgoingRequest = (ctx) =>
                {
                    var watch = (Stopwatch)ctx.Environment["DebugStopwatch"];
                    watch.Stop();
                    Debug.WriteLine($"Request took: {watch.ElapsedMilliseconds}ms");
                }
            });
        }
    }
}