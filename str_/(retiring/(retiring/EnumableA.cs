using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_
{
	[Obsolete(nameof(SeqA<T>))]
	public abstract class EnumableA<T> :
		nilnul.obj.seq_._enumable_.GetEnumeratorA<T>
		,
		nilnul.obj.str_.EnumableI1<T>
	{
		//	public abstract T[] toArr();
		public T[] toArr()
		{
			return this.ToArray();
			throw new NotImplementedException();
		}
	}


}
