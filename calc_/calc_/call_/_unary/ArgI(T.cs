using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.call_._unary
{
	public interface ArgI<out T>
	{
		T arg { get; }
	}
}
