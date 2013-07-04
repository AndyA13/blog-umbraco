// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PartialSurfaceController.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   The partial surface controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Blog.Controllers
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Web.Mvc;

    using Blog.Models.DocumentTypes;
    using Blog.Models.ViewModels;
    using Umbraco.Core.Models;
    using Umbraco.Web.Mvc;

    using Vega.USiteBuilder;

    /// <summary>
    /// The partial surface controller.
    /// </summary>
    public class PartialSurfaceController : SurfaceController
    {
        /// <summary>
        /// The about.
        /// </summary>
        /// <returns>
        /// The <see cref="PartialViewResult"/>.
        /// </returns>
        public PartialViewResult About()
        {
            Home home = ContentHelper.GetByNodeId<Home>(1089);

            return this.PartialView("AboutPartial", home.About);
        }

        /// <summary>
        /// The category list.
        /// </summary>
        /// <returns>
        /// The <see cref="PartialViewResult"/>.
        /// </returns>
        public PartialViewResult CategoryList()
        {
            List<CategoryViewModel> categories = new List<CategoryViewModel>();

            foreach (Category category in ContentHelper.GetChildren<Category>(1090))
            {
                categories.Add(new CategoryViewModel
                {
                    Name = category.Name,
                    Url = category.Url
                });
            }

            return this.PartialView("CategoryPartial", categories);
        }

        /// <summary>
        /// The friend list.
        /// </summary>
        /// <returns>
        /// The <see cref="PartialViewResult"/>.
        /// </returns>
        public PartialViewResult FriendList()
        {
            List<FriendViewModel> friends = new List<FriendViewModel>();

            foreach (Friend friend in ContentHelper.GetChildren<Friend>(1091))
            {
                friends.Add(new FriendViewModel{ Name = friend.Name, Url = friend.LinkUrl});
            }
        
            return this.PartialView("FriendPartial", friends);
        }
    }
}
