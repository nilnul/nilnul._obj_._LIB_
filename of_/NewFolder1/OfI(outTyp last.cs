using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_
{

	/// <summary>
	/// return to the specific type. the input type needs be further scaled down
	/// </summary>
	public interface IOf:nilnul.obj.IOp { }

	public interface IOf<out TTgt>:nilnul.obj.IOp<TTgt> { }



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
	public interface IOf< out TThisAsRet , in RIn > :
		IOf<TThisAsRet>
		,

		nilnul.obj.IOp<TThisAsRet>		///todo del
		,
		nilnul.obj.IOp<TThisAsRet, RIn>
	{
	}

	public interface IOf< out TThisAsRet ,in RIn, in RIn1> :
		IOf<RIn, TThisAsRet>
		,

		nilnul.obj.IOp<TThisAsRet,RIn,RIn1>		
	{
	}
	public interface IOf< out TThisAsRet , in RIn, in RIn1, in RIn2 > :
		IOf<RIn,RIn1, TThisAsRet>
		,

		nilnul.obj.IOp<TThisAsRet,RIn,RIn1,RIn2>		
	{
	}

	public interface OfI<in TArg, in TArg1, in TArg2, out TThisAsRet>:
		IOf<  TArg, TArg1,TArg2, TThisAsRet>
		,
		nilnul.obj.OpI<TThisAsRet,TArg,TArg1,TArg2>
	{

	}

	public interface OfI<in TArg, in TArg1, out TThisAsRet>:
		IOf<  TArg,TArg1, TThisAsRet>
		,
		nilnul.obj.OpI<TThisAsRet,TArg,TArg1>
	{
		//TRet of(TArg arg);
	}



	public interface OfI1<in TArg, out TThisAsRet>:
		IOf<  TArg, TThisAsRet>
		,
		nilnul.obj.OpI1<TThisAsRet,TArg>
	{
		//TRet of(TArg arg);
	}

	public interface OfI1<in TArg> :
		OfI1<TArg, object>
		
	{
	}

	public interface OfI_ovRet<out TRet>
		:
		
		IOf
		,
		nilnul.obj.OpI4<TRet>
	{
	}

	public interface OfI_ovRet
		:
		
		IOf
		,
		OfI_ovRet<object>
	{
	}



}
