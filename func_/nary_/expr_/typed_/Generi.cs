using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func_.expr_.typed_
{


	public class Generi<T> :
		nilnul.obj.Box1<
			nilnul.obj.Expr_sys<T>
		>
		,
		func_.INary

	{
		public Generi(Expr_sys<T> val) : base(val)
		{
		}

		public Generi(Expression x):this( new Expr_sys<T>(x) )
		{

		}
	}
}
