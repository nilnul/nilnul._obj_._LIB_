namespace nilnul.obj
{
	/// <summary>
	/// a str or a stream. conceptualy same as <see cref="nameof(IEnumerable{T})"/>;
	/// </summary>
	/// <remarks>
	/// for seq, we don't have the luxuray of <see cref="nilnul.obj._stream_.NextI<T>"/>, so we have to moveNext and see if there is one; if it does have one, we use current to retrieve it;
	/// recursion might be terminated by the termination condition.
	/// if the recursion is finite, it's a str
	/// if the recursion is infinite, it's a stream
	/// sometimes it is hard to tell whether it is finite or infinite. eg:Collatz seqence.
	/// </remarks>
	/// alias:
	///		sequence
	///		sequel
	///			que
	///	vs:
	///		<see cref="stream_._slider.ISkim"/> which is for infinite stream, whileas this can be used for finite str.
	public interface ISeq { }	//for marker interface, the body is inline.
}
