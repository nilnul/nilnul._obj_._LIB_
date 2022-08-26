using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.of_._vec_
{
	public interface OpI<T>
	{
		T op( IEnumerable<T> vec);
	}
}
