namespace nilnul.obj.seq.scroll_
{
	/// <summary>
	/// for stream, we can have something prefetched, and the next one is the first one of the prefetched, and we will replenish the prefetched.
	/// </summary>
	/// alias:
	///		preview
	///		lookahead
	/// 
	public interface IPrefetch
		:IScroll
	{
	}

}
