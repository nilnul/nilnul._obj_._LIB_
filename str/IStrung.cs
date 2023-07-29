using System;

namespace nilnul.obj.str
{
	/// <summary>
	/// a str of str
	/// 
	/// </summary>
	/// alias:
	///		jagged array
	///	vs:
	///		<see cref="obj.IMatrix"/>, which requires that each member is of the same length;
	///
	[Obsolete(nameof(ISplit))]
	public interface IStrung:
		ISplit
		,
		IStr,IStr<IStr>
	{
	}
}
