using System.Web;
using System.Web.Optimization;

namespace TurnerWebTest
{
	public class BundleConfig
	{
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jquery-{version}.js"));

			bundles.Add(new ScriptBundle("~/Content/css").Include(
					"~/Content/Site.css"));
			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
						"~/Scripts/modernizr-*"));

			bundles.Add(new ScriptBundle("~/bundles/angular").Include(
					  "~/Scripts/angular.js",
					  "~/Scripts/respond.js"));

			bundles.Add(new ScriptBundle("~/bundles/app").Include(
					  "~/Scripts/App/mainApp.js",
					  "~/Scripts/App/eventModule.js",
					  "~/Scripts/App/searchTitlesModule.js"));
		}
	}
}
