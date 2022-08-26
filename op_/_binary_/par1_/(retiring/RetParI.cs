using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_._binary_
{
	[Obsolete()]
	public interface RetParPar1I<out TRet, in TPar, in TPar1>:
		nilnul.obj._op.RetI<TRet>, 
		nilnul.obj.op_._unary_.ParI<TPar>
		,
		nilnul.obj.op_._binary_.Par1I<TPar1>

	{
		TRet op(TPar par, TPar1 par1);
	}
}
