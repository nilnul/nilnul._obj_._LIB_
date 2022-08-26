using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq_
{

	public class OfStr<T,TStr>
	   :
	   nilnul.obj.str.AsSeq<T,TStr>
	   ,
	   SeqI2<T>
		where TStr: nilnul.obj.StrI2<T>
	{
		public OfStr(TStr val) : base(val)
		{
		}

		

		public Sans0StartedI<T> toSans0Started()
		{
			return boxed.toSans0Started();

		}

		
	}

	public class OfStr<T> : OfStr<T, nilnul.obj.StrI2<T>>
	{
		public OfStr(StrI2<T> val) : base(val)
		{
		}
	}

	static public class OfStrX
	{

	}



}
