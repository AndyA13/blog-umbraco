[DocumentType(Description = "A folder to contain a years posts.")]
public class BlogYearFolder : DocumentTypeBase
{
	public BlogYearFolder()
	{
	}
	
	public BlogYearFolder(int nodeId)
		: base (nodeId)
	{
	}
}