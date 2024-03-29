﻿using System.Web;
using System.Web.Optimization;

namespace WebAdvertiseApplication
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //calendar css file
            bundles.Add(new StyleBundle("~/Content/fullcalendarcss").Include(
                        "~/Content/theme/jquery-ui.css",
                        "~/Content/fullcalendar.css"));

            //calendar script file
            bundles.Add(new ScriptBundle("~/bundles/fullcalendar").Include(
                        "~/Scripts/jquery-3.6.0.min.js",
                        "~/Scripts/moment.min.js",
                        "~/Scripts/fullcalendar/fullcalendar.js",
                        "~/Scripts/calendar.js"
                        ));
            //jqeury ui
            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include("~/Scripts/jquery-ui-{version}.js"));
            bundles.Add(new StyleBundle("~/Content/cssjqryUi").Include("~/Content/jquery-ui.css"));
        }
    }
}
