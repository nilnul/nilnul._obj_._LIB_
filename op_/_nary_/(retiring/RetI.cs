using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_._nulary_
{
	[Obsolete(nameof(obj.of_.NaryI<TRet>))]
	public interface RetI<out TRet>:
		
		nilnul.obj._op_.RetI<TRet>
		,
		obj.of_.OfEmptyI<TRet>
		,
		BlankI
	{
		//TRet op();
	}
}
