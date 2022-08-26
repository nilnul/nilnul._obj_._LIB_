using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.commutative
{
	/// <summary>
	/// for a given commutative binary op:*, nilard is an element, x,  such that x*y=x, where y is any element
	/// </summary>
	public interface NilardI<T, TCommmutive>
		where TCommmutive:nilnul.obj.op_.binary_.CommutableI<T>
	{

	}

}
