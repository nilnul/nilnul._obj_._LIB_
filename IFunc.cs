using nilnul.obj._func.lamda.be_.flat.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace nilnul.obj
{
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