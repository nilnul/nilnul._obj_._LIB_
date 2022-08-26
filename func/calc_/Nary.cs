using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_
{


	public class Nary : nilnul.obj.calc_.Nary<FuncI3>, CalcI,NaryI
	{
		public Nary(NaryI<FuncI3> op) : base(op)
		{
		}

		public Nary(FuncI3 r) : this( new obj.func.op_.Nary(r) )
		{
		}

		public Nary(
			obj.ExprI4 expr
		):this(
			new func_.Ni(expr)
		)
		{

		}
	}


}
