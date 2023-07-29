namespace nilnul.obj.stream_._slider
{
	/// <summary>
	///		
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// alias:
	///		skim
	///		scroll
	///			reserved for peek of n terms
	///
	/// </remarks>
	public interface SkimI<T>
		:_skim_.MoveNextI, _skim_.CurrentI<T>
		,
		ISkim<T>

	{
	}
}
