using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_._nulary_
{
	public interface RetI<out TRet>:
		
		nilnul.obj._op_.RetI<TRet> 
		,
		BlankI
	{
		TRet op();
	}
}
