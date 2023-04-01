namespace nilnul.obj.stream
{

	/// <summary>
	/// at beginning, there is no current value; we must call next to get one;
	/// </summary>
	/// vs:
	///		<see cref="IStock"/>, but this cannot tackle empty str; So we must call next to get the first singleton str;
	///		<see cref="ICumulus"/>, where the start value is 0, if the operation is add; and we then call next, and add that to 0, and so on;
	///			the index of that -1 is the index of underlying stream; the index of this is the same as that of the underlying stream;
	/// alias:
	///		subsume
	///			"s" the intitial is also the initial of <see cref="ISeries"/>
	///			summary which is <see cref="ICumulus"/>
	public interface ISubsume
		:
		nilnul.obj.IStream

	{

	}

}
