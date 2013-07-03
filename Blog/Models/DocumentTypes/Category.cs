
[DocumentType(Description = "A category for a blog post.")]
public class Category : DocumentTypeBase
{
	public Category()
	{
	}
	
	public Category(int nodeId)
		: base(nodeId)
	{
	}
}