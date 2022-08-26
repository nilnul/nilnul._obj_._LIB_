using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.unary._ed_
{
	public interface ResultI<out T>
	{
		T result {
			get;
		}
	}
}
