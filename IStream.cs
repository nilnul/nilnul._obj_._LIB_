namespace nilnul.obj
{
	/// <summary>
	/// vs <see cref="nameof(IEnumerable{T})"/>, no check of MoveNext() is needed. always movable to next.
	/// <see cref="nameof(IEnumerable{T})"/> uses "GetEnumerator()" to implement a subtype "slider" of Stream.
	/// </summary>
	/// <remarks>
	///eg:
	///	<see cref="System.Random"/>
	/// </remarks>
	public interface IStream
		:ISeq
	{


	}
}
