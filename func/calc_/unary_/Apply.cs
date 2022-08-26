using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.unary_
{
	/// <summary>
	/// <see cref="System.Linq.Expressions.LambdaExpression"/> doesnot support application; or we can customize it in the body of the func being built.
	/// </summary>
	public class Apply
		:
//		nilnul.obj.Box1<
//obj.func.op_.unary_.Parameterize
//			>
		Unary

		//,
		//calc_.UnaryI

		
	{

		public Apply(obj.func.op_.unary_.bind_.Replace1st op, CalcI<FuncI3> arg) : base(op, arg)
		{
		}



		public Apply(nilnul.obj.ExprI4 par, CalcI<FuncI3> val)
			:
			this(
				new op_.unary_.bind_.Replace1st(par)  , val
			)
		{
		}
		public Apply(ExprI4 par, LambdaExpression val) : this( (par)  ,new calc_.Lamda(val))
		{
		}

		public op_.unary_.bind_.Replace1st opAsApply
		{
			get { return this.op as op_.unary_.bind_.Replace1st; }
		}

		public override string ToString()
		{
			var funcTxt = this.arg.ToString();
			if (this.arg is calc_.IBinary)
			{
				funcTxt = $"({funcTxt})";
			}
			else if (this.arg is calc_.unary_.Abstra)
			{

			}
			else //uncurry
			{

			}


			return $"{(this.opAsApply.arg) }{func.op_.unary_.Provise.Symbol}{funcTxt}";
		}


	}
}
