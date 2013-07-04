using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace Blog.Controllers
{
    using Blog.Models.DocumentTypes;
    using Blog.Models.ViewModels;
    using Umbraco.Web.Models;

    using Vega.USiteBuilder;

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

            foreach (Friend friend in ContentHelper.GetChildren<Friend>(1091))
            {
                viewModel.Friends.Add(new FriendViewModel { Name = friend.Name, Url = friend.LinkUrl });
            }

            return this.View("FriendList", viewModel);
        }
    }
}
