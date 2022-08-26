using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.expr_.call_.unary_
{
	/// <summary>
	/// eg:
	///		x =>
	///			x1=>y
	/// </summary>
	public class Curry
		:
//		nilnul.obj.Box1<
//obj.func.op_.unary_.Parameterize
//			>
		Unary

		//,
		//calc_.UnaryI

		
	{
		

		//private obj.func.op_.unary_.Parameterize _op;

		//public obj.func.op_.unary_.Parameterize oper
		//{
		//	get { return _op; }
		//	set { _op = value; }
		//}

		//public UnaryI<FuncI3> op => _op;


		public Curry(obj.func.op_.unary_.Parameterize op, func.ExprI arg) : base(op, arg)
		{
		}

		public Curry(ParameterExpression par, func.ExprI val) : this( new op_.unary_.Parameterize(par)  , val)
		{
		}

		public obj.func.op_.unary_.Parameterize opAsPar
		{
			get
			{
				return this.op as obj.func.op_.unary_.Parameterize;
			}
		}
		public override string ToString()
		{
			var argTxt = this.arg.ToString();
			if (this.arg is calc_.IBinary)
			{
				argTxt = $"({argTxt})";
			}
			else if (this.arg is calc_.unary_.Abstra)
			{

			}
			else //uncurry
			{

			}
			return $"{(this.opAsPar.par) }{func.op_.unary_.Parameterize.Symbol}{argTxt}";
		}


	}
}
