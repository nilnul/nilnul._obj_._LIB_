using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda_.uni_.closed_
{
	

	public interface IGeneri< TRet> : IClosed, func.calc_.lamda_.typed_.IGeneri<TRet> { }



	public class Generi<TRet>
		:
		func.calc_.lamda_.uni_.closed.be_.typed_.generi.vow.Ee<TRet>
		,
		IGeneri<TRet>
	{
		public Generi(Closed val) : base(val)
		{
		}

		public Generi(Expression<Func<TRet,TRet> > p):this(new Closed(p) )
		{
		}
		public Generi(LambdaExpression p):this(new Closed(p) )
		{
		}

	}
}
