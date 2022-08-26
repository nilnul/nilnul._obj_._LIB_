using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._sortie_;
using nilnul.obj.str.be_.distinct.vow;
using nilnul.objs.be_.distinct.vow;

namespace nilnul.obj.sortie_.ovSeq_
{



	public class EqDefault<T, TEq> :
		OvSeq<T>
		

		where TEq : IEqualityComparer<T>, new()
	{
		public EqDefault(obj.str_.SeqI2<T> val) : base(nilnul.obj_.Singleton<TEq>.Instance,  val)
		{
		}

		

		public EqDefault(IEnumerable<T> val):this(new obj.str_.Seq2<T>(val))
		{

		}

	}

	public class EqDefault<T, TEq,TStr> :
		OvSeq<T,TStr>
		

		where TEq : IEqualityComparer<T>, new()
		where TStr: nilnul.obj.str_.SeqI2<T>
	{
		public EqDefault(TStr val) : base( nilnul.obj_.Singleton<TEq>.Instance, val)
		{

		}

		
	}



}
