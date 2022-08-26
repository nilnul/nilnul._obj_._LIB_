using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq_.enumerable.vow_.finite
{
	public class Ed<T> 
		: 
		nilnul.obj.vow.Ed<IEnumerable<T>, nilnul.obj.seq_.enumerable.be_.finite.Vow<T>>
		,
		IEnumerable<T>
	{
		public Ed(IEnumerable<T> val) : base(val)
		{

		}

		public IEnumerator<T> GetEnumerator()
		{
			return ed.GetEnumerator();
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();

			throw new NotImplementedException();
		}
	}
}
