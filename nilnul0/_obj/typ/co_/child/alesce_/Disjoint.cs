using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ.co_.child.alesce_
{

	/// <summary>
	/// as a subtype of P, this is disjoint with another subtype C.
	/// </summary>
	/// <typeparam name="P"></typeparam>
	/// <typeparam name="C"></typeparam>
	public interface IDisjoint<P,C>
		:
		typ.calc_.unary_.INot<C>
		

		where C:P ///directly child, or a directly child
	{
	}
}
