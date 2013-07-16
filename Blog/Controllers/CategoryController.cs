// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CategoryController.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   Defines the CategoryController type.
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
    /// The category controller.
    /// </summary>
    public class CategoryController : RenderMvcController
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

            // TODO: Magic number (1089 = home page node id)
            List<BlogPost> blogPosts = ContentHelper.GetChildren<BlogPost>(1089, true).Where(p => p.CategoryId == renderModel.Content.Id).OrderByDescending(p => p.CreateDate).ToList();

            int totalPageCount = (int)Math.Ceiling((double)blogPosts.Count() / itemsPerPage);

            PagedPostList viewModel = new PagedPostList
            {
                Header = string.Format("{0} posts", renderModel.Content.Name),
                CurrentUrl = renderModel.Content.Url,
                PageNumber = pageNumber,
                TotalNumberOfPages = totalPageCount,
                Posts = blogPosts.Skip(itemsPerPage * (pageNumber - 1)).Take(itemsPerPage).ToViewModel()
            };

            return this.View("BlogPostList", viewModel);
        }
    }
}
