// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BlogMonthFolder.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   The blog month folder.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Models.DocumentTypes
{
    using Vega.USiteBuilder;

    /// <summary>
    /// The blog month folder.
    /// </summary>
    [DocumentType(Description = "A folder to contain a months posts.", IconUrl = "folder-open-document-text.png", AllowedChildNodeTypes = new[] { typeof(BlogPost) }, AllowedTemplates = new[] { "BlogPostList" })]
    public class BlogMonthFolder : Meta
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlogMonthFolder"/> class.
        /// </summary>
        public BlogMonthFolder()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlogMonthFolder"/> class.
        /// </summary>
        /// <param name="nodeId">
        /// The node id.
        /// </param>
        public BlogMonthFolder(int nodeId)
            : base(nodeId)
        {
        }
    }
}