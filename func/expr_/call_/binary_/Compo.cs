using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.expr_.binary_
{
	/// <summary>
	/// eg:
	///		f |> g
	///		f |> (x=>x^5)
	///		(x=> x/2) *> (t=>5)
	/// </summary>
	public class Compo
		:
obj.func.expr_.call_.Binary
		
	{


		public Compo( func.ExprI arg, func.ExprI arg1) : base(obj.func.op_.binary_.CompoLeft2right.Singleton, arg, arg1)
		{
		}

		public override string ToString()
		{
			

			///no need of parenthesis.
			return $"{this.arg}{func.op_.binary_.CompoLeft2right.Singleton}{this.arg1}";
		}


	}
}
