using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr._vars.lambda
{
	public class Visitor4pars : System.Linq.Expressions.ExpressionVisitor
	{
		private expr_.var.SetOfVars _vars=new expr_.var.SetOfVars();

		

		public expr_.var.SetOfVars vars
		{
			get { return _vars; }
			//set { _vars = value; }
		}
		

		protected override Expression VisitParameter(ParameterExpression node)
		{
			_vars.Add(
				
					node
				
			);
			return base.VisitParameter(node);
		}
	}
}
