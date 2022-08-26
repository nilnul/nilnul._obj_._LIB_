using nilnul.obj._func;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FuncI1 = nilnul.obj._func.FuncI_dynamic;
using nilnul.obj.var.set.ordered;
using nilnul.obj._func.func;
using System.Linq.Expressions;
using nilnul.obj.func.op_.unary_;
using nilnul.obj.expr;
using static nilnul.obj.expr._VarsX1;

namespace nilnul.obj.func.op_.binary_
{
	/// <summary>
	/// apply one func to another. This is defferent from <see cref="ICompo"/> in that compo is "concat" two funcs, whileas <see cref="IApply"/> is feed one func as the argument into another func's body.
	/// </summary>
	public interface IApply
		:op_.IBinary
	{ }

}
