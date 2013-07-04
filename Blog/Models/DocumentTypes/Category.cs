// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Category.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   The category.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Models.DocumentTypes
{
    using Vega.USiteBuilder;

    /// <summary>
    /// The category.
    /// </summary>
    [DocumentType(Description = "A category for a blog post.", IconUrl = "category.png", AllowedTemplates = new[] { "BlogPostList" })]
    public class Category : DocumentTypeBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Category"/> class.
        /// </summary>
        public Category()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Category"/> class.
        /// </summary>
        /// <param name="nodeId">
        /// The node id.
        /// </param>
        public Category(int nodeId)
            : base(nodeId)
        {
        }
    }
}