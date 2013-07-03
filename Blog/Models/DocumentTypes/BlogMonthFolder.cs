[DocumentType(Description = "A folder to contain a months posts.")]
public class BlogMonthFolder : DocumentTypeBase
{
	public BlogMonthFolder()
	{
	}
	
	public BlogMonthFolder(int nodeId)
		: base(nodeId)
	{
	}
}