using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str
{
	public class AsSeq<T,TStr>
		:
		nilnul.obj.Box<TStr>
		,
		IEnumerable<T>
		where TStr: nilnul.obj.StrI2<T>
	{
		public AsSeq(TStr val) : base(val)
		{
		}

		public IEnumerator<T> GetEnumerator()
		{
			switch (boxed)
			{
				case nilnul.obj.str_.SeqI2<T> seq:
					return seq.GetEnumerator();
				default:
					return  new nilnul.obj.str_.sans0Started.AsSeq<T >( this.boxed.toSans0Started()).GetEnumerator();

					break;
			}

			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			//throw new NotImplementedException();
		}
	}

	public class AsSeq<T> : AsSeq<T, nilnul.obj.StrI2<T>>
	{
		public AsSeq(StrI2<T> val) : base(val)
		{
		}
	}
}
