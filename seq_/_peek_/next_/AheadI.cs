namespace nilnul.obj.seq_._peek_.next_
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
	{
		T ahead { get; }
	}


}
