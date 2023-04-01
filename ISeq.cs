namespace nilnul.obj
{
	/// <summary>
	/// a str or a stream. conceptualy same as <see cref="nameof(IEnumerable{T})"/>
	/// </summary>
	/// <remarks>
	/// recursion might be terminated by the termination condition.
	/// if the recursion is finite, it's a str
	/// if the recursion is infinite, it's a stream
	/// sometimes it is hard to tell whether it is finite or infinite. eg:Collatz seqence.
	/// </remarks>
	/// alias:
	///		sequence
	///		sequel
	///			que
	public interface ISeq { }	//for marker interface, the body is inline.
}
