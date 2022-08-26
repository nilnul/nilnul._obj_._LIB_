using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace nilnul.obj.func.op_.unary_.bind_
{

	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	/// don't use "Param" for "Param" is a reserved token
	public class Replace1st :
		nilnul.obj.Box1<nilnul.obj.ExprI4>
		,
		ProvisionI
	{
		/// <summary>
		/// similar to <see cref="op_.unary_.Parameterize.Symbol"/>, use some before ">"
		/// </summary>
		public const string Symbol = "->";
		public Replace1st(ExprI4 val) : base(val)
		{
		}

		public obj.ExprI4 arg { get { return boxed; } }

		public FuncI3 op(FuncI3 par)
		{
			return _ReplaceFirstX.Func( par,boxed);
			//throw new NotImplementedException();
		}
	}
}
