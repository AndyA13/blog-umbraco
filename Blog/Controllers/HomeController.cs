// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HomeController.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   The home controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Blog.Infrastructure;
    using Blog.Models.DocumentTypes;
    using Blog.Models.ViewModels;
    using Umbraco.Web.Models;
    using Umbraco.Web.Mvc;
    using Vega.USiteBuilder;

    /// <summary>
    /// The home controller.
    /// </summary>
    public class HomeController : RenderMvcController
    {
        /// <summary>
        /// The blog post list.
        /// </summary>
        /// <param name="renderModel">
        /// The render model.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult BlogPostList(RenderModel renderModel)
        {
            int pageNumber = 1;
            int itemsPerPage = 5;

            if (!string.IsNullOrEmpty(Request.QueryString["page"]))
            {
                int.TryParse(Request.QueryString["page"], out pageNumber);
            }

            List<BlogPost> blogPosts = ContentHelper.GetChildren<BlogPost>(renderModel.Content.Id, true).OrderByDescending(p => p.CreateDate).ToList();

            int totalPageCount = (int)Math.Ceiling((double)blogPosts.Count() / itemsPerPage);

            PagedPostList viewModel = new PagedPostList
            {
                Header = "All Posts",
                CurrentUrl = renderModel.Content.Url,
                PageNumber = pageNumber,
                TotalNumberOfPages = totalPageCount,
                Posts = blogPosts.Skip(itemsPerPage * (pageNumber - 1)).Take(itemsPerPage).ToViewModel()
            };

            return this.View("BlogPostList", viewModel);
        }
    }
}
