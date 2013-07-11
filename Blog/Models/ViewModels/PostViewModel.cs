// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PostViewModel.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   Defines the PostViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Models.ViewModels
{
    using System;
    using Blog.Models.DocumentTypes;

    /// <summary>
    /// The post view model.
    /// </summary>
    public class PostViewModel
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        public BlogPost Content { get; set; }

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the post date.
        /// </summary>
        public DateTime PostDate { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        public CategoryViewModel Category { get; set; }

        /// <summary>
        /// Gets or sets the tags.
        /// </summary>
        public string[] Tags { get; set; }

        /// <summary>
        /// Gets or sets the body content.
        /// </summary>
        public string BodyContent { get; set; }
    }
}