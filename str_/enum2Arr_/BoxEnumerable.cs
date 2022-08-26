using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_.enumerable_.enum2Arr_
{
	public class BoxEnumerable<T>
		: Enumerable2ArrA<T>
	{
		private IEnumerable<T> _enumerable;

		public IEnumerable<T> enumerable
		{
			get { return _enumerable; }
			set { _enumerable = value; }
		}

		public BoxEnumerable(IEnumerable<T> enumerable)
		{
			_enumerable = enumerable;
		}
		public override IEnumerator<T> GetEnumerator()
		{
			return _enumerable.GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
