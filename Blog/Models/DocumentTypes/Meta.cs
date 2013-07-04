// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Meta.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   The meta.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Models.DocumentTypes
{
    using Vega.USiteBuilder;

    /// <summary>
    /// The meta.
    /// </summary>
    [DocumentType(Description = "Common base document for adding meta data to inherited document types.")]
    public class Meta : PageBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Meta"/> class.
        /// </summary>
        public Meta()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Meta"/> class.
        /// </summary>
        /// <param name="nodeId">
        /// The node id.
        /// </param>
        public Meta(int nodeId)
            : base(nodeId)
        {
        }

        /// <summary>
        /// Gets or sets the SEO title.
        /// </summary>
        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Description = "The title for this page.", Tab = "SEO", Mandatory = false)]
        public string SeoTitle { get; set; }

        /// <summary>
        /// Gets or sets the SEO description.
        /// </summary>
        [DocumentTypeProperty(UmbracoPropertyType.TextboxMultiple, Description = "The SEO description for this page.", Tab = "SEO", Mandatory = false)]
        public string SeoDescription { get; set; }
    }
}