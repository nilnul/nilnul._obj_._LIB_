using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace nilnul.obj.func.op_.unary_
{

	/// <summary>
	/// convert a n-ary function to a n-1 ary function;
	/// eg:
	///		(x,y) => x+y
	///		can be binded by x=5 as:
	///			(y) => 5+y
	///	eg:
	///		x=>x+1
	///		can be binded as x=5 as:
	///			()=>6
	///	eg:
	///		()=> 7
	///			can be binded as x=5 as:
	///				()=>7
	/// </summary>
	/// alias:
	///		apply
	///			bind
	///		provision
	///			same initial as parameterize;
	///		argumentate
	///		polish
	///		posh
	///		ration
	///		fare
	///		voucher
	///		coupon
	///		equip
	///		fulfill
	///		realize
	///		
	/// procure
	/// bind
	/// tie
	/// fetter
	/// substitute
	/// fillin
	/// assignment
	/// argumentation
	/// feed
	/// partial bind
	///
	///		bind
	///		apply
	///		applicaiton
	///		implicitization
	///			as in gemometry
	///		impl
	///		assign
	///		eval
	///		actualize
	///		reify
	///		call
	///		invoke
	///		exec
	///		exec
	///		cause
	///		specify
	///		valuate
	///		quantify
	///		reify

	public interface IProvision
	{

	}

}
