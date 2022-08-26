using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.unary_
{
	
	public interface OfInI<T>:
		
		IUnary<T>

	{
		 T op(in T x);
	}
}
