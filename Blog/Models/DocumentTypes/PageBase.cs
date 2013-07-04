// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PageBase.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   The page base.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Models.DocumentTypes
{
    using Vega.USiteBuilder;

    /// <summary>
    /// The page base.
    /// </summary>
    [DocumentType(Description = "A base document type for defining site wide properties.")]
    public class PageBase : DocumentTypeBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageBase"/> class.
        /// </summary>
        public PageBase()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageBase"/> class.
        /// </summary>
        /// <param name="nodeId">
        /// The node id.
        /// </param>
        public PageBase(int nodeId)
            : base(nodeId)
        {
        }

        /// <summary>
        /// Gets or sets a value indicating whether show in site map.
        /// </summary>
        [DocumentTypeProperty(UmbracoPropertyType.TrueFalse, Name = "Show in sitemap", Description = "Whether this page should appear in the site map.", Tab = "SEO")]
        public bool ShowInSiteMap { get; set; }
    }
}