using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_
{

	//[Obsolete("use "+ nameof(IOp<TTgt>) + " instead;" )]
	public interface IOf<out TTgt>
		:
		nilnul.obj.IOp<TTgt>
		//,
		//obj.IOp_involve<TTgt>
		,
		obj.op_.IOf
	{ }

	/// <summary>
	///  an op that is taking in only one parameter
	/// </summary>
	/// <remarks>
	/// nomenclature:
	///		note "of" is graphically opposite to "to"
	///	alias:
	///		fro
	///		from
	///		on
	///			is used in evt, such as onclick
	///		ov
	///			ov is used at a more basic layer: on the generic type parameter
	///			over
	///		convert
	///		construct
	///		constrict
	///		contract
	///		coerce
	///		cast
	///		create
	///		contrive
	///		
	///			
	/// </remarks>
	[Obsolete("use "+ nameof(IOp) + " instead;" )]
	public interface IOf< out TThisAsRet , in RIn > :
		IOf<TThisAsRet>
		,

		nilnul.obj.IOp<TThisAsRet>		///todo del
		,
		nilnul.obj.IOp<TThisAsRet, RIn>
	{
	}

	public interface IOf< out TThisAsRet ,in RIn, in RIn1> :
		IOf< TThisAsRet, RIn>
		,

		nilnul.obj.IOp<TThisAsRet,RIn,RIn1>		
	{
	}
	public interface IOf< out TThisAsRet , in RIn, in RIn1, in RIn2 > :
		IOf< TThisAsRet,RIn, RIn1>
		,

		nilnul.obj.IOp<TThisAsRet,RIn,RIn1,RIn2>		
	{
	}

	public interface OfI< out TThisAsRet,in TArg, in TArg1, in TArg2>:
		IOf< TThisAsRet,  TArg, TArg1,TArg2>
		,
		nilnul.obj.OpI<TThisAsRet,TArg,TArg1,TArg2>
	{

	}

	public interface OfI< out TThisAsRet,in TArg, in TArg1>:
		IOf<  TThisAsRet, TArg,TArg1>
		,
		nilnul.obj.OpI<TThisAsRet,TArg,TArg1>
	{
		//TRet of(TArg arg);
	}



	public interface OfI1<out TThisAsRet,in TArg >:
		IOf<  TThisAsRet, TArg>
		,
		nilnul.obj.OpI1<TThisAsRet,TArg>
	{
		//TRet of(TArg arg);
	}

	[Obsolete()]

	public interface OfI1<out TThisAsRet>
		:
		IOf<TThisAsRet>
		,
		nilnul.obj.OpI4<TThisAsRet>
	{

	}


	public interface OfI
		:
		IOf
		,
		OfI1<object>
	{

	}



}
