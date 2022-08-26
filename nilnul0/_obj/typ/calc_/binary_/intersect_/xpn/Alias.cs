using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ.calc_.binary_.intersect_.xpn
{
	/// <summary>
	/// to inherit this, the inheriter is equivant to <see cref="nameof(IXpn{A, B})"/>
	/// </summary>
	/// <typeparam name="A"></typeparam>
	/// <typeparam name="B"></typeparam>
	public interface IAlias<A,B>
		:
		IXpn<A,B>
		,
		nilnul._obj.typ.calc_.unary_.IAlias<
			IXpn<A,B>
		>
	{
	}
}
