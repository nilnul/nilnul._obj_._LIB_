using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_._unary_
{
	[Obsolete()]
	public interface RetParI<out TRet, in TPar>:
		nilnul.obj._op.RetI<TRet>, 
		nilnul.obj.op_._unary_.ParI<TPar>
		,
		obj.of_.OfSingleI<TRet,TPar>
	{
		//TRet op(TPar par);
	}
}
