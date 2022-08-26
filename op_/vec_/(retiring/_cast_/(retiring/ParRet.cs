using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._cast_
{
	[Obsolete(nameof(RetI<TPar,TRet>))]
	public interface ParRet< TPar,TRet>:
		nilnul.obj.op_._unary_.RetParI<TRet,TPar>
	{
	}
}
