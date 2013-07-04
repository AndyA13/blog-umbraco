// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FriendListViewModel.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   The friend list view model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Models.ViewModels
{
    using System.Collections.Generic;
    using Blog.Models.DocumentTypes;

    /// <summary>
    /// The friend list view model.
    /// </summary>
    public class FriendListViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FriendListViewModel"/> class.
        /// </summary>
        public FriendListViewModel()
        {
            this.Friends = new List<FriendViewModel>();
        }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        public FriendFolder Content { get; set; }

        /// <summary>
        /// Gets or sets the friends.
        /// </summary>
        public List<FriendViewModel> Friends { get; set; }
    }
}