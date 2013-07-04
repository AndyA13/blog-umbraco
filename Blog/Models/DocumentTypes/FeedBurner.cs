// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FeedBurner.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   The feed burner.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Models.DocumentTypes
{
    using Vega.USiteBuilder;

    /// <summary>
    /// The feed burner.
    /// </summary>
    [DocumentType(Description = "Document for feedburner rss feed.", IconUrl = "fire.png", AllowedTemplates = new[] { "feedburner" })]
    public class FeedBurner : DocumentTypeBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeedBurner"/> class.
        /// </summary>
        public FeedBurner()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedBurner"/> class.
        /// </summary>
        /// <param name="nodeId">
        /// The node id.
        /// </param>
        public FeedBurner(int nodeId)
            : base(nodeId)
        {
        }
    }
}