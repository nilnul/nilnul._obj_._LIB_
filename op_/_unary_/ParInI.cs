
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_._unary_
{
	public interface ParInI<out TRet,  TPar>
		:
		nilnul.obj._op_.RetI<TRet>
	{
		TRet op(in TPar par);
	}
}
