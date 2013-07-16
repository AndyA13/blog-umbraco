// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CategoryFolderController.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   The category folder controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Controllers
{
    using System.Web.Mvc;
    using Blog.Models.DocumentTypes;
    using Blog.Models.ViewModels;
    using Umbraco.Web.Models;
    using Umbraco.Web.Mvc;
    using Vega.USiteBuilder;

    /// <summary>
    /// The category folder controller.
    /// </summary>
    public class CategoryFolderController : RenderMvcController
    {
        /// <summary>
        /// The category list.
        /// </summary>
        /// <param name="renderModel">
        /// The render model.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult CategoryList(RenderModel renderModel)
        {
            CategoryFolder model = ContentHelper.GetByNodeId<CategoryFolder>(renderModel.Content.Id);

            CategoryListViewModel viewModel = new CategoryListViewModel
            {
                Content = model
            };

            // TODO: Magic number (1090 is category folder node id)
            foreach (Category category in ContentHelper.GetChildren<Category>(1090))
            {
                viewModel.Categories.Add(new CategoryViewModel { Name = category.Name, Url = category.Url });
            }

            return this.View("CategoryList", viewModel);
        }
    }
}