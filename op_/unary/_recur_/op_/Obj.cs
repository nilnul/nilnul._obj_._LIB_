using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.unary._recur_.op_
{
	public interface ObjOpI<T,TOp>:_recur_.OpI<TOp>
		where TOp: nilnul.obj.op_.UnaryI<T>
	{

	}
}
