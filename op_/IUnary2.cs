using System;

namespace nilnul.obj.op_
{
	[Obsolete(nameof(obj.of_.IOfSingle<TRet,TPar>))]
	public interface IUnary<
		out
		TRet
		,
		in
		TPar
	>
		:
		IUnary //<TRet>
		,
obj.of_.IOfSingle<TRet,TPar>
	{

	}
	



}
