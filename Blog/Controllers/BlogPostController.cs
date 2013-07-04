﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BlogPostController.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   Defines the BlogPostController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    using Blog.Models.ViewModels;

    using Umbraco.Web.Models;
    using Umbraco.Web.Mvc;

    using Vega.USiteBuilder;
    using Blog.Models.DocumentTypes;

    public class BlogPostController : RenderMvcController
    {
        /// <summary>
        /// The blog post.
        /// </summary>
        /// <param name="renderModel">
        /// The render model.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult BlogPost(RenderModel renderModel)
        {
            BlogPost post = ContentHelper.GetByNodeId<BlogPost>(renderModel.Content.Id);

            Category category = ContentHelper.GetByNodeId<Category>(post.CategoryId);

            CategoryViewModel categoryViewModel = new CategoryViewModel { Name = category.Name, Url = category.Url };

            PostViewModel viewModel = new PostViewModel()
                {
                    BodyContent = post.BodyText,
                    Category = categoryViewModel,
                    PostDate = post.CreateDate,
                    Title = post.Name,
                    Url = post.Url
                };


            return View("BlogPost");
        }

    }
}
