using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._sortie_;
using nilnul.obj.str.be_.distinct.vow;
using nilnul.objs.be_.distinct.vow;

namespace nilnul.obj.sortie_
{



	public class EqDefault<T, TEq> :
		nilnul.obj.Sortie2<T>
		

		where TEq : IEqualityComparer<T>, new()
	{
		public EqDefault(obj.StrI2<T> val) : base(nilnul.obj_.Singleton<TEq>.Instance,  val)
		{
		}

		public EqDefault(obj.str_.Seq2<T> val):this( (obj.StrI2<T>)(val))
		{

		}

		public EqDefault(IEnumerable<T> val):this(new obj.str_.Seq2<T>(val))
		{

		}

	}

	public class EqDefault<T, TEq,TStr> :
		nilnul.obj.Sortie2<T,TStr>
		

		where TEq : IEqualityComparer<T>, new()
		where TStr: nilnul.obj.StrI2<T>
	{
		public EqDefault(TStr val) : base( nilnul.obj_.Singleton<TEq>.Instance, val)
		{

		}

		
	}



}
