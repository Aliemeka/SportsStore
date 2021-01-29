using System.Web;
using System.Web.Optimization;

namespace SportsStore.WebUI
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
             //           "~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/core").Include(
                        "~/assets/js/core/jquery.min.js",
                        "~/assets/js/core/popper.min.js",
                        "~/assets/js/core/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/plugins").Include(
                "~/assets/js/plugins/bootstrap-datepicker.js",
                "~/assets/js/plugins/bootstrap-switch.js",
                "~/assets/js/plugins/nouislider.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/assets/js/now-ui-kit.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/assets/css/bootstrap.min.css",
                      "~/assets/css/now-ui-kit.min.css",
                      "~/assets/demo/demo.css",
                      "~/Content/site.css"));
        }
    }
}
