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
	public class Provise :
		
		ProvisionI
	{
		public const string Symbol = "->";


		private ParameterExpression _oldPar;

		public ParameterExpression oldPar
		{
			get { return _oldPar; }
			set { _oldPar = value; }
		}

		private nilnul.obj.ExprI4 _arg;

		public nilnul.obj.ExprI4 arg
		{
			get { return _arg; }
			set { _arg = value; }
		}

		public Provise( ParameterExpression oldPar0, obj.ExprI4 arg0 )
		{
			this._oldPar = oldPar0;
			this._arg = arg0;
		}

		public FuncI3 op(FuncI3 par)
		{
			return new nilnul.obj.Func3( _ProvisionX._Bind_assumeFunc(par.flat,this._oldPar,this._arg) );
			
		}
	}
}
