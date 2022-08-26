using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq.vow
{
	public class Ee<T, TStr, TVow>
		: nilnul.obj.vow.Ee1<TStr, TVow>
		where TVow : nilnul.obj.str_.seq.VowI<T, TStr>
		where TStr : nilnul.obj.str_.SeqI2<T>
	{
		public Ee(TStr val,TVow vow) : base(val, vow)
		{
		}
	}

	public class Ee<T,  TStr>
		:Ee<T,TStr, nilnul.obj.str_.seq.VowI<T, TStr>>
		where TStr : nilnul.obj.str_.SeqI2<T>

	{
		public Ee(TStr val, nilnul.obj.str_.seq.VowI<T, TStr> vow) : base(val, vow)
		{
		}
	}

	public class Ee_seqGeneral<T,  TVow>
		:Ee<T, obj.str_.SeqI2<T>, TVow>
		where TVow : nilnul.obj.str_.seq.VowI<T, obj.str_.SeqI2<T>>
	{
		public Ee_seqGeneral(obj.str_.SeqI2<T> val,TVow vow) : base(val, vow)
		{
		}
	}


	public class Ee<T>
		: Ee_seqGeneral<
			T,
			nilnul.obj.str_.seq.VowI<T, obj.str_.SeqI2<T>>
		>
	{
		public Ee(obj.str_.SeqI2<T> val, nilnul.obj.str_.seq.VowI<T, obj.str_.SeqI2<T>> vow) : base(val, vow)
		{
		}
	}




}
