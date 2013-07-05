// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BlogSiteMapController.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   The site map controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Controllers
{
    using System.Collections.Generic;
    using System.Web.Mvc;
    using Blog.Models.ViewModels;
    using umbraco.MacroEngines;
    using Umbraco.Web.Models;
    using Umbraco.Web.Mvc;

    /// <summary>
    /// The site map controller.
    /// </summary>
    public class BlogSiteMapController : RenderMvcController
    {
        /// <summary>
        /// The site map.
        /// </summary>
        /// <param name="renderModel">
        /// The render model.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult SiteMapTemplate(RenderModel renderModel)
        {
            List<SiteMapViewModel> sitemapElements = new List<SiteMapViewModel>();

            DynamicNode homepage = new DynamicNode(1089);

            if (homepage.GetProperty("showInSiteMap") != null && homepage.GetProperty("showInSiteMap").Value == "1")
            {
                sitemapElements.Add(new SiteMapViewModel { Url = homepage.Url, LastModified = homepage.UpdateDate });
            }

            DynamicNodeList sitemapPages =
                homepage.Descendants(
                    n => n.GetProperty("showInSiteMap") != null && n.GetProperty("showInSiteMap").HasValue() && n.GetProperty("showInSiteMap").Value == "1");

            foreach (DynamicNode page in sitemapPages)
            {
                sitemapElements.Add(new SiteMapViewModel { Url = page.Url, LastModified = page.UpdateDate });
            }

            return this.View("SiteMapTemplate", sitemapElements);
        }
    }
}
