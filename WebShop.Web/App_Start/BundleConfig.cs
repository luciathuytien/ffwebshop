﻿using System.Web.Optimization;

namespace WebShop.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();

            //VENDOR RESOURCES

            //~/Bundles/vendor/css
            bundles.Add(
                new StyleBundle("~/Bundles/vendor/css")
                    .Include("~/Content/themes/base/all.css", new CssRewriteUrlTransform())
                    .Include("~/Content/bootstrap-cosmo.min.css", new CssRewriteUrlTransform())
                    .Include("~/Content/toastr.min.css")
                    .Include("~/Scripts/sweetalert/sweet-alert.css")
                    .Include("~/Content/flags/famfamfam-flags.css", new CssRewriteUrlTransform())
                    .Include("~/Content/font-awesome.min.css", new CssRewriteUrlTransform())
                );

            //~/Bundles/vendor/js/top (These scripts should be included in the head of the page)
            bundles.Add(
                new ScriptBundle("~/Bundles/vendor/js/top")
                    .Include(
                        "~/Abp/Framework/scripts/utils/ie10fix.js",
                        "~/Scripts/modernizr-2.8.3.js"
                    )
                );

            //~/Bundles/vendor/bottom (Included in the bottom for fast page load)
            bundles.Add(
                new ScriptBundle("~/Bundles/vendor/js/bottom")
                    .Include(
                        "~/Scripts/json2.min.js",

                        "~/Scripts/jquery-3.1.0.min.js",
                        "~/Scripts/jquery-ui-1.12.0.min.js",

                        "~/Scripts/bootstrap.min.js",

                        "~/Scripts/moment-with-locales.min.js",
                        "~/Scripts/jquery.validate.min.js",
                        "~/Scripts/jquery.blockUI.js",
                        "~/Scripts/toastr.min.js",
                        "~/Scripts/sweetalert/sweet-alert.min.js",
                        "~/Scripts/others/spinjs/spin.js",
                        "~/Scripts/others/spinjs/jquery.spin.js",

                        "~/Abp/Framework/scripts/abp.js",
                        "~/Abp/Framework/scripts/libs/abp.jquery.js",
                        "~/Abp/Framework/scripts/libs/abp.toastr.js",
                        "~/Abp/Framework/scripts/libs/abp.blockUI.js",
                        "~/Abp/Framework/scripts/libs/abp.sweet-alert.js",
                        "~/Abp/Framework/scripts/libs/abp.spin.js"
                    )
                );

            //ADMIN PAGE RESOURCES

            //~/Bundles/admin/css
            bundles.Add(
                new StyleBundle("~/Bundles/admin/css")
                    .Include("~/Content/admin/dist/css/skins/skin-green-light.min.css", new CssRewriteUrlTransform())
                    .Include("~/Content/admin/dist/css/_all-skins.min.css", new CssRewriteUrlTransform())
                    .Include("~/Content/bootstrap-cosmo.min.css", new CssRewriteUrlTransform())
                    .Include("~/Content/font-awesome.min.css", new CssRewriteUrlTransform())
                    .Include("~/Content/admin/dist/css/AdminLTE.min.css", new CssRewriteUrlTransform())
                );

            //~/Bundles/admin/plugins/css
            bundles.Add(
               new StyleBundle("~/Bundles/admin/plugins/css")
                   .Include("~/Content/admin/plugins/iCheck/flat/blue.css", new CssRewriteUrlTransform())
                   .Include("~/Content/admin/plugins/morris/morris.css", new CssRewriteUrlTransform())
                   .Include("~/Content/admin/plugins/jvectormap/jquery-jvectormap-1.2.2.css", new CssRewriteUrlTransform())
                   .Include("~/Content/admin/plugins/datatables/jquery.dataTables.min.css", new CssRewriteUrlTransform())
                   .Include("~/Content/admin/plugins/datatables/dataTables.bootstrap.css", new CssRewriteUrlTransform())
                   .Include("~/Content/admin/plugins/datatables/jquery.dataTables_themeroller.css", new CssRewriteUrlTransform())
                   .Include("~/Content/admin/plugins/datepicker/datepicker3.css", new CssRewriteUrlTransform())
                   .Include("~/Content/admin/plugins/daterangepicker/daterangepicker-bs3.css", new CssRewriteUrlTransform())
                   .Include("~/Content/admin/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css", new CssRewriteUrlTransform())
               );

            bundles.Add(
                new ScriptBundle("~/Bundles/admin/plugins/js")
                    .Include("~/Content/admin/plugins/iCheck/icheck.min.js")
                    .Include("~/Content/admin/plugins/datatables/jquery.dataTables.min.js")
                    .Include("~/Content/admin/plugins/datatables/dataTables.bootstrap.min.js")
                    .Include("~/Content/admin/plugins/slimScroll/jquery.slimscroll.min.js")
                    .Include("~/Content/admin/plugins/fastclick/fastclick.min.min.js")
                );

            //~/Bundles/js
            bundles.Add(
                new ScriptBundle("~/Bundles/admin/js")
                    .Include("~/js/admin/main.js")
                );

            //APPLICATION RESOURCES

            //~/Bundles/css
            bundles.Add(
                new StyleBundle("~/Bundles/css")
                    .Include("~/css/main.css")
                );

            //~/Bundles/js
            bundles.Add(
                new ScriptBundle("~/Bundles/js")
                    .Include("~/js/main.js")
                );
        }
    }
}