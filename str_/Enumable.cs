using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_
{
	public class Enumable<T>
		: EnumableA<T>
	{
		private IEnumerable<T> _enumerable;

		public IEnumerable<T> enumerable
		{
			get { return _enumerable; }
			set { _enumerable = value; }
		}

		public Enumable(IEnumerable<T> enumerable)
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
