using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq_._enumable_
{
	[Obsolete(nameof(nilnul.obj.seq_.GetEnumeratorA<T>))]
	public abstract class GetEnumeratorA<T> : IEnumerable<T>
	{
		public abstract IEnumerator<T> GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}






}
