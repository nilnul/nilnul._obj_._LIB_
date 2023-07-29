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
	public interface SkidI<T>
		:_skid_.MoveNextI, _skid_. CurrentI<T>
		,
		ISkid<T>

	{
	}
}
