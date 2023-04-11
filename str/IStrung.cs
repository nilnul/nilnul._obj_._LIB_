using System;

namespace nilnul.obj.str
{
	/// <summary>
	/// a str of str
	/// 
	/// </summary>
	///
	[Obsolete(nameof(ISplit))]
	public interface IStrung:
		ISplit
		,
		IStr,IStr<IStr>
	{
	}
}
