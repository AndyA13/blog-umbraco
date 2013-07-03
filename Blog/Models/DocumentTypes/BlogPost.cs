[DocumentType(Description = "A document type for a blog post.")]
public class BlogPost : Meta
{
	public BlogPost()
	{
	}
	
	public BlogPost(int nodeId)
		: base(nodeId)
	{
	}
	
	[DocumentTypeProperty(UmbracoContentType.RichTextEditor, Description = "The main body text for the blog post.", Tab = "Content", Mandatory = true)]
	public string BodyText { get; set; }
	
	[DocumentTypeProperty(UmbracoContentType.UltimatePicker, Description = "The category for this post.", Tab = "Content", Mandatory = true)]
	public int CategoryId { get; set; }
}