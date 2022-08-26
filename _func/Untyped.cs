using nilnul.obj._func._untyped.sys.be_.func.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._func
{
	/// <summary>
	/// func lambda(expression). <see cref=" nameof(System.Linq.Expressions.LambdaExpression)"/>
	/// </summary>
	public interface IUntyped
	{

	}

	public interface UntypedI:IUntyped
	{
		_func._untyped.sys.be_.func.vow.Ee lambda { get; }

	}
	public class Untyped : _func._untyped.sys.be_.func.vow.Ee
		,
		UntypedI
	{
		public Untyped(Expression val) : base(val)
		{
		}

		public Ee lambda => this;
	}
}
