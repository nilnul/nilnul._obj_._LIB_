using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ.child.calc_.unary_
{

	/// <summary>
	/// disjoint with another type C.
	/// </summary>
	/// <typeparam name="P"></typeparam>
	/// <typeparam name="C"></typeparam>
	public interface IDisjoint<P, C>
		:
		typ.calc_.unary_.INot<C>
		,
		typ.calc_.unary_.IAlias<P>		///also the child type of P
		where C:P
	{
	}
}
