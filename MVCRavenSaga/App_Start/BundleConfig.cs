using System.Web;
using System.Web.Optimization;

namespace MVCRavenSaga
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                           "~/Content/estilos/bootstrap.min.css",
                           "~/Content/estilos/font-awesome.min.css",
                           "~/Content/estilos/animate.min.css",
                           "~/Content/estilos/et-line-font.css",
                           "~/Content/estilos/nivo-lightbox.css",
                           "~/Content/estilos/nivo_themes/default/default.css",
                           "~/Content/jquery.datetimepicker.css",
                           "~/Content/sweetalert.css",
                           "~/Content/estilos/style.css"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/Scripts/jquery.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/smoothscroll.js",
                      "~/Scripts/isotope.js",
                      "~/Scripts/imagesloaded.min.js",
                      "~/Scripts/nivo-lightbox.min.js",
                      "~/Scripts/jquery.backstretch.min.js",
                      "~/Scripts/wow.min.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/custom.js"));
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/timepicker").Include(
                        "~/Scripts/moment-with-locales.js",
                        "~/Scripts/jquery.datetimepicker.full.min.js"));

           
           
        }
    }
}
