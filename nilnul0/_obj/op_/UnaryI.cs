using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.op_
{
	public interface UnaryI:OpI
		
	{

	}



	public interface UnaryI< out TRet, in TArg> : UnaryI, OpI<TRet> {
		TRet op(TArg arg);
	}

}
