using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ.co_.child.alesce_.disjoint_
{
	/// <summary>
	/// Supposing X inherits this interface.
	/// as a subtype of <typeparamref name="P"/>, X is a complement of another subtype <typeparamref name="C"/>
	/// </summary>
	/// <remarks>
	/// C is the child of P;
	/// X is the child of P;
	/// C and X are disjoint;
	/// C together with X   =   P;
	/// </remarks>
	/// alias:
	///		comple
	/// 
	public interface IComplement<P,C>
		:IDisjoint<P,C>
		,
		typ.calc_.binary_.ISubtract<P,C>
		
		

		where C:P
	{
	}
}
