// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BlogPostController.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   Defines the BlogPostController type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Controllers
{
    using System.Web.Mvc;
    using Blog.Infrastructure;
    using Blog.Models.DocumentTypes;
    using Blog.Models.ViewModels;
    using Umbraco.Web.Models;
    using Umbraco.Web.Mvc;
    using Vega.USiteBuilder;

    /// <summary>
    /// The blog post controller.
    /// </summary>
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

            PostViewModel viewModel = post.ToViewModel();

            return this.View("BlogPost", viewModel);
        }
    }
}