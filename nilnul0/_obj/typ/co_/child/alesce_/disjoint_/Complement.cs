using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ.co_.child.alesce_.disjoint_
{
	/// <summary>
	/// as a subtype of <typeparamref name="P"/>, this is a complement of another subtype <typeparamref name="C"/>
	/// This is the 
	/// </summary>
	/// <remarks>
	/// alias:
	///		comple
	/// </remarks>
	public interface IComplement<P,C>
		:IDisjoint<P,C>
		,
		typ.calc_.binary_.ISubtract<P,C>
		
		

		where C:P
	{
	}
}
