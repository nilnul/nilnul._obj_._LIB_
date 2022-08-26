using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{

	///<summary>
	/// operation involves type T or rec of T, which might be in input, or output.
	/// By op we can let the type output/input with other types and be not isolated.
	/// </summary>
	/// <remarks>
	/// nomanclature:
	///		Op
	///			of parameter,
	/// </remarks>
	///
	public interface IOp
	{

	}

	/// <summary>
	/// op is defined after "Rec", forming a closure on a higher new layer; a rec can result in an obj; something other than rec can also result in an obj.
	/// </summary>
	/// <typeparam name="TRet"></typeparam>
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
	public interface IOp<out TRet,in TPar, in TPar1>
		:IOp<TRet,TPar>
	{
	}

	public interface IOp<out TRet,in TPar,in TPar1,in TPar2>
		:IOp<TRet,TPar,TPar1>
	{
	}

	public interface OpI<out TRet,in TPar,in TPar1,in TPar2>
		:IOp<TRet,TPar,TPar1,TPar2>
	{
		TRet op(TPar par, TPar1 par1, TPar2 par2);
	}


	public interface OpI<out TRet,in TPar,in TPar1>
		:IOp<TRet,TPar,TPar1>
		//,	OpI<TRet,TPar,TPar1,null>	//last TPar2 shall be understood as nothing
	{
		TRet op(TPar par, TPar1 par1);
	}


	public interface OpI1<out TRet,in TPar>
		:IOp<TRet,TPar>
		//,	OpI<TRet,TPar,null>	
	{
		TRet op(TPar par);
	}

	[Obsolete()]

	public interface OpI4<out TRet>
		:IOp<TRet>
		//,	OpI<TRet,null>	
	{
		TRet op();
	}

	public interface OpI1
		:IOp,
		OpI4<object>
	{
	}



}
