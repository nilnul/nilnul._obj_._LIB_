using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj
{
	/// <summary>
	/// take 0-tuple, return a T
	/// </summary>
	public interface ConstantI
	{
	}

	public interface ConstantI<T> : ConstantI , _obj.op_.NillaryI<T>{
	}
}
