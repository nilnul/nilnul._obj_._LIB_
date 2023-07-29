using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co.op_
{
	public interface UnaryI<T>
		:
		nilnul.obj.op_.UnaryI<(T,T)>
	{
	}
}
