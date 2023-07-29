namespace nilnul.obj.stream_
{
	/// <summary>
	/// for a stream, we can prefetch one, and call it "current";
	/// when we call next, we return current, and prefetch another one to "current".
	/// if we want to keep the current, we shall cache it outside this;
	/// if we want to skip some items, and move directly the item[n], we need a method called next2discard, or renamed as "void moveNext()"
	/// 
	/// move one at a time. But you can peek ahead (not move multiple items as we still move one at a time) for extra items; we call this peek.
	/// </summary>
	/// <remarks>
	/// stream presents no current, or future;
	/// slider presents current, but not future;
	/// for future, <see cref="slider_.IPreview"/>
	/// </remarks>
	/// alias:
	///		stage
	///			stage one as current;
	public interface ISlider
		:
		stream_.scroll_.ISlider
		,
		stream_.IPrefetch
	{

	}
	public interface ISlider<T>:ISlider{

	}

}
