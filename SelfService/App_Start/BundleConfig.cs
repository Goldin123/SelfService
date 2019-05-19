using System.Web;
using System.Web.Optimization;

namespace SelfService
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/js/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                     "~/Content/js/bootstrap.bundle.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryeasing").Include(
                        "~/Content/js/jquery.easing.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/sbadmin").Include(
                 "~/Content/js/sb-admin-2.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));



            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //          "~/Content/bootstrap.css",
            //          "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/css/all.min.css", "~/Content/css/sb-admin-2.min.css"));

        }
    }
}
