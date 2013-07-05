// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SiteMap.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   The site map.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Models.DocumentTypes
{
    using Vega.USiteBuilder;

    /// <summary>
    /// The site map.
    /// </summary>
    [DocumentType(Description = "Site map document type.", IconUrl = "sitemap.png", AllowedTemplates = new[] { "SiteMapTemplate" })]
    public class BlogSiteMap : DocumentTypeBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SiteMap"/> class.
        /// </summary>
        public BlogSiteMap()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SiteMap"/> class.
        /// </summary>
        /// <param name="nodeId">
        /// The node id.
        /// </param>
        public BlogSiteMap(int nodeId)
            : base(nodeId)
        {
        }
    }
}