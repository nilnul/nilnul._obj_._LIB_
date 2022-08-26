using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj
{
	/// <summary>
	/// given a type, convert  another type to it
	/// </summary>
	public interface OvI:OpI
	{

	}
	public interface OvI<TRet> : OpI<TRet> {

	}

	public interface OvI<TRet,TPar> :
		OvI<TRet>
		, 
		OpI<TRet, TPar>
	{

	}
}
