using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ.re_
{


	/// <summary>
	/// the first is the parent of the second.
	/// </summary>
	class Parent
	{
		/// <summary>
		/// eg:
		///		for A:B in <see cref="Child"/>
		///		,we can repharse it as:
		///			B isParentOf A
		///			,or:
		///				B A
		///			,or:
		///				B :> A
		///				, where B is the parent.
		/// </summary>
		const string SYMBOL = " ";

	}
}
