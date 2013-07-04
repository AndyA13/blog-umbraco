// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CategoryFolder.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   The category folder.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Models.DocumentTypes
{
    using Vega.USiteBuilder;

    /// <summary>
    /// The category folder.
    /// </summary>
    [DocumentType(Description = "A folder for containing the categories.", IconUrl = "category.png", AllowedChildNodeTypes = new[] { typeof(Category) }, AllowedTemplates = new[] { "CategoryList" })]
    public class CategoryFolder : DocumentTypeBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryFolder"/> class.
        /// </summary>
        public CategoryFolder()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryFolder"/> class.
        /// </summary>
        /// <param name="nodeId">
        /// The node id.
        /// </param>
        public CategoryFolder(int nodeId)
            : base(nodeId)
        {
        }
    }
}