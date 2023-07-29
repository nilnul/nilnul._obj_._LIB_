namespace nilnul.obj.stream_
{
	/// <summary>
	/// prefetch some next;
	/// n terms will be prefetched, where n=0,1,2,3...
	/// </summary>
	/// alias:
	///		preview
	///		peek
	///			reserved for stack.prefetch(1)
	///		prefetch
	///			the initial "P" is different from that of <see cref="IStream"/>, such that we can use temp(one letter) variable for each of the two terms;

	public interface IPrefetch :IStream{ }


}
