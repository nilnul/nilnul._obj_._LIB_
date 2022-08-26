using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda_.uni_.typed_
{

	public interface IGeneri<out TRet> : IUnary, func.calc_.lamda_.typed_.IGeneri<TRet> { }

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TIn">a subtype of <see cref="nilnul.obj_"/>
	///	if any input is beyond this type, an exception will be thrown, but the exception is still the subtype of <see cref="nilnul.obj_"/>
	/// </typeparam>
	/// <typeparam name="TOut">a subtype of <see cref="nilnul.obj_"/></typeparam>
	public interface IGeneri<in TIn, out TOut>
		:IGeneri<TOut>

	{

	}

	
}
