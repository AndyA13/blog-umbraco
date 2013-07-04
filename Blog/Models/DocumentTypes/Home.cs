// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Home.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   The home.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Models.DocumentTypes
{
    using Vega.USiteBuilder;

    /// <summary>
    /// The home.
    /// </summary>
    [DocumentType(Description = "The home page document type.", IconUrl = "home.png", AllowedChildNodeTypes = new[] { typeof(BlogYearFolder), typeof(CategoryFolder), typeof(FriendFolder) }, AllowedTemplates = new[] { "BlogPostList" })]
    public class Home : Meta
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Home"/> class.
        /// </summary>
        public Home()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Home"/> class.
        /// </summary>
        /// <param name="nodeId">
        /// The node id.
        /// </param>
        public Home(int nodeId)
            : base(nodeId)
        {
        }

        /// <summary>
        /// Gets or sets the about.
        /// </summary>
        [DocumentTypeProperty(UmbracoPropertyType.SimpleEditor, Description = "The text to appear in the about box.", Tab = "Content", Mandatory = false)]
        public string About { get; set; }
    }
}