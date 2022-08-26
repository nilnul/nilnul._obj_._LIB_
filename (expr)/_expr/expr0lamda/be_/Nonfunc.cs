using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._expr.expr0lamda.be_
{
	/// <summary>
	/// no pars
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Nonlamda : _expr.expr0lamda.BeI
	{
		public bool be(Expression obj)
		{
			
			return !(obj is System.Linq.Expressions.LambdaExpression );
			//throw new NotImplementedException();
		}



		static public Nonlamda Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Nonlamda>.Instance;
			}
		}


	}
}
