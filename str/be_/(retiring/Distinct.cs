using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_
{
	[Obsolete()]
	public class Distinct
	{



		static public bool Eval<T>(IEnumerable<T> str, IEqualityComparer<T> eq) {
			if (str.Any())
			{
				var tail = nilnul.obj.str_.started._TailX.Tail(str);
				return Eval<T>(tail,eq) && NotContainX.NotContain(tail, str.First(),eq);
			}
			return true;
		}

		public class OfEnumerable<T>:nilnul.obj.BeI<IEnumerable<T>>
		{
			private IEqualityComparer<T> _eq;

			public IEqualityComparer<T> eq
			{
				get { return _eq; }
				set { _eq = value; }
			}

			public OfEnumerable(IEqualityComparer<T> eq)
			{
				_eq = eq;
			}

			public bool be(IEnumerable<T> obj)
			{

				return Eval<T>(obj,_eq);
			}

			public class En : nilnul.obj.be.En<IEnumerable<T>>
			{
				public En(IEqualityComparer<T> eq, IEnumerable<T> val) : base(new OfEnumerable<T>(eq), val)
				{
				}
			}

			public class En<TEq> : En
				where TEq:IEqualityComparer<T>,new()
			{
				public En( IEnumerable<T> val) : base(SingletonByDefault<TEq>.Instance, val)
				{
				}
			}
		}


	}
}
