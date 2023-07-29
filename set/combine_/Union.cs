using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set.combine_
{
	public class Union<T>
	{
		private IEqualityComparer<T> _elementEq;

		public IEqualityComparer<T> elementEq
		{
			get { return _elementEq; }
			//set { _elementEq = value; }
		}

		public Union(IEqualityComparer<T> elementEq)
		{
			_elementEq = elementEq;
		}

		public HashSet<T> eval(IEnumerable<T> a, IEnumerable<T> b) {

			return new HashSet<T>(a.Concat(b), _elementEq);

		}

	}
}
