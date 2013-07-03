
[DocumentType(Description = "A folder for containing the categories.")]
public class CategoryFolder : DocumentTypeBase
{
	public CategoryFolder ()
	{
	}
	
	public CategoryFolder(int nodeId)
		: base(nodeId)
	{
	}
}