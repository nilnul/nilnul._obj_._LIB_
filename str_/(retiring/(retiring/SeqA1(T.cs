using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_
{

	public abstract class SeqA1<T> :
		nilnul.obj.seq_.GetEnumeratorA<T>
		,
		nilnul.obj.str_.SeqI<T>
	{

		public T[] toArr()
		{
			return this.ToArray();
		}

	}
}