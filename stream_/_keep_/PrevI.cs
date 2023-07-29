namespace nilnul.obj.stream_._keep_
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
	public interface PrevI<T>
		:obj.seq_._keep_.prev_.RefI<T>
	{
		//T ahead { get; }
	}


}
