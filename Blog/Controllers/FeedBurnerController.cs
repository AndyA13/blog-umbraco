// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FeedBurnerController.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   The feed burner controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Blog.Models.DocumentTypes;
    using Umbraco.Web.Models;
    using Umbraco.Web.Mvc;
    using Vega.USiteBuilder;
    using Blog.Models.ViewModels;

    /// <summary>
    /// The feed burner controller.
    /// </summary>
    public class FeedBurnerController : RenderMvcController
    {
        /// <summary>
        /// The feed burner.
        /// </summary>
        /// <param name="renderModel">
        /// The render model.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult FeedBurner(RenderModel renderModel)
        {
            // Get 10 latest posts
            List<BlogPost> blogPosts = ContentHelper.GetChildren<BlogPost>(1089, true).OrderByDescending(p => p.CreateDate).Take(10).ToList();

            List<PostViewModel> viewPosts = new List<PostViewModel>();

            foreach (BlogPost blogPost in blogPosts)
            {
                viewPosts.Add(new PostViewModel()
                    {
                        BodyContent = blogPost.BodyText,
                        Title = blogPost.Name,
                        Url = blogPost.Url,
                        PostDate = blogPost.CreateDate,
                    });
            }

            return this.View("FeedBurner", viewPosts);
        }
    }
}
