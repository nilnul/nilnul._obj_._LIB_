using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace nilnul.obj.func.op_.unary_
{

	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// 
	/// </remarks>
	/// don't use "Param" for "Param" is a reserved token
	public class Parameterize :
		nilnul.obj.Box1<ParameterExpression>
		,
		ParI
	{
		public const string Symbol = _func_.GoesToSymbol.ForLamda;

		/// <summary>
		///
		/// </summary>
		/// <param name="val">  </param>
		public Parameterize(ParameterExpression val) : base(val)
		{
		}

		public ParameterExpression par { get { return boxed; } }

		public FuncI3 op(FuncI3 par)
		{
			return _ParX.Func(boxed, par);
			//throw new NotImplementedException();
		}
	}
}
