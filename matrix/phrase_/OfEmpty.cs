using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.phrase_
{
	/// <summary>
	///
	/// for empty matrix, we enclose the matrix with a pair of parenthesis. The parenthesis shall be scaled to express the vec's arity.
	/// eg:
	///		/\
	///		\/
	///		this is a 0*0 matrix. we have 0 ()s.
	///		
	///		/-\
	///		\-/
	///		this is a 0*1 matrix. we have 0  unary vecs
	///		
	///		/---\
	///		\---/ 0*3. we have 0 ternary vecs.
	///		
	///		/\
	///		[]
	///		\/ 1*0. we have one vec, which is 0-ary.
	///		
	///		/\
	///		[]
	///		[]
	///		[]
	///		\/ 3*0. we have 3 vecs, each of which is 0-ary.
	///		
	///		
	/// </summary>
	class OfEmpty
	{
	}
}
