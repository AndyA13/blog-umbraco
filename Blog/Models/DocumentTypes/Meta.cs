[DocumentType(Description = "Common base document for adding meta data to inherited document types.")]
public class Meta : DocumentTypeBase
{
	public Meta()
	{
	}
	
	public Meta(int nodeId)
		: base(nodeId)
	{
	}
	
	[DocumentTypeProperty(UmbracoContentType.TextString, Description = "The title for this page.", Tab = "SEO", Mandatory = false)]
	public string SEOTitle { get; set; }
	
	[DocumentTypeProperty(UmbracoContentType.TextMultiLine, Description = "The SEO description for this page.", Tab = "SEO", Mandatory = false)]
	public string SEODescription { get; set; }
}