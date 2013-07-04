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

            List<BlogPost> blogPosts = ContentHelper.GetChildren<BlogPost>(1089, true).Where(p => p.CategoryId == renderModel.Content.Id).ToList();

            int totalPageCount = (int)Math.Ceiling((double)blogPosts.Count() / itemsPerPage);

            PagedPostList viewModel = new PagedPostList
            {
                Header = string.Format("{0} posts", renderModel.Content.Name),
                CurrentUrl = renderModel.Content.Url,
                PageNumber = pageNumber,
                TotalNumberOfPages = totalPageCount
            };

            IEnumerable<BlogPost> posts = blogPosts.Skip(itemsPerPage * (pageNumber - 1)).Take(itemsPerPage);

            // Will all be the same category
            Category category = ContentHelper.GetByNodeId<Category>(renderModel.Content.Id);

            CategoryViewModel categoryViewModel = new CategoryViewModel { Name = category.Name, Url = category.Url };

            foreach (BlogPost blogPost in posts)
            {
                viewModel.Posts.Add(new PostViewModel
                {
                    BodyContent = blogPost.BodyText,
                    Category = categoryViewModel,
                    PostDate = blogPost.CreateDate,
                    Title = blogPost.Name,
                    Url = blogPost.Url
                });
            }

            return this.View("BlogPostList", viewModel);
        }
    }
}
