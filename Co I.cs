using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/*An operator defined on a set  which takes two elements from  as inputs and returns a single element of . Binary operators are called compositions by Rosenfeld (1968). 
	 or combine
		 */

	[Obsolete()]
	public interface CoI
	{
	}

	[Obsolete()]
	public interface CoI<T>:CoI

	{
		T op(T x, T y);
	}


	 
}
