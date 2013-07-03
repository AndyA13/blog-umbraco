[DocumentType(Description = "A document for representing links to friends.")]
public class Friend : DocumentTypeBase
{
	public Friend()
	{
	}
	
	public Friend(int nodeId)
		: base(nodeId)
	{
	}
	
	[DocumentTypeProperty(UmbracoContentType.TextString, Description = "The url to the friends site.", Tab = "Content", Mandatory = true)]
	public string LinkUrl { get; set; }
}