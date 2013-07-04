// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PagedPostList.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   Defines the PagedPostList type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Models.ViewModels
{
    using System.Collections.Generic;

    /// <summary>
    /// The paged post list.
    /// </summary>
    public class PagedPostList
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PagedPostList"/> class.
        /// </summary>
        public PagedPostList()
        {
            this.Posts = new List<PostViewModel>();
        }

        /// <summary>
        /// Gets or sets the header.
        /// </summary>
        public string Header { get; set; }

        /// <summary>
        /// Gets or sets the posts.
        /// </summary>
        public List<PostViewModel> Posts { get; set; }

        /// <summary>
        /// Gets or sets the page number.
        /// </summary>
        public int PageNumber { get; set; }

        /// <summary>
        /// Gets or sets the total number of pages.
        /// </summary>
        public int TotalNumberOfPages { get; set; }

        /// <summary>
        /// Gets or sets the current url.
        /// </summary>
        public string CurrentUrl { get; set; }
    }
}