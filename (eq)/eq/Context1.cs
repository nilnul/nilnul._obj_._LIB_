using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.eq
{
	public class Context<T>

	{
		private IEqualityComparer<T> _eq;

		public IEqualityComparer<T> eq
		{
			get { return _eq; }
			//set { _eq = value; }
		}

		public Context(IEqualityComparer<T> eq)
		{
			_eq = eq;
		}

	}

	public class Context1<T, TEq>
		where TEq : IEqualityComparer<T>, new()
	{
		public TEq eq
		{
			get
			{
				return nilnul.obj.SingletonByDefault<TEq>.Instance;
			}
		}


		static public Context1<T, TEq> Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Context1<T, TEq>>.Instance;
			}
		}

	}
}
