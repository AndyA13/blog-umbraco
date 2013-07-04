// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CategoryListViewModel.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   The category list view model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Models.ViewModels
{
    using System.Collections.Generic;
    using Blog.Models.DocumentTypes;

    /// <summary>
    /// The category list view model.
    /// </summary>
    public class CategoryListViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryListViewModel"/> class.
        /// </summary>
        public CategoryListViewModel()
        {
            this.Categories = new List<CategoryViewModel>();
        }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        public CategoryFolder Content { get; set; }

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        public List<CategoryViewModel> Categories { get; set; }
    }
}