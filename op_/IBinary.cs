using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_
{
	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		<see cref="obj.CombineI"/>
	public interface IBinary {

	}

	[Obsolete()]
	public interface IBinary<TArg,TArg1,TReg>
		:
		IBinary
	{

	}
	[Obsolete()]
	public interface IBinary_argSameType<TArg,TRet>:IBinary<TArg,TArg,TRet>
	{

	}


	public interface IBinary<TArg>
		:
		obj.of_.vec_.IOfCouple<TArg,TArg>
		,

		IBinary_argSameType<TArg, TArg>

	{

	}

	
}
