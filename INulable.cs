using System;

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
	///		<see cref="IObj0nul"/>
	///			for value type such as int, int0null means int? ( int or null), int.nulable means int?
	///			for reference type T, the T itself can null, but as developer, we shall never allow it to be null. Rather, we use <see cref="obj.INulable"/> to mean we allow null for even the same type T.
	///				eg:
	///					txt0null means string allowing null. txt.nulable means string allowing null;
	///					int0nul means int or null. int.nulable means int or null.
	///				so we only have a null issue for reference type. value type can never be null. for value type double, it allows a NaN, but that's an issue local to double itself only.
	///		<see cref="obj_.INulable"/>
	///			we need sorted to get an unordered
	///			we need a set to get empty
	///			we need obj to get nulable
	///		so for obj_, we have <see cref="obj_.Nul"/> but not <see cref="obj_.INulable"/>
	///

	[Obsolete(nameof(nilnul.IObj0nul) + " is explicit about obj0nul is parallel to, not an extension to, obj the type;")]
	public interface INulable
		//:nilnul.IObj0nul
	{ }
}
