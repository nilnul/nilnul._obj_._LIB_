using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.call_
{
	/// <summary>
	/// eg:
	///		bool bePositve(int x) is a call,but not unary . It's an "of expression", taking in a par of one type, and return another type
	/// </summary>
	public interface IOf
	{
	}
	public interface IOf<TRet> : IOf, ICall<TRet> { }

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TRet"></typeparam>
	/// <typeparam name="TIn">the input</typeparam>
	public interface IOf<TRet, TIn> : IOf<TRet> {

	}
	public interface IOf<TRet, TIn, TIn1> : IOf<TRet> {

	}
}
/* not necessary, as allow heterogenous typed args in binary/unary*/
