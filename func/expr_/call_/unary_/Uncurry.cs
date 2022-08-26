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
	/// bind.
	/// eg:
	///		x -> f
	///		x -> (y=> y*z)
	/// </summary>
	public class Uncurry
		:
//		nilnul.obj.Box1<
//obj.func.op_.unary_.Parameterize
//			>
		Unary

		//,
		//calc_.UnaryI

		
	{
		

	


		public Uncurry(obj.func.op_.unary_.bind_.Replace1st op, func.ExprI arg) : base(op, arg)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="arg4op"></param>
		/// <param name="func"> when the type of <paramref name="arg4op"/> mismatches with the type <paramref name="func"/>'s first par, there would be unexpected error/exception when both the func and the arg are argumentated.</param>
		public Uncurry(nilnul.obj.ExprI4 arg4op, func.ExprI func)
			:
			this(
				new op_.unary_.bind_.Replace1st(arg4op)  , func
			)
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
