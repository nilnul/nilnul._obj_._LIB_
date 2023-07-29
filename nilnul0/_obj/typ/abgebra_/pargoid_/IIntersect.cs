using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.typ.abgebra_.pargoid_
{
	/// <summary>
	/// A & B =B & A
	/// 
	/// A & A = A
	/// 
	/// if A:B, then A & B= A
	///
	/// 
	/// if ! (A:B) or !(B:>A), then A&B =C, where C might be undefined or defined.
	/// eg:
	///		D:A, D:B, then D <=C, where C:A&B, and C might be not coded, or we can just write AB in place of C.
	///
	///
	/// AB might be empty|<see cref="_obj.typ_.INoninstantiable"/>
	/// </summary>
	/// <remarks>
	/// this is not closed as AB might be undefined.
	/// 
	/// </remarks>
	/// 
	internal class IIntersect
	{
	}


}
