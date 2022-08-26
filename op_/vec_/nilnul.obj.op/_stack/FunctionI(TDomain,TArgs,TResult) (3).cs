using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using nilnul.collection.set;

namespace nilnul.relation
{
	/// <summary>
	/// Function is only a logic or rule, so it doesn't requre more of the input arguments unless the rule cannot proceed with the variable. For the function might have other function such as operator in its logic, so the arguments have to pass through their rules as well, thus form the domain.
	/// 
	/// We 'll have in mind that no more constraints should be placed until the rule is breaked. Specificly, we can use the same function to compute with real numbers as well as random variables, for random varialbes takes real values and the computation goes with the values they took.
	/// 
	/// 
	/// Return tight, input as loose as possible!
	/// 
	/// The range and codomain of f are the same only when f is surjective. range &lt codomain.
	/// 
	/// </summary>
	/// <typeparam name="TArg1"></typeparam>
	/// <typeparam name="TResult"></typeparam>
	public interface FunctionI<TDomain,TArgs,TResult>
		where TDomain:SetI<TArgs>
	{
		TDomain domain
		{
			get;
		}

		/// <summary>
		/// is this necessary? note that codomain is indefinite for any set that is superset of range is a codomain. Answer: leave this to relation.
		/// </summary>
		//ISet<TResult> codomain
		//{
		//    get;
		//}
		SetI<TResult> range
		{
			get;
		}

		Expression<Func<TArgs, TResult>> rule
		{
			get;

		}
	}
}
