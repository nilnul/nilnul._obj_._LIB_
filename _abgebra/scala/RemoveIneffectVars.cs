using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._abgebra.scala
{
	/// <summary>
	/// some variables can be regarded as nonlocal but contextual|environmental variables;
	/// for (x,y) ->x, we get:
	///		y -> (x->x)
	///	but here can we get 
	///		x-> ( ()->x )
	///		?
	/// note here  ()->x is not an operator. x is still dependent on outer environment. when the result is dependent on an outer environmental variable, it's not deemed as an operator, but as a funcitonal lamda;
	/// 
	/// 
	/// eg:
	///		(x,y) -> x
	///		, which is a projection, where y being ineffect can be removed.
	///		(x) -> 0
	///		,where x can be removed, and the result is ()->0.  This means that we can get nary operators from positive ary operators; in nilnul.bit, we prove complete set of ops using this proposition.
	/// </summary>
	/// alias:
	///		discard, like "_" in C#, denotes the ineffect vars.
	internal class RemoveIneffectVars
	{
	}
}
