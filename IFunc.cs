using nilnul.obj._func.lamda.be_.flat.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace nilnul.obj
{
	/// <summary>
	/// this is <see cref="real.IOp"/>; but it's not only <see cref="real.IOp"/>, but also <see cref="real.IExpr"/> as the body/logic; so it's structured data which can be compiled into an <see cref="obj.IOp"/>;
	/// </summary>
	/// we can use function to mean various arity, and func to mean unary funciton.
	public interface IFunc { }


	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TRet"> the type of the returned. </typeparam>
	///
	//[Obsolete(nameof(func_.typed_.IGeneri<TRet>))]
	public interface IFunc<TRet> : IFunc
	{

	}




}