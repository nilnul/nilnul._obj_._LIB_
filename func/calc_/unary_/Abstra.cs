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
	/// 
	/// </summary>
	/// alias:
	///		abstract
	///		curry
	public class Abstra
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


		public Abstra(obj.func.op_.unary_.Parameterize op, CalcI<FuncI3> arg) : base(op, arg)
		{
		}


		public Abstra(ParameterExpression par, CalcI<FuncI3> val) : this( new op_.unary_.Parameterize(par)  , val)
		{
		}
		public Abstra(ParameterExpression par, LambdaExpression val) : this( (par)  ,new calc_.Lamda(val))
		{
		}
		public obj.func.op_.unary_.Parameterize opAsPar { get {
				return this.op as obj.func.op_.unary_.Parameterize;
			} }
		public override string ToString()
		{
			var argTxt = this.arg.ToString();
			if (this.arg is calc_.IBinary)
			{
				argTxt = $"({argTxt})";
			}
			else if(this.arg is calc_.unary_.Abstra)
			{

			}
			else //uncurry
			{

			}
			return $"{(this.opAsPar.par) }{func.op_.unary_.Parameterize.Symbol}{argTxt}";
		}


	}
}
