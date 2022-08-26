using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.op_.unary_
{
	public interface WithinSubsI<TResult,TPar, TParent>
		:
		UnaryI<TResult,TPar>

		where TResult:TParent
		where TPar:TParent
	{

	}
}
