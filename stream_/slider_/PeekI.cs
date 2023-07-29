namespace nilnul.obj.stream_.slider_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// alias:
	///		peek
	///		lookahead;
	///		ahead
	///			a(one) head
	public interface PeekI<T>
		: SliderI<T>
		,
		_peek_.AheadI<T>
		,
		IPeek
		//,
		//preview_.IAhead
		//,
		//IPreview
		
	{
		//T ahead { get; }
	}


}
