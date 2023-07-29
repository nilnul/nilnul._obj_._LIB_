using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.of_
{
	/// <summary>
	/// convert a supertype to a subtype
	/// </summary>
	/// <typeparam name="TRet"></typeparam>
	/// <typeparam name="TIn"></typeparam>
	/// <remarks>
	/// alias:
	///		constrict
	///			explict in reduce the scope
	///			corresponding to "construct", which is taking in types that are not only supertype, but also other type.
	///				construct is synnonym of "<seealso cref="nameof(obj.op_.IOf)"/>"
	///		coerce
	/// </remarks>
	public interface IConstrict<TRet, TIn>
		:
		op_.IOf<TRet,TIn>
		where TRet:TIn
	{
	}
}
