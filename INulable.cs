namespace nilnul.obj
{
	/// 
	/// <summary>
	/// a pointer to an object can be pointing to nowhere, in which case we call it null; (even the pointer is stuffed a special value; in a world of nonnul, we have a special value observed for nul;)
	/// </summary>
	/// alias:
	///		nilnul.obj.INulable=nilnul.obj0nul
	///		nulish
	///		nulable
	///		nuly
	///			fro nulish;
	///	vs
	///		<see cref="obj_.INulable"/>
	///			we need sorted to get an unordered
	///			we need a set to get empty
	///			we need obj to get nulable
	///		so for obj_, we have <see cref="obj_.Nul"/> but not <see cref="obj_.INulable"/>
	///		
	public interface INulable { }
}
