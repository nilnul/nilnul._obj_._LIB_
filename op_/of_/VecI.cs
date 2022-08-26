using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.of_
{
	/// <summary>
	/// of a vector. This is a n-ary operator, but we dont know the arity statically.
	/// </summary>
	public interface VecI<T>
		:op_.of_.IOfVec
		,
		_vec_.ArityI
		,
		_vec_.OpI<T>
	{

	}
}
