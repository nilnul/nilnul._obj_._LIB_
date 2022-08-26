using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

	public interface IStrung<T>:IStrung, IStr<IStr<T>>
	{
	}

	public interface StrungI<T>:IEnumerable<IEnumerable<T>>,IStrung<T> { }
}
