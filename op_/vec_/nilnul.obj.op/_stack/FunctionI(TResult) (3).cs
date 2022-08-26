using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using nilnul.collection.set;
using nilnul.collection.tuple;

namespace nilnul.relation
{
	/// <summary>
	/// a function returns an object of the type of TResult.
	/// 
	/// its paramenter can be none,such as a constant, one, or indefinite number of variables, that's whether it's a number or a vector.
	/// </summary>
	/// <typeparam name="TResult">the returned type.</typeparam>
    public partial interface FunctionI<TResult> : FunctionI
	{
		//ISet domain
		//{
		//    get;
		//}
		//Expression<Func<TResult>> rule
		//{
		//    get;
        //}
		//ISet domain
		//{
		//    get;
		//   // set;
		//}

        /// <summary>
        /// Place holder for:
        /// A func that takes 
        ///     no parameter,
        ///     1 parameter,
        ///     2 or more parameters.
        ///  So it cannot be Expression<Func<TResult>>, for it's taking no parameter.it must be Expression<Func<TResult>>, Func<TArg1,TResult>,...'s common parent.
        /// </summary>
		//Func<TResult> rule
		//{
		//    get;
		//   // set;
		//}
    }
}
