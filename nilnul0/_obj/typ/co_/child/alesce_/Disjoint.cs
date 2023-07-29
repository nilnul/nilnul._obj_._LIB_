using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ.co_.child.alesce_
{

	/// <summary>
	/// Supposing X inherits this interface.
	/// as a subtype of P, X is disjoint with another subtype C.
	/// </summary>
	/// <remarks>
	/// C is the child of P;
	/// X is the child of P;
	/// C and X are disjoint;
	/// </remarks>
	/// <typeparam name="P">parent</typeparam>
	/// <typeparam name="C">child</typeparam>
	public interface IDisjoint<P,C>
		:
		typ.calc_.unary_.INot<C>
		

		where C:P ///directly child, or a directly child
	{
	}
}
