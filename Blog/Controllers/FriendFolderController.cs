// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FriendFolderController.cs" company="Andrew Aitken">
//   Andrew Aitken
// </copyright>
// <summary>
//   Defines the FriendFolderController type.
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
    /// The friend folder controller.
    /// </summary>
    public class FriendFolderController : RenderMvcController
    {
        /// <summary>
        /// The friend list.
        /// </summary>
        /// <param name="renderModel">
        /// The render model.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult FriendList(RenderModel renderModel)
        {
            FriendFolder model = ContentHelper.GetByNodeId<FriendFolder>(renderModel.Content.Id);

            FriendListViewModel viewModel = new FriendListViewModel
            {
                Content = model
            };

            // TODO: Magic number (1091 is friend folder node ID)
            foreach (Friend friend in ContentHelper.GetChildren<Friend>(1091))
            {
                viewModel.Friends.Add(new FriendViewModel { Name = friend.Name, Url = friend.LinkUrl });
            }

            return this.View("FriendList", viewModel);
        }
    }
}
