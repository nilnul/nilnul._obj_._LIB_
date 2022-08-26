using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ.child.calc_.binary_.intersect_.xpn
{
	/// <summary>
	/// to inherit this, the inheriter is equivant to <see cref="nameof(IXpn{P,A, B})"/>
	/// </summary>
	/// <typeparam name="A"></typeparam>
	/// <typeparam name="B"></typeparam>
	public interface IAlias<P, A,B>
		:
		IXpn<P, A,B>
		,
		nilnul._obj.typ.calc_.unary_.IAlias<
			IXpn<P,A,B>
		>
		where A:P
		where B:P
	{
	}
}
