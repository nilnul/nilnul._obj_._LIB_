using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.set;

namespace nilnul.relation
{
	/// <summary>
	/// a function takes no parameter and returns the tresult.
	/// 
	/// in fact it's a constant.
	/// </summary>
	/// <typeparam name="TResult"></typeparam>
	public partial interface Function0I<TResult>
		: Function0I,
		FunctionI<TResult>
	{

		TResult value
		{
			get;
			set;
		}
			
	}

	static public class Function0I_Extension
	{

		static public ExprI<ISet> Domain<TResult>(this Function0I<TResult> f) {
			return new UniversalSet();
		}

		static public IExpr<ISet<TResult>> Range<TResult>(this Function0I<TResult> f) {
			return new FiniteSet<TResult>(f.value);
		}
	}
}
