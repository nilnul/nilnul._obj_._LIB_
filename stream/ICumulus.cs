namespace nilnul.obj.stream
{
	/// <summary>
	/// using a str.Fold 
	/// </summary>
	/// vs:
	///		<see cref="stream.ISubsume"/>, the index of which is in sync with underlying stream, whileas the index of this is (the index of underlying stream's index -1 )
	/// <see cref="obj.op_.binary.cumulator"/>
	public interface ICumulus
		:
		nilnul.obj.IStream

	{

	}

}
