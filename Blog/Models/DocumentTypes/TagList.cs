// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TagList.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   Defines the TagList type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Models.DocumentTypes
{
    using Vega.USiteBuilder;

    /// <summary>
    /// The tag list.
    /// </summary>
    [DocumentType(Description = "A document for listing tags.", IconUrl = "tags-label.png", AllowedTemplates = new[] { "TagList", "TagPostList" })]
    public class TagList : Meta
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagList"/> class.
        /// </summary>
        public TagList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagList"/> class.
        /// </summary>
        /// <param name="nodeId">
        /// The node id.
        /// </param>
        public TagList(int nodeId)
            : base(nodeId)
        {
        }
    }
}