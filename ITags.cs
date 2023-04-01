namespace nilnul.obj
{
	/// <summary>
	/// this can be analog to the content of JSON, but tag can be not keyVal.
	/// </summary>
	/// <remarks>
	/// can be embedded recursively, somewhat like the content of Json; but here we use ';' rather ',';
	/// 
	/// </remarks>
	/// maybe we shall consider using ',' instead of ';' ? note ',' is used in <see cref="nilnul.IObjs"/>;
	///		we can use collection as value and for collection, we need ',' as in:
	///			key1: member0,member1,...
	/// alias:
	///		annotation
	///		memo
	///		note
	///		review
	///		comment
	public interface ITags:nilnul.IObjs<ITag>
	{
	}
}
