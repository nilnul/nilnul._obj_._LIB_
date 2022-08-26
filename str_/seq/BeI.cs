using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq
{
	public interface BeI1<T>
		:nilnul.obj.BeI1<nilnul.obj.str_.SeqI2<T>>
	{

	}


	public interface BeI1<T,TStr>
		:nilnul.obj.BeI1<TStr>
		where TStr:nilnul.obj.str_.SeqI2<T>
	{

	}

	public abstract class BeA1<TEl>
		: BeI1<TEl>
		,
		nilnul.obj.seq.BeI<TEl>
	{
		public abstract bool be(SeqI2<TEl> obj);

		public bool be(IEnumerable<TEl> obj)
		{
			return be(new Seq2<TEl>(obj) );
		}
	}



}
