// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FriendFolder.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   Defines the FriendFolder type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Models.DocumentTypes
{
    using Vega.USiteBuilder;

    /// <summary>
    /// The friend folder.
    /// </summary>
    [DocumentType(Description = "A folder to contain friend links.", IconUrl = "users.png", AllowedChildNodeTypes = new[] { typeof(Friend) }, AllowedTemplates = new[] { "FriendList" })]
    public class FriendFolder : DocumentTypeBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FriendFolder"/> class.
        /// </summary>
        public FriendFolder()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FriendFolder"/> class.
        /// </summary>
        /// <param name="nodeId">
        /// The node id.
        /// </param>
        public FriendFolder(int nodeId)
            : base(nodeId)
        {
        }
    }
}