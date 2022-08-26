using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj.op_
{
	public interface BinaryI:OpI
		
	{

	}



	public interface BinaryI< out TRet, in TPar, in TPar1> : BinaryI, OpI<TRet> {
		TRet op(TPar arg, TPar1 par1);
	}

}
