using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_._binary_.par1_
{
	public interface RetParPar1I1<out TRet, in TPar, in TPar1>:
		nilnul.obj._op_.RetI<TRet>, 
		nilnul.obj.op_._unary_.ParI<TPar>
		,
		nilnul.obj.op_._binary_.Par1I<TPar1>

	{
		TRet op(TPar par, TPar1 par1);
	}
}
