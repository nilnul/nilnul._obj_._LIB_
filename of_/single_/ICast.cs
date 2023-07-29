using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.of_
{
	/// <summary>
	/// convert a subtype to a suptype. 
	/// </summary>
	/// <typeparam name="TRet"></typeparam>
	/// <typeparam name="TIn"></typeparam>
	///
	[Obsolete("This seems unworthy as a subtype is always a suptype.",true)]
	public interface ICast<TRet, TIn>
		:
		op_.IOf<TRet,TIn>
		where TIn:TRet
	{
	}
}
