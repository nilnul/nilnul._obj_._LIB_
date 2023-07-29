using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{

	/// <summary>
	/// op is defined after "Rec", forming a closure on a higher new layer; a rec can result in an obj; something other than rec can also result in an obj.
	///
	/// vs:
	///		<see cref="obj.of_.INary"/>, the parameters of this is not necessarily nary;
	/// </summary>
	/// <remarks>
	/// be is nary, unary,binary, ternary, etc;
	/// </remarks>
	/// <typeparam name="TRet"></typeparam>
	///
	//[Obsolete(nameof(obj.IOp_involve<TRet>))]
	public interface IOp<out TRet>
		:IOp
		//where TRet:object
	{
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TRet"></typeparam>
	/// <typeparam name="TPar">the first input. There might be other inputs followed</typeparam>
	///
	[Obsolete(nameof(of_.IOfSingle<TRet,TPar>))]
	public interface IOp<out TRet,in TPar>
		:IOp<TRet>
	{
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TRet"></typeparam>
	/// <typeparam name="TPar"></typeparam>
	/// <typeparam name="TPar1">the second input. There might be other inputs followed</typeparam>
	///

	[Obsolete(nameof(of_.IOfCouple<TRet,TPar,TPar1>))]
	public interface IOp<out TRet,in TPar, in TPar1>
		:IOp<TRet,TPar>
	{
	}

	[Obsolete(nameof(of_.IOfTriple<TRet,TPar,TPar1,TPar2>))]
	public interface IOp<out TRet,in TPar,in TPar1,in TPar2>
		:IOp<TRet,TPar,TPar1>
	{
	}




}
