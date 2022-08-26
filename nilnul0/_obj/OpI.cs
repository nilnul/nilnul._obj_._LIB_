using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj
{
	/// <summary>
	/// convert from one type to another
	/// </summary>
	public interface OpI
	{
	}



	public interface OpI<out TRet>
		:OpI
	{

	}

	[Obsolete("",true)]

	public interface OpI<TRet, TPar>
		:OpI<TRet>
	{
		TRet op(TPar par);
	}
	[Obsolete("",true)]
	public interface OpI<TRet, TPar, TPar1>
		:OpI<TRet>
	{
		TRet op(TPar par,TPar par1);

	}

	[Obsolete("",true)]
	public interface OpI<TRet, TPar, TPar1,TPar2>
		:OpI<TRet>
	{
		TRet op(TPar par,TPar1 par1, TPar2 par2);

	}

	
}
