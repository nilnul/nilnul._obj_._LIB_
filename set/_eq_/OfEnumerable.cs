using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set.eq_
{
	public class OfEnumerable<TElement, T2BeEnumerable>
		:IEqualityComparer<T2BeEnumerable>
	{

		

		private nilnul.obj.set.eq_.EqOfEnumerable<TElement> _setEq;

		public nilnul.obj.set.eq_.EqOfEnumerable<TElement> setEq
		{
			get { return _setEq; }
			//set { _setEq = value; }
		}
		private System.Func<T2BeEnumerable, IEnumerable<TElement>> _mappings;

		public Func<T2BeEnumerable,IEnumerable<TElement>> mappings
		{
			get { return _mappings; }
			set { _mappings = value; }
		}


		public OfEnumerable(IEqualityComparer<TElement> elementEq, System.Func<T2BeEnumerable, IEnumerable<TElement>> mappings)
		{
			_setEq = new EqOfEnumerable<TElement>(elementEq);
			_mappings = mappings;


		}

		public bool Equals(T2BeEnumerable x, T2BeEnumerable y)
		{

			return _setEq.Equals(_mappings(x),_mappings(y) );
			//throw new NotImplementedException();
		}

		public int GetHashCode(T2BeEnumerable obj)
		{
			return _setEq.GetHashCode(_mappings(obj));
			//throw new NotImplementedException();
		}
	}
}
