using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.algebra_._cobiop_
{
	

	public interface AddI<T,TOp>
		where TOp: op_.BinaryI<T>
	{

		TOp add { get; }

	}
}
