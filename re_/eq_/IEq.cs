using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re_
{
	/// <summary>
	/// reflexive, symmetric, and transitive
	/// </summary>
	/// <typeparam name="T"></typeparam>
	///

	[Obsolete(nameof(re_.EqI<T>))]
	public interface IEq<T>
		: nilnul.obj.IRe
		,
		nilnul.obj.ReI<T>
	{
	}
	


}
