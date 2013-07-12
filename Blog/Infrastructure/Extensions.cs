// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Extensions.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   Defines the Extensions type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Infrastructure
{
    using System.Collections.Generic;
    using System.Linq;
    using Blog.Models.DocumentTypes;
    using Blog.Models.ViewModels;
    using Vega.USiteBuilder;

    /// <summary>
    /// The extensions.
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Converts a list of blog posts to their view model.
        /// </summary>
        /// <param name="posts">
        /// The posts.
        /// </param>
        /// <returns>
        /// The <see cref="IEnumerable&lt;PostViewModel&gt;"/>.
        /// </returns>
        public static List<PostViewModel> ToViewModel(this IEnumerable<BlogPost> posts)
        {
            return posts.Select(blogPost => blogPost.ToViewModel()).ToList();
        }

        /// <summary>
        /// Converts a post to its view model.
        /// </summary>
        /// <param name="post">
        /// The post.
        /// </param>
        /// <returns>
        /// The <see cref="PostViewModel"/>.
        /// </returns>
        public static PostViewModel ToViewModel(this BlogPost post)
        {
            Category category = ContentHelper.GetByNodeId<Category>(post.CategoryId);

            string[] tags = post.Tags != null ? post.Tags.Split(',') : new string[0];

            return new PostViewModel
            {
                BodyContent = post.BodyText,
                Category = new CategoryViewModel { Name = category.Name, Url = category.Url },
                Content = post,
                PostDate = post.CreateDate,
                Tags = tags,
                Title = post.Name,
                Url = post.Url
            };
        }
    }
}