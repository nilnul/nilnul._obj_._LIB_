using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_._nulary_.ret_
{
	public interface ClosedI< TRet>:
		RetI<TRet> 
		,
		nilnul.obj._op_.ret_.ClosedI<TRet>
	{
	}
}
