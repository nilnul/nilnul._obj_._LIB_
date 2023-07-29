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
	/// <typeparam name="TThisAsSrc"></typeparam>
	/// <typeparam name="TDst"></typeparam>
	/// <remarks>
	/// <seealso cref="nameof(nilnul.obj.OfI)"/>
	/// </remarks>
	///
	[Obsolete(nameof(obj.ITo))]
	public interface ToI<  out TDst, in TThisAsSrc>
		:ITo< TDst, TThisAsSrc>
		,
		nilnul.obj.OpI1<TDst,TThisAsSrc>
	{
		//TDst to(TSrc src);

	}

	[Obsolete(nameof(obj.ITo))]
	public interface ToI<out TDst>:ToI<TDst, object>
	{

	}


}
