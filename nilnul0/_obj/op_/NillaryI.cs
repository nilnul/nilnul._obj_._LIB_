using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.op_
{
	public interface NillaryI:OpI
	{
	}
	public interface NillaryI<T> : OpI<T> {
		T op();
	}
}
