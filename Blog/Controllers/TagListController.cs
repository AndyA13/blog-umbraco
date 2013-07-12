using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace Blog.Controllers
{
    using Blog.Infrastructure;

    using Umbraco.Web.Models;

    using Vega.USiteBuilder;

    using umbraco.cms.businesslogic;
    using umbraco.cms.businesslogic.Tags;
    using Blog.Models.ViewModels;
    using Blog.Models.DocumentTypes;

    public class TagListController : RenderMvcController
    {
        public ActionResult Index(RenderModel renderModel)
        {
            int pageNumber = 1;
            int itemsPerPage = 5;

            if (!string.IsNullOrEmpty(Request.QueryString["page"]))
            {
                int.TryParse(Request.QueryString["page"], out pageNumber);
            }


            if (!string.IsNullOrEmpty(Request.QueryString["tag"]))
            {
                string tag = Request.QueryString["tag"];

                IEnumerable<CMSNode> taggedNodes = Tag.GetNodesWithTags(tag);

                taggedNodes = taggedNodes.OrderBy(n => n.CreateDateTime);

                int totalPageCount = (int)Math.Ceiling((double)taggedNodes.Count() / itemsPerPage);

                PagedPostList viewModel = new PagedPostList
                {
                    Header = string.Format("Posts tagged {0}", tag),
                    CurrentUrl = renderModel.Content.Url,
                    PageNumber = pageNumber,
                    TotalNumberOfPages = totalPageCount
                };

                IEnumerable<CMSNode> pagedNodes = taggedNodes.Skip(itemsPerPage * (pageNumber - 1)).Take(itemsPerPage);

                foreach (CMSNode node in pagedNodes)
                {
                    BlogPost post = ContentHelper.GetByNodeId<BlogPost>(node.Id);

                    viewModel.Posts.Add(post.ToViewModel());
                }

                return this.View("TagPostList", viewModel);
            }

            IEnumerable<Tag> tags = Tag.GetTags();
            
            return this.View("TagList", tags);
        }

    }
}
