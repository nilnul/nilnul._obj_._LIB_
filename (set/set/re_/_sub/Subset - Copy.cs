using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.set.re_
{
	[Obsolete(nameof(re_.Sub<T>) )]
	public class SubsetBetweenEnumerables<T> : nilnul.obj.ReI<IEnumerable<T>>
	{
		private IEqualityComparer<T> _elementEq;

		public IEqualityComparer<T> elementEq
		{
			get { return _elementEq; }
			set { _elementEq = value; }
		}
		public SubsetBetweenEnumerables(IEqualityComparer<T> elementEq)
		{
			_elementEq = elementEq;
		}

		public bool re(IEnumerable<T> x, IEnumerable<T> y)
		{
			return _Subset.Subset<T>(x, y, _elementEq);
			//throw new NotImplementedException();
		}
	}

}

