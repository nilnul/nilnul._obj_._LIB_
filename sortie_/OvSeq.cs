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
	/// <summary>
	/// over (of but moreThan|over) seq; 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TStr"></typeparam>
	public class OvSeq<T,  TStr> :
		nilnul.obj.str_.seq.be_.distinct.vow.Ee<T,  TStr>
		,
		_sortie_.StrI<nilnul.obj.str_.seq.be_.distinct.vow.Ee<T,  TStr>>
		,
		nilnul.obj.ISortie

		where TStr : nilnul.obj.str_.SeqI2<T> 
	{
		public OvSeq(IEqualityComparer<T> eq,TStr val ) : base(eq,val)
		{
		}

		public nilnul.obj.str_.seq.be_.distinct.vow.Ee<T, TStr> str => this;
	}

	/// <summary>
	/// of str_.Seq
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class OvSeq<T> :
		OvSeq<T,  nilnul.obj.str_.SeqI2<T>>
		//nilnul.obj.str_.seq.be_.distinct.vow.Ee<T>
		
	{
		public OvSeq(IEqualityComparer<T> eq, nilnul.obj.str_.SeqI2<T> val) : base( eq,val)
		{
		}

		public OvSeq(IEqualityComparer<T> eq, IEnumerable<T> val) : this(
			eq
			,
			new nilnul.obj.str_.Seq2<T>(val)
		)
		{
		}
	}
}
