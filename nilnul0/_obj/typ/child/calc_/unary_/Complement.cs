using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ.child.calc_.unary_
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
		:
		co_.child.alesce_.disjoint_.IComplement<P, C>
		,
		typ.calc_.binary_.ISubtract<P,C>
		//,
		//typ.calc_.binary_.ISubtract<P,C>
		//,
		//nilnul.obj.IAlias< P>
		,
		typ.calc_.unary_.IAlias<P>
		

		where C:P
	{
	}
}
