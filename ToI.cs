using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{


	
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TSrc"></typeparam>
	/// <typeparam name="TDst"></typeparam>
	/// <remarks>
	/// <seealso cref="nameof(nilnul.obj.OfI)"/>
	/// </remarks>
	///
	//[Obsolete("wrong position of TDst")]	//we better make this a self-right concept from op
	public interface ToI<in TSrc, out TDst>
		:ITo<TSrc, TDst>
	{
		TDst to(TSrc src);

	}


	[Obsolete("")]
	public interface ToI<TTarget>:_to.SrcGenericI<object,TTarget>
	{

	}


}
