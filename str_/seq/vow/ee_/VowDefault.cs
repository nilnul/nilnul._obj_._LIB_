using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq.vow.ee_
{

	public class VowDefault<T, TStr, TVow>
		: str_.seq.vow.Ee<T, TStr, TVow>
		where TVow : nilnul.obj.str_.seq.VowI<T, TStr>, new()
		where TStr : nilnul.obj.str_.SeqI2<T>
	{
		public VowDefault(TStr val) : base(val, nilnul.obj_.singleton_.Lazy<TVow>.Instance)
		{
		}
	}

	public class VowDefault_strGeneral<T, TVow> : VowDefault<T, nilnul.obj.str_.SeqI2<T>, TVow>
		where TVow : nilnul.obj.str_.seq.VowI<T, nilnul.obj.str_.SeqI2<T>>, new()

	{
		public VowDefault_strGeneral(SeqI2<T> val) : base(val)
		{
		}
		public VowDefault_strGeneral(IEnumerable<T> seq):this(new obj.str_.Seq2<T>(seq) )
		{

		}

	}
}
