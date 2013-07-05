// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FourOhFour.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   The four oh four.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Models.DocumentTypes
{
    using Vega.USiteBuilder;

    /// <summary>
    /// The four oh four.
    /// </summary>
    [DocumentType(Description = "Document type for 404 page.", IconUrl = "user-silhouette-question.png", AllowedTemplates = new[] { "NotFound" })]
    public class FourOhFour : Meta
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FourOhFour"/> class.
        /// </summary>
        public FourOhFour()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FourOhFour"/> class.
        /// </summary>
        /// <param name="nodeId">
        /// The node id.
        /// </param>
        public FourOhFour(int nodeId)
        : base(nodeId)
        {
        }

        /// <summary>
        /// Gets or sets the body text.
        /// </summary>
        [DocumentTypeProperty(UmbracoPropertyType.RichtextEditor, Description = "The message on the page.", Name = "Body text", Tab = "Content", Mandatory = true)]
        public string BodyText { get; set; }
    }
}