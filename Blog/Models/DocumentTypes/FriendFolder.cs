[DocumentType(Description = "A folder to contain friend links.")]
public class FriendFolder : DocumentTypeBase
{
	public FriendFolder()
	{
	}
	
	public FriendFolder(int nodeId)
		: base(nodeId)
	{
	}
}