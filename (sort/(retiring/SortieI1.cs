using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._sortie_;
using nilnul.obj.str.be_.distinct.vow;
using nilnul.objs.be_.distinct.vow;

namespace nilnul.obj
{
	

	[Obsolete()]
	public interface SortieI2<T>
		:
		nilnul.obj._sortie_.BlankI
		,
		nilnul.obj.ISortie
		,
		nilnul.obj._sortie_.StrI1<T>
	{


	}

	[Obsolete()]
	public class Sortie2<T,  TStr> :
		nilnul.obj.str.be_.distinct.vow.Ee<T,  TStr>
		,
		_sortie_.StrI<nilnul.obj.str.be_.distinct.vow.Ee<T,  TStr>>

		where TStr : nilnul.obj.StrI2<T>
	{
		public Sortie2(IEqualityComparer<T> eq,TStr val ) : base(eq,val)
		{

		}

		public Ee<T, TStr> str => this;
	}


	[Obsolete()]
	public class Sortie2<T> :
		nilnul.obj.str.be_.distinct.vow.Ee<T>
		,
		SortieI2<T>
	{
		public Sortie2(IEqualityComparer<T> eq, obj.StrI2<T> val) : base( eq,val)
		{
		}

		public Sortie2(IEqualityComparer<T> eq, IEnumerable<T> val) : this(
			eq
			,
			(obj.StrI2<T>)new nilnul.obj.str_.Seq2<T>(val)
		)
		{
		}
	

		public Ee<T, StrI2<T>> str => this;

	}




}
