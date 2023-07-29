using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_
{
	[Obsolete(nameof(obj.of_.OfCoupleI< TRet,  TPar,  TPar1>))]
	public interface BinaryI<out TRet, in TPar, in TPar1>
		:
		_binary_.RetParPar1I<TRet,TPar,TPar1>
	{
		//TRet op(TPar a,TPar1 b);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TRet"></typeparam>
	/// <typeparam name="TPars">
	/// vs:base, the pars are a co, of same type rather than a duo of different types;
	/// </typeparam>
	///

	[Obsolete(nameof(obj.of_.vec_.OfCoupleI< TRet,  TPars>))]
	public interface BinaryI<out TRet, in TPars>
		:
obj.of_.vec_.OfCoupleI< TRet,  TPars>
		,
		BinaryI<TRet,TPars,TPars >
		,
		op_.IUnary<TRet, obj.ICo>
	{
	}


	public interface BinaryI<T>
		:
		obj.of_.vec_.OfCoupleI<T,T>
		,
		BinaryI<T,T>
		,
		_binary_.par1_.retParPar1_.ClosedI<T>
		,
		_binary_.BlankI
		,
		IBinary<T>

	{
	}

	//[Obsolete(nameof(obj.of_.BinaryI))]
	public interface BinaryI :
		_binary_.retParPar1_.ClosedI<object>, OpI
		,
		BinaryI<object>

	{
	}
}
