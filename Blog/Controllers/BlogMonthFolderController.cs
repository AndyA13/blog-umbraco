// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BlogMonthFolderController.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   Defines the BlogMonthFolderController type.
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
    /// The blog month folder controller.
    /// </summary>
    public class BlogMonthFolderController : RenderMvcController
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

            List<BlogPost> blogPosts = ContentHelper.GetChildren<BlogPost>(renderModel.Content.Id, false).OrderByDescending(p => p.CreateDate).ToList();

            int totalPageCount = (int)Math.Ceiling((double)blogPosts.Count() / itemsPerPage);

            int year = 2001;
            int.TryParse(renderModel.Content.Parent.Name, out year);

            int month = 1;
            int.TryParse(renderModel.Content.Name, out month);

            DateTime postDates = new DateTime(year, month, 1);

            PagedPostList viewModel = new PagedPostList
            {
                Header = string.Format("Posts from {0}", postDates.ToString("MMMM yyyy")),
                CurrentUrl = renderModel.Content.Url,
                PageNumber = pageNumber,
                TotalNumberOfPages = totalPageCount
            };

            IEnumerable<BlogPost> posts = blogPosts.Skip(itemsPerPage * (pageNumber - 1)).Take(itemsPerPage);

            foreach (BlogPost blogPost in posts)
            {
                Category category = ContentHelper.GetByNodeId<Category>(blogPost.CategoryId);

                viewModel.Posts.Add(new PostViewModel
                {
                    BodyContent = blogPost.BodyText,
                    Category = new CategoryViewModel { Name = category.Name, Url = category.Url },
                    PostDate = blogPost.CreateDate,
                    Title = blogPost.Name,
                    Url = blogPost.Url
                });
            }

            return this.View("BlogPostList", viewModel);
        }
    }
}