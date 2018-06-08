using System.Web;
using System.Web.Optimization;

namespace EcommerceWare
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                      "~/Content/js/jquery.scrollUp.min.js", 
                      "~/Content/js/jquery.prettyPhoto.js",
                        "~/Content/js/jquery.js",
                        "~/Scripts/jquery.unobtrusive-ajax.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Utilisez la version de développement de Modernizr pour le développement et l'apprentissage. Puis, une fois
            // prêt pour la production, utilisez l'outil de génération à l'adresse https://modernizr.com pour sélectionner uniquement les tests dont vous avez besoin.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/js/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/others").Include(

                     "~/Content/js/price-range.js",
                      "~/Content/js/main.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/font-awesome.min.css",
                      "~/Content/css/prettyPhoto.css",
                      "~/Content/css/price-range.css",
                      "~/Content/css/animate.css",
                      "~/Content/css/main.css",
                      "~/Content/css/responsive.css"));
        }
    }
}
