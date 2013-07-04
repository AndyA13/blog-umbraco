// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BlogPost.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   The blog post.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Models.DocumentTypes
{
    using Vega.USiteBuilder;

    /// <summary>
    /// The blog post.
    /// </summary>
    [DocumentType(Description = "A document type for a blog post.")]
    public class BlogPost : Meta
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlogPost"/> class.
        /// </summary>
        public BlogPost()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BlogPost"/> class.
        /// </summary>
        /// <param name="nodeId">
        /// The node id.
        /// </param>
        public BlogPost(int nodeId)
            : base(nodeId)
        {
        }

        /// <summary>
        /// Gets or sets the body text.
        /// </summary>
        [DocumentTypeProperty(UmbracoPropertyType.RichtextEditor, Description = "The main body text for the blog post.", Tab = "Content", Mandatory = true)]
        public string BodyText { get; set; }

        /// <summary>
        /// Gets or sets the category id.
        /// </summary>
        [DocumentTypeProperty(UmbracoPropertyType.UltimatePicker, Description = "The category for this post.", Tab = "Content", Mandatory = true)]
        public int CategoryId { get; set; }
    }
}