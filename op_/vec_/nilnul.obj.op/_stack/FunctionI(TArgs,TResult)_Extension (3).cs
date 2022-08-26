using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.set;

namespace nilnul.relation
{
	static public class FunctionI_Extension
	{
		static public ExprI<SetI<TResult>> Range<TArgs,TResult>(this FunctionI<TArgs,TResult> function) {

			return new Range<TResult>(function);
		}

		static public ExprI<TResult> Call<TArgs, TResult>(this FunctionI<TArgs,TResult> function,TArgs argument) {

			return new FunctionCall<TArgs,TResult>(function,argument);

		}
	}
}
