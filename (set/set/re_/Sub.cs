using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.set.re_
{
	public class Sub<T>
		:
		nilnul.obj.ReI<IEnumerable<T>>
	{
		private IEqualityComparer<T> _elementEq;

		public IEqualityComparer<T> elementEq
		{
			get { return _elementEq; }
			set { _elementEq = value; }
		}
		public Sub(IEqualityComparer<T> elementEq)
		{
			_elementEq = elementEq;
		}

		public Sub():this(EqualityComparer<T>.Default)
		{

		}

		public bool re(IEnumerable<T> a, IEnumerable<T> sup)
		{
			return a.All(x => sup.Contains(x, elementEq));

			//throw new NotImplementedException();
		}

		public bool _re_assumeSameElEq(HashSet<T> a, HashSet<T> sup)
		{
			return a.IsSubsetOf(sup);

			//throw new NotImplementedException();
		}


		static public Sub<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<Sub<T>>.Instance;
			}
		}

	}

}

