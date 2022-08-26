using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.binary_
{
	/// <see cref="System.Linq.Expressions.LambdaExpression"/> doesnot support Compo
	/// <summary>
	/// 
	/// </summary>
	public class Compo
		:
obj.func.calc_.Binary
		
	{


		public Compo( CalcI<FuncI3> arg, CalcI<FuncI3> arg1) : base(obj.func.op_.binary_.CompoLeft2right.Singleton, arg, arg1)
		{
		}

		public Compo( LambdaExpression val, LambdaExpression val1) : base(obj.func.op_.binary_.CompoLeft2right.Singleton, val, val1)
		{
		}

		public override string ToString()
		{
			//var argParen0not = this.arg.ToString();
			//if (this.arg1 is binary_.Compo )
			//{

			//}

			///no need of parenthesis.
			return $"{this.arg}{func.op_.binary_.CompoLeft2right.Singleton}{this.arg1}";
		}
	}
}
