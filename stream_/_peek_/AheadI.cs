namespace nilnul.obj.stream_._peek_
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
	///		next
	///			which might conflict with <see cref="_seq_.next_"/>
	public interface AheadI<T>
		:obj.seq_._peek_.next_.AheadI<T>
	{
		//T ahead { get; }
	}


}
