using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._cast_
{
	public interface RetI<in TObj, out TRet>:
		BlankI
		,
		nilnul.OpI1<TRet,TObj>

	{
	}
}
