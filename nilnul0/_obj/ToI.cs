using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._obj
{
	/// <summary>
	/// given a type, convert it to another type
	/// </summary>
	public interface ToI:OpI
	{

	}
	public interface ToI<TRet> : OpI<TRet> {

	}

	public interface ToI<TPar, TRet> :
		ToI<TRet>
		, 
		OpI<TRet, TPar>
	{ }
}
