// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Friend.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   Defines the Friend type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Models.DocumentTypes
{
    using Vega.USiteBuilder;

    /// <summary>
    /// The friend.
    /// </summary>
    [DocumentType(Description = "A document for representing links to friends.", IconUrl = "user.png")]
    public class Friend : DocumentTypeBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Friend"/> class.
        /// </summary>
        public Friend()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Friend"/> class.
        /// </summary>
        /// <param name="nodeId">
        /// The node id.
        /// </param>
        public Friend(int nodeId)
            : base(nodeId)
        {
        }

        /// <summary>
        /// Gets or sets the link url.
        /// </summary>
        [DocumentTypeProperty(UmbracoPropertyType.Textstring, Description = "The url to the friends site.", Tab = "Content", Mandatory = true)]
        public string LinkUrl { get; set; }
    }
}