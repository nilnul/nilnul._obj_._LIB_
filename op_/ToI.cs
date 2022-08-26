using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_
{
	/// <summary>
	/// construct from known struct  of objects, to another type.
	/// If the result type is already defined, we fall into our known realm of knowledge.
	/// If the reuslt type is not defined, we either throw out exception, or we need to extend our knowledge, to construct new types on basis of current types..
	/// </summary>
	public interface ITo
		:IOp
	{

	}

	public interface ITo< out TDst> :ITo { }

	public interface ITo< out TDst, in TSrc> :ITo<TDst> { }




	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TThisAsSrc"></typeparam>
	/// <typeparam name="TDst"></typeparam>
	/// <remarks>
	/// <seealso cref="nameof(nilnul.obj.OfI)"/>
	/// </remarks>
	///

	public interface ToI<  out TDst, in TThisAsSrc>
		:ITo< TDst, TThisAsSrc>
		,
		nilnul.obj.OpI1<TDst,TThisAsSrc>
	{
		//TDst to(TSrc src);

	}

	public interface ToI<out TDst>:ToI<TDst, object>
	{

	}


}
