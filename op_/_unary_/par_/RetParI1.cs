
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_._unary_.par_
{
	public interface RetParI1<out TRet, in TPar>:
		nilnul.obj._op_.RetI<TRet>, 
		nilnul.obj.op_._unary_.ParI<TPar>
	{
		TRet op(TPar x);
	}
}
