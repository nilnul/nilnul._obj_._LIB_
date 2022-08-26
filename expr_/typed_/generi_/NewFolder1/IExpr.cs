using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{

	

	/// <summary>
	/// an expression that, if all vars are substituted by vals, evaluates to an instance of <typeparamref name="T"/>.
	/// <see cref="nameof(System.Linq.Expressions.Expression)"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	///
	[Obsolete()]
	public interface IExpr<out T> : IExpr {

	}
}
