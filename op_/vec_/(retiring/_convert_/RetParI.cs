using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._convert_
{
	public interface RetParI<out TRet, in TPar>:
		nilnul.obj.op_._unary_.RetParI<TRet,TPar>
	{
	}
}
