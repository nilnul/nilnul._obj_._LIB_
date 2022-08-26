using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_
{
	public interface IBinary {

	}
	public interface IBinary<TArg,TArg1,TReg> {

	}
	public interface IBinary_argSameType<TArg,TRet>:IBinary<TArg,TArg,TRet>
	{

	}
	public interface IBinary<TArg>:IBinary_argSameType<TArg, TArg> {

	}

	
}
