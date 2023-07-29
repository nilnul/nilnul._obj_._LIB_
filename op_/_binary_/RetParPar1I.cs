using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_._binary_
{
	/// <summary>
	/// <see cref="obj.op_._binary_.par1_.RetParPar1I1{TRet, TPar, TPar1}"/>
	/// </summary>
	/// <typeparam name="TRet"></typeparam>
	/// <typeparam name="TPar"></typeparam>
	/// <typeparam name="TPar1"></typeparam>
	///
	[Obsolete(nameof(obj.of_.OfCoupleI< TRet,  TPar,  TPar1>))]
	public interface RetParPar1I<out TRet, in TPar, in TPar1>:
		nilnul.obj._op_.RetI<TRet>, 
		nilnul.obj.op_._unary_.ParI<TPar>
		,nilnul.obj.op_._binary_.Par1I<TPar1>
		,
		nilnul.obj.op_._binary_.BlankI
		,
		obj.of_.OfCoupleI< TRet,  TPar,  TPar1>

	{
		//TRet op(TPar par, TPar1 par1);
	}
}
