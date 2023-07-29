using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_
{
	/// <see cref="nilnul._obj.ITyp"/>. var as an expr is closed for a set of expr operations, but not so as nilnul.obj.Var in its own right in that it as obj.Var would be not closed for any usual operations.
	/// <summary>
	/// var is a way of expr an object, not the object itself.
	/// var can be a pointer, reference, or the value itself if the object is location-independent.
	/// for location-dependent ones, that's a relation between the location and the val.
	/// </summary>
	/// alias:
	///		variable
	///		indeterminate
	///		unknown
	///		parameter
	///		argument
	///		surrogate
	///		reference
	///		ref
	///		pointer
	public interface IVar {

	}
	

}
