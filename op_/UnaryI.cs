using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_
{
	[Obsolete(nameof(obj.of_.OfSingleI<TRet,TPar>))]
	public interface UnaryI<out TRet, in TPar>
		:
		//_unary_.par_.RetParI1<TRet,TPar>
		//,
		obj.of_.OfSingleI<TRet,TPar>
		,
		IUnary<TRet,TPar>
	{
	}

	public interface UnaryI<T>
		:
		obj.of_.OfSingleI<T,T>
		//,
		//UnaryI<T,T>
		//,
		//_unary_.par_.retPar_.ClosedI1<T>
		//,
		//_unary_.BlankI
		,
		IUnary<T>

	{
	}
	



}
