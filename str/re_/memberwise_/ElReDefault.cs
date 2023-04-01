using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.re_.memberwise_
{
	/// <summary>
	/// one is the other's initial segment. unforked
	/// </summary>
	/// alias:
	///		align
	///		compatible
	///		unforked
	///		
	public class ElReDefault<T,TRe>
		:
		re_.Memberwise<T>

		where TRe: obj.ReI<T>,new()
	{
		public ElReDefault() : base(
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TRe>.Instance
		)
		{
		}
	

	}
}
