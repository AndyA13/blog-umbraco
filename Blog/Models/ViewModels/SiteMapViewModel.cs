// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SiteMapViewModel.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   Defines the SiteMapViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Models.ViewModels
{
    using System;

    /// <summary>
    /// The site map view model.
    /// </summary>
    public class SiteMapViewModel
    {
        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the last modified.
        /// </summary>
        public DateTime LastModified { get; set; }
    }
}