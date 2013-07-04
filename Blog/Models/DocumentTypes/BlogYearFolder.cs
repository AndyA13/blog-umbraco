// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BlogYearFolder.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   The blog year folder.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Models.DocumentTypes
{
    using Vega.USiteBuilder;

    /// <summary>
    /// The blog year folder.
    /// </summary>
    [DocumentType(Description = "A folder to contain a years posts.", IconUrl = "folder-open-document-text.png")]
    public class BlogYearFolder : DocumentTypeBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlogYearFolder"/> class.
        /// </summary>
        public BlogYearFolder()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlogYearFolder"/> class.
        /// </summary>
        /// <param name="nodeId">
        /// The node id.
        /// </param>
        public BlogYearFolder(int nodeId)
            : base(nodeId)
        {
        }
    }
}