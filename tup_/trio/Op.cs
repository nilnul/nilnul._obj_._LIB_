using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.trio
{
	[Obsolete()]
	public interface OpI<T>
		:OpI<T,T,T,T>
	{
		
	}

	[Obsolete()]
	public class Op<T>:
		Op<T,T,T,T>
		,
		
		OpI<T>
	{

		public Op(Func<T,T,T,T> func):base(func)
		{

		}

	}


	public interface OpI<in P,in P1,in P2, out R>
		:nilnul._op.Generic<R>
	{
		R eval(P p, P1 p1, P2 p2);
	}

	public class Op<P, P1, P2, R>
		: OpI<P, P1, P2, R>
	{
		private Func<P,P1,P2,R> _func;

		public Func<P,P1,P2,R> func
		{
			get { return _func; }
			set { _func = value; }
		}

		public Op(Func<P,P1,P2,R> func)
		{
			_func = func;
		}

		public R eval(P p, P1 p1, P2 p2)
		{
			return _func(p, p1, p2);
			throw new NotImplementedException();
		}
	}


}
