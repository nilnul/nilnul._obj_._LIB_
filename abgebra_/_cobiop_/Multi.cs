using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.abgebra_._cobiop_
{
	

	public interface MultiI<T,TOp>
		where TOp: op_.BinaryI<T>
	{

		TOp multi { get; }

	}
}
