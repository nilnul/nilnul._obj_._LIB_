using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._abgebra.constant.str.convert_
{
	/// <summary>
	/// append one el to a str, and we will get a new str.
	/// </summary>
	/// <remarks>
	/// we can generate from <see cref="obj.vec_.Nono{T}"/> to <see cref="obj.vec_.Uno{T}"/>, to <see cref="obj.vec_.ICo"/>;
	/// </remarks>
	/// in set theory, we treat each instance of natural number as a set.
	/// in algebra, we treat each instance of natural number as a vec:
	///		(), ((),a)=(a), (((),a),b)=(a,b).
	///	each vec acts as both a constant, and a vec of contant.
	/// and we can map element to a vec of constant. now treat each constant as a vec.
	/// =================
	/// about the projection operator
	/// ----------------------
	///  eg: (x,y) ->x
	///  (x,y)->x  -->  x->x
	///  that is we can remove free variables as those is contextual, not local
	///  
	///  x->x --> (x,y)->x
	///  that is we can append on the left. that's context is catched.
	/// ======================
	/// about the definite operator
	/// ---------------------------
	/// eg:
	///		(x,y) ->1
	///	can we treat this as ()-> 1?
	///	
	///	For answering this, we consider:
	///   as in previous section, we can remove free variables to make it local.
	///   if we can do (x,y) ->x  --> x->x, we can do x->1 --> ()->1.
	///    
	///		(x,y) -> ( () ->1 ).
	///		(()->(x,y)) --> ( ()->1  )
	///		
	///
	///========================
	/// from constant to convert or other scala?
	/// --------------------------
	/// to get ()-> x, from ()->1:
	/// 
	/// ()->1
	/// (x)->1  //we can capture contextual var.
	/// ()->x --> ()->1
	///  here we can see on the left side we get: ()->x
	///
	/// ()->x
	/// (x)  --> (()->x)
	/// (()->x)  --> (()->x)
	///
	/// ()->x
	/// (y) ->x
	///
	/// 
	/// x->!x
	/// ()->x  -->  ()->!x
	///
	/// conversely:
	/// ()->x  -->  ()->!x
	/// x->!x
	/// 
	/// 
	/// we can now disregard elements, and consider only operators; the primitive transformation we need is this,
	internal class Increment
	{
	}
}
