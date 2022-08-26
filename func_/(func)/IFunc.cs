using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	
	

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TRet"></typeparam>
	/// <typeparam name="TIn">the input</typeparam>
	///

	[Obsolete(nameof(func_.INary))]
	public interface IFunc<TRet, TIn> : IFunc<TRet> { }

	[Obsolete(nameof(func_.IBi))]
	public interface IFunc<TRet, TIn,TIn1> : IFunc<TRet> { }


}
